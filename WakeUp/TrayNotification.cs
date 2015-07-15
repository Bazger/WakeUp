using System;
using System.Drawing;
using System.Windows.Forms;

namespace WakeUp
{
    public partial class TrayNotification : Telerik.WinControls.UI.RadForm
    {
        readonly MainForm _mainform;
        public TrayNotification(MainForm mainform)
        {
            _mainform = mainform;
            InitializeComponent();
            TrayNotifylab.Font = new Font(TrayNotifylab.Font.FontFamily.Name, 16);
            TopMost = true;
        }

        private void TrayNotification_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            Rectangle rect = Screen.GetWorkingArea(this);
            Location = new Point(rect.Width - Width - 15, rect.Height);
            _mainform.Enabled = false;
            timerOpen.Enabled = true;
        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
            Rectangle rect = Screen.GetWorkingArea(this);

            int pos = Location.Y;

            if (pos > (rect.Height - Height))
            {
                pos -= 6;
                Location = new Point(rect.Width - Width - 15, pos);
            }
            else
            {
                timerOpen.Enabled = false;
            }
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Rectangle rect = Screen.GetWorkingArea(this);

            int pos = Location.Y;

            if (pos < (rect.Height))
            {
                pos += 6;
                Location = new Point(rect.Width - Width - 15, pos);
            }
            else
            {
                if (!_mainform.Normal && _mainform.Index < _mainform._dataGridView.Rows.Count)
                {
                    _mainform._dataGridView.Rows[_mainform.Index - 1].Selected = false;
                    _mainform._dataGridView.Rows[_mainform.Index].Selected = true;
                    if (_mainform.Index == _mainform.ScrollIndex)
                    {
                        _mainform._dataGridView.FirstDisplayedScrollingRowIndex = _mainform.ScrollIndex;
                        _mainform.ScrollIndex += 5;
                    }
                    _mainform.Timer.Start();
                }
                timerClose.Enabled = false;
                if (_mainform.Repeat)
                    _mainform.Timer.Start();
                _mainform.Wmp.close();
                _mainform.Enabled = true;

                if (_mainform.WindowState == FormWindowState.Normal && ((_mainform.Music || _mainform.Popup) && _mainform.Repeat == false) || (_mainform.Repeattimes == 0 && _mainform.Repeattimescheckbox.Checked))
                {
                    _mainform.TopMost = true;
                    _mainform.TopMost = false;
                }

                if (_mainform.Minimized && ((_mainform.Music || _mainform.Popup) && _mainform.Repeat == false) || (_mainform.Repeattimes == 0 && _mainform.Repeattimescheckbox.Checked))
                {
                    _mainform.Open();
                }
                Close();
            }
        }

        private void OKbut_Click(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
        }
    }
}
