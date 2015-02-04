using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Custom.Controls
{
    public class NotificationBox : IDisposable
    {
        private readonly NotificationBoxForm _form;
        private readonly NotificationBoxComponent _title;
        private readonly NotificationBoxComponent _message;
        private ContentAlignment _alignment;

        public ContentAlignment Alignment
        {
            get
            {
                return _alignment;
            }
            set
            {
                int left = Screen.PrimaryScreen.WorkingArea.Right - Width - 10;
                int top = Screen.PrimaryScreen.WorkingArea.Bottom - Height - 10;

                switch (value)
                {
                    case ContentAlignment.TopLeft:
                        left = Screen.PrimaryScreen.WorkingArea.Left + 10;
                        top = Screen.PrimaryScreen.WorkingArea.Top + 10;
                        break;
                    case ContentAlignment.TopCenter:
                        left = (((Screen.PrimaryScreen.WorkingArea.Right - Screen.PrimaryScreen.WorkingArea.Left) / 2) +
                                Screen.PrimaryScreen.WorkingArea.Left) - (Width / 2);
                        top = Screen.PrimaryScreen.WorkingArea.Top + 10;
                        break;
                    case ContentAlignment.TopRight:
                        left = Screen.PrimaryScreen.WorkingArea.Right - Width - 10;
                        top = Screen.PrimaryScreen.WorkingArea.Top + 10;
                        break;
                    case ContentAlignment.MiddleLeft:
                        left = Screen.PrimaryScreen.WorkingArea.Left + 10;
                        top = ((Screen.PrimaryScreen.WorkingArea.Height / 2) +
                               Screen.PrimaryScreen.WorkingArea.Top) - (Height / 2);
                        break;
                    case ContentAlignment.MiddleCenter:
                        left = ((Screen.PrimaryScreen.WorkingArea.Width / 2) +
                                Screen.PrimaryScreen.WorkingArea.Left) - (Width / 2);
                        top = ((Screen.PrimaryScreen.WorkingArea.Height / 2) +
                               Screen.PrimaryScreen.WorkingArea.Top) - (Height / 2);
                        break;
                    case ContentAlignment.MiddleRight:
                        left = Screen.PrimaryScreen.WorkingArea.Right - Width - 10;
                        top = ((Screen.PrimaryScreen.WorkingArea.Height / 2) +
                               Screen.PrimaryScreen.WorkingArea.Top) - (Height / 2);
                        break;
                    case ContentAlignment.BottomLeft:
                        left = Screen.PrimaryScreen.WorkingArea.Left + 10;
                        top = Screen.PrimaryScreen.WorkingArea.Bottom - Height - 10;
                        break;
                    case ContentAlignment.BottomCenter:
                        left = (((Screen.PrimaryScreen.WorkingArea.Right - Screen.PrimaryScreen.WorkingArea.Left) / 2) +
                                Screen.PrimaryScreen.WorkingArea.Left) - (Width / 2);
                        top = Screen.PrimaryScreen.WorkingArea.Bottom - Height - 10;
                        break;
                }

                _form.Location = new Point(left, top);

                _alignment = value;
            }
        }

        public DialogResult DialogResult
        {
            get { return _form.DialogResult; }
            private set { _form.DialogResult = value; }
        }

        public double Fade
        {
            get
            {
                if (_form.IsDisposed) return 0;

                double val = 0;
                _form.Invoke(new MethodInvoker(delegate
                {
                    val = 1 - _form.Opacity;
                }));
                return val;
            }
            set
            {
                if (_form.IsDisposed) return;

                double val = 1 - value;
                if (val < 0) val = 0;
                if (val > 1) val = 1;
                _form.Invoke(new MethodInvoker(delegate
                {
                    _form.Opacity = val;
                }));
            }
        }

        public Font Font
        {
            get
            {
                return _form.Font;
            }
            set
            {
                _form.Font = value;
                _title.Font = value;
                _message.Font = value;
            }
        }

        public int Height
        {
            get { return _form.Height; }
            set { _form.Height = value; }
        }

        public int Width
        {
            get { return _form.Width; }
            set { _form.Width = value; }
        }

        public DialogResult ShowDialog()
        {
            _form.ShowDialog();
            return DialogResult;
        }

        private void FormOnClick(object sender, EventArgs eventArgs)
        {
            DialogResult = DialogResult.Yes;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        public void Dispose()
        {
            _form.Dispose();
        }

        public NotificationBox(string Title, string Message, int PreFadeTime, int FadeTime, ContentAlignment Alignment)
        {
            _form = new NotificationBoxForm(PreFadeTime, FadeTime)
            {
                BackColor = Color.White,
                ControlBox = false,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Size = new Size(320, 75),
                StartPosition = FormStartPosition.Manual,
                TopMost = true
            };
            _form.Click += FormOnClick;

            _message = new NotificationBoxComponent
            {
                BackColor = Color.LightGoldenrodYellow,
                Margin = new Padding(3, 0, 3, 0),
                Text = Message,
                TextAlignment = ContentAlignment.TopLeft
            };
            _form.Controls.Add(_message.ToControl());
            _message.Dock = DockStyle.Fill;
            _message.ToControl().MouseDown += OnMouseDown;

            _title = new NotificationBoxComponent
            {
                BackColor = Color.PaleGoldenrod,
                Margin = new Padding(3),
                Text = Title,
                TextAlignment = ContentAlignment.MiddleLeft
            };
            _form.Controls.Add(_title.ToControl());
            _title.Dock = DockStyle.Top;
            _title.ToControl().MouseDown += OnMouseDown;

            DialogResult = DialogResult.No;
            this.Alignment = Alignment;
        }

        internal class NotificationBoxForm : Form
        {
            private Thread _faderThread;
            private readonly int _preFadeTime;
            private readonly int _fadeTime;

            public double Fade
            {
                get
                {
                    if (IsDisposed) return 0;

                    double val = 0;
                    Invoke(new MethodInvoker(delegate
                    {
                        val = 1 - Opacity;
                    }));
                    return val;
                }
                set
                {
                    if (IsDisposed) return;

                    double val = 1 - value;
                    if (val < 0) val = 0;
                    if (val > 1) val = 1;
                    Invoke(new MethodInvoker(delegate
                    {
                        Opacity = val;
                    }));
                }
            }

            private void FaderThread()
            {
                try
                {
                    Thread.Sleep(_preFadeTime * 1000);

                    var count = _fadeTime * 10;

                    for (int i = 1; i <= count; i++)
                    {
                        Fade = (1.00 / count) * i;

                        Thread.Sleep(100);
                    }

                    if (!IsDisposed) Invoke(new MethodInvoker(Close));
                }
                catch (Exception) { }
            }

            const int WM_NCLBUTTONDOWN = 0x00A1;

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == WM_NCLBUTTONDOWN)
                {
                    if (Cursor.Current != null) Cursor = new Cursor(Cursor.Current.Handle);
                    InvokeOnClick(this, EventArgs.Empty);
                }
            }

            protected override void OnShown(EventArgs e)
            {
                _faderThread = new Thread(FaderThread);
                _faderThread.Start();
            }

            protected override void OnClosing(CancelEventArgs e)
            {
                if (_faderThread.IsAlive) _faderThread.Abort();
                base.OnClosing(e);
            }

            internal NotificationBoxForm(int PreFadeTime, int FadeTime)
            {
                _preFadeTime = PreFadeTime;
                _fadeTime = FadeTime;
            }
        }

        internal class NotificationBoxComponent
        {
            #region VARIABLES

            private readonly Label _label;

            #endregion

            #region PROPERTIES

            public Color BackColor
            {
                get { return _label.BackColor; }
                set { _label.BackColor = value; }
            }

            internal DockStyle Dock
            {
                set { _label.Dock = value; }
            }

            public Font Font
            {
                get { return _label.Font; }
                set { _label.Font = value; }
            }

            public Padding Margin
            {
                get { return _label.Margin; }
                set { _label.Margin = value; }
            }

            public Padding Padding
            {
                get { return _label.Padding; }
                set { _label.Padding = value; }
            }

            public string Text
            {
                get { return _label.Text; }
                set { _label.Text = value.Trim(); }
            }

            public ContentAlignment TextAlignment
            {
                get { return _label.TextAlign; }
                set { _label.TextAlign = value; }
            }

            #endregion

            internal Control ToControl()
            {
                return _label;
            }

            internal NotificationBoxComponent()
            {
                _label = new Label();
            }
        }
    }
}
