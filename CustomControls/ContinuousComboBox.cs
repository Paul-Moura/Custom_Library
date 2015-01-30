using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ContinuousComboBox : UserControl
    {
        #region VARIABLES
        
        private int _defaultIndex = 0;
        private List<ComboBox> _values = new List<ComboBox>();
        private List<string> _options;
        
        #endregion

        #region PROPERTIES

        public int DefaultIndex
        {
            get { return _defaultIndex; }
            set { _defaultIndex = value; }
        }

        public string[] Options
        {
            get { return _options.ToArray(); }
            set
            {
                foreach (string s in value)
                {
                    _options.Add(s);
                }
                _options = _options.Distinct().OrderBy(x => x).ToList();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        [ReadOnly(true)]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int[] Values
        {
            get
            {
                var list = new int[_values.Count];
                for (int i = 0; i < _values.Count; i++)
                {
                    ComboBox cb = _values[i];
                    list[i] = cb.SelectedIndex;
                }
                return list;
            }
        }

        #endregion

        #region CONSTRUCTORS
        
        public ContinuousComboBox()
        {
            _options = new List<string>();
            InitializeComponent();
        }

        public ContinuousComboBox(string[] options)
        {
            Options = options;
            InitializeComponent();
        }

        #endregion

        #region METHODS

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            int w = (from Control c in Controls select c.Right).Concat(new[] {0}).Max()+2;
            int h = (from Control c in Controls select c.Bottom).Concat(new[] { 0 }).Max()+2;
            base.SetBoundsCore(x, y, w, h, specified);
        }

        private void ContinuousComboBox_Load(object sender, EventArgs e)
        {
            if (DesignMode) return; 
            Controls.Remove(comboBox1);
            AddComboBox();
        }

        private void AddComboBox()
        {
            var cmb = new ComboBox();
            cmb.AutoSize = true;

            cmb.Items.Add("");

            foreach (string s in _options)
            {
                cmb.Items.Add(s);
            }

            if (_options.Count > _defaultIndex)
            {
                cmb.SelectedIndex = _defaultIndex;
            }

            cmb.SelectedIndexChanged += CmbOnSelectedIndexChanged;

            _values.Add(cmb);

            Controls.Add(cmb);

            cmb.Dock = DockStyle.Left;
            cmb.BringToFront();

            AutoScrollMinSize = new Size(cmb.Right, 0);
        }

        private void CmbOnSelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;
            if (cmb != null)
            {
                if (cmb.SelectedIndex == 0)
                {
                    if (_values.Count(x => x.SelectedIndex == 0) > 1)
                    {
                        Controls.Remove(cmb);
                        _values.Remove(cmb);
                    }
                    else
                    {
                        cmb.BringToFront();
                    }
                }
                else if (_values.All(x => x.SelectedIndex != 0))
                {
                    AddComboBox();
                }
            }
        }

        #endregion
    }
}
