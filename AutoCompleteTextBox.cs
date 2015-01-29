using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomControls
{
    public enum SuggestionAlignment { Left, Right }

    [ToolboxItem(true)]
    [ToolboxBitmapAttribute(typeof(TextBox))]
    public sealed class AutoCompleteTextBox : TextBox
    {
        #region VARIABLES

        private readonly ListBox _listBox;
        private readonly Panel _panel;
        private List<string> _autoCompleteList = new List<string>();
        private List<string> _cachedAutoCompleteList = new List<string>(); 
        private readonly List<string> _currentAutoCompleteList = new List<string>();
        private bool _caseSensitive;
        private int _minTypedCharacters;
        private int _maxDisplayedItems;
        private SuggestionAlignment _suggestionAlignment;
        private string _file;

        #endregion VARIABLES

        #region PROPERTIES

        [ReadOnly(true)]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsolete.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AutoCompleteStringCollection AutoCompleteCustomSource { get; set; }

        [ReadOnly(true)]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsolete.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AutoCompleteMode AutoCompleteMode { get; set; }

        [ReadOnly(true)]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("This property is obsolete.", true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new AutoCompleteSource AutoCompleteSource { get; set; }

        [Browsable(true)]
        [Description("The list of items displayed in the suggestion drop-down menu.")]
        [Category("Suggestion Menu")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public List<string> AutoCompleteList
        {
            get
            {
                return _autoCompleteList;
            }
            set
            {
                if (value == null) return;

                _autoCompleteList = value;
            }
        }

        [Browsable(true)]
        [Description("Determines whether the filtering of suggestion drop-down menu is case-sensitive.")]
        [Category("Suggestion Menu")]
        public bool CaseSensitive
        {
            get
            {
                return _caseSensitive;
            }
            set
            {
                _caseSensitive = value;
            }
        }

        [Browsable(true)]
        [Description("The alignment of the text in the Suggestion Menu.")]
        [Category("Suggestion Menu")]
        public SuggestionAlignment SuggestionAlignment
        {
            get
            {
                return _suggestionAlignment;
            }
            set
            {
                _suggestionAlignment = value;
            }
        }
        
        [Browsable(true)]
        [Description("The font of the Suggestion Menu.")]
        [Category("Suggestion Menu")]
        public Font SuggestionFont
        {
            get
            {
                return _listBox.Font;
            }
            set
            {
                _listBox.Font = value;
            }
        }

        [Browsable(true)]
        [Description("The maximum number of lines to display in the Suggestion Menu.")]
        [Category("Suggestion Menu")]
        public int MaxDisplayedItems
        {
            get
            {
                return _maxDisplayedItems;
            }
            set 
            {
                _maxDisplayedItems = value <= 2 ? 2 : value;
            }
        }

        [Browsable(true)]
        [Description("The minimum number of character required before the Suggestion Menu is displayed.")]
        [Category("Suggestion Menu")]
        public int MinTypedCharacters
        {
            get
            {
                return _minTypedCharacters;
            }
            set 
            {
                _minTypedCharacters = value <= 1 ? 1 : value;
            }
        }

        [Browsable(true)]
        [Description("The file used to store new AutoComplete Suggestion Items.")]
        [Category("Suggestion Menu")]
        [Editor(typeof(FileNameEditor2), typeof(UITypeEditor))]
        public string SuggestionsFile
        {
            get { return _file; }
            set
            {
                _file = value;
                LoadCachedSuggestionItems();
            }
        }

        /// <summary>
        /// The parent Form of this control.
        /// </summary>
        private Form ParentForm
        {
            get { return Parent.FindForm(); }
        }

        private int SelectedIndex
        {
            get
            {
                return _listBox.SelectedIndex;
            }
            set
            {
                if (_listBox != null && _listBox.Items.Count > 0)
                {
                    _listBox.SelectedIndex = value;
                }
            }
        }

        #endregion PROPERTIES

        #region CONSTRUCTORS

        public AutoCompleteTextBox()
        {
            _caseSensitive = false;
            _minTypedCharacters = 3;
            _maxDisplayedItems = 10;

            _listBox = new ListBox
            {
                DataSource = _currentAutoCompleteList,
                Dock = DockStyle.Fill,
                Font = Font,
                Name = "SuggestionListBox",
                SelectionMode = SelectionMode.One,
                Visible = true,
            };

            _listBox.MouseClick += ListBoxOnMouseClick;
            _listBox.KeyDown += OnKeyDown;

            _panel = new Panel
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.Transparent,
                ClientSize = new Size(1, 1),
                Font = Font,
                ForeColor = Color.Transparent,
                Margin = new Padding(0, 0, 0, 0),
                Name = "SuggestionPanel",
                Padding = new Padding(0, 0, 0, 0),
                Text = "",
                Visible = false,
            };

            _panel.PerformLayout();

            if (!_panel.Controls.Contains(_listBox))
            {
                _panel.Controls.Add(_listBox);
            }

            LoadCachedSuggestionItems();

            KeyDown += OnKeyDown;
            LostFocus += OnLostFocus;
            TextChanged += OnTextChanged;
        }

        #endregion CONSTRUCTORS

        #region METHODS

        private void LoadCachedSuggestionItems()
        {
            try
            {
                if (!File.Exists(SuggestionsFile)) return;
                if (Path.GetExtension(SuggestionsFile) != ".txt") return;

                var lines = File.ReadAllLines(SuggestionsFile);
                _cachedAutoCompleteList.AddRange(lines);
            }
            catch (Exception){}
        }

        private void AddCachedSuggestionItem(string item)
        {
            try
            {
                if (string.IsNullOrEmpty(SuggestionsFile)) return;
                if (SuggestionsFile.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0) return;
                if (Path.GetExtension(SuggestionsFile) != ".txt") return;

                if (string.IsNullOrWhiteSpace(item)) return;

                if (item.Length < MinTypedCharacters) return;

                if (_cachedAutoCompleteList.Contains(item)) return;

                using (var writer = new StreamWriter(SuggestionsFile, true))
                {
                    writer.WriteLine(item);
                    writer.Close();
                }

                _cachedAutoCompleteList.Add(item);
            }
            catch (Exception){}
        }

        private void RemoveCachedSuggestionItem(string item)
        {
            try
            {
                if (!File.Exists(SuggestionsFile)) return;

                if (string.IsNullOrWhiteSpace(item)) return;

                if (!_cachedAutoCompleteList.Contains(item)) return;

                _cachedAutoCompleteList.Add(item);

                File.Delete(SuggestionsFile);
                File.WriteAllLines(SuggestionsFile, _cachedAutoCompleteList);
            }
            catch (Exception){}
        }

        /// <summary>
        /// Hides the Suggestion ListBox.
        /// </summary>
        private void HideSuggestions()
        {
            if (ParentForm != null)
            {
                // Hide the Panel (which hides the ListBox)
                _panel.Hide();

                // Remove it from the parent form
                if (ParentForm.Controls.Contains(_panel))
                {
                    ParentForm.Controls.Remove(_panel);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        private void MoveSelectionInListBox(int index)
        {
            if (index <= -1)
            {
                SelectedIndex = 0;
            }
            else if (index > (_listBox.Items.Count - 1))
            {
                SelectedIndex = _listBox.Items.Count - 1;
            }
            else
            {
                SelectedIndex = index;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SelectItem()
        {
            // Make sure ListBox has items
            if (_listBox.Items.Count > 0 && SelectedIndex > -1)
            {
                // Set the Text of the TextBox to the selected item of the ListBox
                Text = _listBox.SelectedItem.ToString();

                // Hide the ListBox
                HideSuggestions();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ShowSuggestions()
        {
            // Show only if the minimium required number of characters has been typed
            if (Text.Length >= _minTypedCharacters)
            {
                // Prevent overlapping problems with other controls
                // while loading data. There is nothing to draw, so suspend layout.
                _panel.SuspendLayout();

                UpdateCurrentAutoCompleteList();

                if (_currentAutoCompleteList != null && _currentAutoCompleteList.Count > 0)
                {
                    // Show Panel and ListBox after the refresh (prevents drawing empty rectangles)
                    _panel.Show();

                    // Move Panel infront of all other controls
                    _panel.BringToFront();

                    // Set focus back to TextBox
                    Focus();
                }
                else // Hide if no results
                {
                    HideSuggestions();
                }

                // Prevent overlapping problems with other controls
                _panel.ResumeLayout(true);
            }
            else // Hide if less than minimium required number of characters has been typed
            {
                HideSuggestions();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateCurrentAutoCompleteList()
        {
            // Clear the list to re-populate it
            _currentAutoCompleteList.Clear();

            // Get the text currently typed in the TextBox
            var subString = _caseSensitive ? Text.ToLower() : Text;
            var filter = subString.Split(' ');

            foreach (string str in from str in _autoCompleteList let s = _caseSensitive ? str.ToLower() : str let isValid = filter.All(s.Contains) where isValid select str)
            {
                _currentAutoCompleteList.Add(str);
            }

            foreach (string str in from str in _cachedAutoCompleteList let s = _caseSensitive ? str.ToLower() : str let isValid = filter.All(s.Contains) where isValid select str)
            {
                _currentAutoCompleteList.Add(str);
            }

            // Update the ListBox's visual display
            UpdateListBoxItems();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateListBoxItems()
        {
            // Exit Method is there is no Parent Form
            if (ParentForm == null || _currentAutoCompleteList.Count <= 0) return;

            var gSize = new Size(0, 0);

            foreach (string s in _currentAutoCompleteList)
            {
                var g = TextRenderer.MeasureText(s, _listBox.Font);
                if (g.Width > gSize.Width) gSize = g;
            }

            if (_currentAutoCompleteList.Count > _maxDisplayedItems)
            {
                _panel.Height = _maxDisplayedItems * (gSize.Height + 1) + 4;

                _panel.Width = 10 + gSize.Width + SystemInformation.VerticalScrollBarWidth;
            }
            else
            {
                _panel.Height = _currentAutoCompleteList.Count * (gSize.Height + 1) + 4;

                _panel.Width = 10 + gSize.Width;
            }

            if (_suggestionAlignment == SuggestionAlignment.Left)
            {
                _panel.Location = Location + new Size(0, Height);
            }
            else
            {
                _panel.Location = Location + new Size((Width - _panel.Width), Height);
            }

            if (!ParentForm.Controls.Contains(_panel))
            {
                ParentForm.Controls.Add(_panel);
            }

            ((CurrencyManager)_listBox.BindingContext[_currentAutoCompleteList]).Refresh();
        }

        #endregion METHODS

        #region EVENTS

        private void OnKeyDown(object s, KeyEventArgs e)
        {
            // if user presses key.up
            if ((e.KeyCode == Keys.Up))
            {
                // move the selection in listbox one up
                MoveSelectionInListBox((SelectedIndex - 1));
                // work is done
                e.Handled = true;
            }
            // on key.down
            else if ((e.KeyCode == Keys.Down))
            {
                //move one down
                MoveSelectionInListBox((SelectedIndex + 1));
                e.Handled = true;
            }
            else if ((e.KeyCode == Keys.PageUp))
            {
                //move up by the MaxDisplayedItems
                if (_listBox.TopIndex > MaxDisplayedItems)
                {
                    _listBox.TopIndex = _listBox.TopIndex - _maxDisplayedItems;
                }
                else
                {
                    _listBox.TopIndex = 0;
                }

                MoveSelectionInListBox(SelectedIndex - _maxDisplayedItems);
                e.Handled = true;
            }
            else if ((e.KeyCode == Keys.PageDown))
            {
                //move down by the MaxDisplayedItems
                _listBox.TopIndex = _listBox.TopIndex + _maxDisplayedItems;
                MoveSelectionInListBox(SelectedIndex + _maxDisplayedItems);
                //MoveSelectionInListBox((SelectedIndex + 10));
                e.Handled = true;
            }
            // on enter
            else if (e.KeyCode == Keys.Enter)
            {
                // select the item in the ListBox
                SelectItem();
                e.Handled = true;
            }
            // on ESC
            else if (e.KeyCode == Keys.Escape)
            {
                // hide the suggestions
                HideSuggestions();
                e.Handled = true;
            }
            // on Delete
            else if (e.KeyCode == Keys.Delete)
            {
                if (_listBox.Focused)
                {
                    var item = _listBox.Text;
                    RemoveCachedSuggestionItem(item);
                    ShowSuggestions();
                }
            }
        }

        private void OnLostFocus(object s, EventArgs e)
        {
            if (!_panel.ContainsFocus)
            {
                // then hide the stuff
                HideSuggestions();

                AddCachedSuggestionItem(Text);
            }
        }

        private void OnTextChanged(object s, EventArgs e)
        {
            // avoids crashing the designer
            if (!DesignMode) ShowSuggestions();
        }

        private void ListBoxOnMouseClick(object s, MouseEventArgs e)
        {
            // Select the current item
            SelectItem();
        }

        #endregion EVENTS
    }

    public class FileNameEditor2 : FileNameEditor
    {
        protected override void InitializeDialog(OpenFileDialog openFileDialog)
        {
            base.InitializeDialog(openFileDialog);
            openFileDialog.Filter = "TXT|*.txt";
            openFileDialog.CheckFileExists = false;
        }
    }
}
