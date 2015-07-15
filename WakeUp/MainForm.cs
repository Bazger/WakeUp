using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using WakeUp.Properties;
using WMPLib;

namespace WakeUp // Normal Width 346 // Pro Width 524 // All Width 870 
{
    public partial class MainForm : RadForm
    {
        private const int scrollConst = 5;
        private readonly Icon clockIcon = Resources.Clock;
        private readonly Icon notificationIcon = Resources.Notify;
        public readonly DataGridView _dataGridView;


        public bool Message;
        public bool Repeat;
        public bool Music;
        public bool Popup;
        public bool RepeatTray;
        public int Repeattimes = 0;
        public int DataTimes = -1;
        public int Index = 0;
        public int RepeatTrayMessage = 1;
        private int _minutes;
        private int _seconds;
        private int _restsec;
        private int _restmin;
        private int _min1;
        private int _min2;
        private int _sec1;
        private int _sec2;
        private int _rep1;
        private bool _start;
        private bool _checking;
        private bool _startcheck;
        private bool _musiccheck;
        private bool _trayMessage;
        private DialogResult result;
        public bool Normal = true;
        private const int ProLength = 534;
        private readonly int _startPanelLocationX;
        private readonly int _startWakeAppWidth;
        public bool Notificon = true;
        public int ScrollIndex = 5;
        public bool Minimized = false;

        private string _musicUrl = @"music.mp3";
        private const int Volume = 100;
        public WMPLib.WindowsMediaPlayer Wmp = new WMPLib.WindowsMediaPlayer();

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            notifyIcon.Visible = false;
            notifyIcon.Icon = clockIcon;
            _dataGridView = dataGridView;
            notifyIcon.Text = "WakeUp!";
            notifyIcon.ContextMenuStrip = contextMenuStrip;
            openFileDialog.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            Browsebut.Enabled = false;
            BrowsetextBox.Enabled = false;
            SetDefaultMusicbut.Enabled = false;
            SetDefaultMusiclab.Enabled = false;
            ShowInTaskbar = true;
            _startPanelLocationX = Panel.Location.X;
            _startWakeAppWidth = Width;
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light"; //Change the theme of all of the form objects
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_start)
            {
                _seconds--;
                if (_minutes == 0 && _seconds == 0)
                {
                    if (Minimized && !Normal)
                        ProTimerTray.Start();
                    if (Repeat == false)
                    {
                        if (Normal)
                        {
                            TimerStart();
                            MessageTypes(1);
                        }
                        else
                            ProTimerWithoutRepeat();
                    }
                    else
                    {
                        RepeatTray = true;
                        //Repeat times check
                        if (Repeattimescheckbox.Checked)
                        {
                            if (Normal)
                            {
                                Repeattimes--;
                                if (Repeattimes == 0)
                                {
                                    Repeattimeslab.Text = ("Repeat times: 0");
                                    TimerStart();
                                    MessageTypes(1);
                                }
                                else
                                {
                                    Time.Text = ("00:00");
                                    Timer.Stop();
                                    Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
                                    MessageTypes(2);

                                    if (Message == false && Music == false && Popup == false)
                                    {
                                        Timer.Start();
                                    }

                                    TimerWork();
                                }
                            }
                            else
                            {
                                if (Repeattimes == 1)
                                    ProTimerWithoutRepeat();
                                else
                                    ProTimerWithRepeat();
                            }
                        }
                        else
                        {
                            if (Normal)
                            {
                                Time.Text = ("00:00");
                                Timer.Stop();
                                Repeattimes++;
                                Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
                                MessageTypes(2);
                                TimerWork();
                            }
                            else
                                ProTimerWithRepeat();
                        }
                    }
                    if (Minimized && _checking == false && Normal)
                    {
                        if (Repeat)
                        {
                            if (RepeatTrayMessage == 1)
                            {
                                notifyIcon.ShowBalloonTip(500, "Message", "Time is over", ToolTipIcon.None);
                            }
                            else
                            {
                                notifyIcon.ShowBalloonTip(500, "Message (" + RepeatTrayMessage + ")", "Time is over", ToolTipIcon.None);
                            }
                            RepeatTrayMessage++;
                        }
                        else
                        {
                            notifyIcon.ShowBalloonTip(500, "Message", "Time is over", ToolTipIcon.None);
                        }
                    }

                    if (Minimized && ((Music || Message) && Repeat == false) || (Repeattimes == 0 && Repeattimescheckbox.Checked))
                    {
                        Open();
                    }
                }
                else
                {
                    if (_seconds == -1)
                    {
                        _seconds = 59;
                        _minutes--;
                    }

                    _min1 = _minutes / 10;
                    _min2 = _minutes % 10;
                    _sec1 = _seconds / 10;
                    _sec2 = _seconds % 10;
                    Time.Text = (_min1 + "" + _min2 + ":" + _sec1 + "" + _sec2);
                }
            }
        }

        private void Startbut_Click(object sender, EventArgs e)
        {
            //Start Button
            if (_start == false)
            {
                _start = true;
                _startcheck = true;
                Startbut.Text = "Pause";
                startToolStripMenuItem.Text = "Pause";
                Timer.Start();
                Changebut.Enabled = false;
                Restartbut.Enabled = true;
                restartToolStripMenuItem.Enabled = true;
            }
            //Pause Button
            else
            {
                _start = false;
                Startbut.Text = "Start";
                startToolStripMenuItem.Text = "Start";
                Timer.Stop();
                Changebut.Enabled = true;
            }
        }

        private void SetTimebut_Click(object sender, EventArgs e)
        {
            if (Normal)
            {
                _minutes = int.Parse(MinutesNumericUpDown.Text);
                _seconds = int.Parse(SecondsNumericUpDown.Text);
                _restmin = _minutes;
                _restsec = _seconds;
                TimerWork();

                if (_minutes > 0 || _seconds > 0)
                {
                    OkButMethod();
                }
            }
            else
            {
                if (DataTimes > 0)
                {
                    for (int i = 0; i < _dataGridView.Rows.Count; i++)
                        _dataGridView.Rows[i].Selected = false;
                    _dataGridView.Rows[0].Selected = true;
                    Index = 0;
                    _dataGridView.FirstDisplayedScrollingRowIndex = Index;
                    ScrollIndex = 5;
                    ProTimeShare();
                    TimerWork();
                    OkButMethod();
                }
            }
        }

        private void Changebut_Click(object sender, EventArgs e)
        {
            Startbut.Enabled = false;
            Changebut.Enabled = false;
            Restartbut.Enabled = false;
            Repeattimeslab.Enabled = false;
            startToolStripMenuItem.Enabled = false;
            restartToolStripMenuItem.Enabled = false;

            SetTimebut.Enabled = true;
            MinutesNumericUpDown.Enabled = true;
            SecondsNumericUpDown.Enabled = true;
            Repeatcheckbox.Enabled = true;
            Musiccheckbox.Enabled = true;
            Minuteslab.Enabled = true;
            Secondslab.Enabled = true;
            WriteTheTime.Enabled = true;
            Probut.Enabled = true;
            Addbut.Enabled = Removebut.Enabled = _dataGridView.Enabled = true;
            _checking = false;

            if (Repeattimescheckbox.Checked)
            {
                Repeattimes = _rep1;
                Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
            }
            else
            {
                Repeattimes = 0;
                Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
            }

            if (Repeatcheckbox.Checked)
            {
                Repeattimescheckbox.Enabled = true;
            }
            if (Repeattimescheckbox.Checked)
            {
                RepeattimesNumericUpDown.Enabled = true;
            }

            if (Musiccheckbox.Checked)
            {
                BrowsetextBox.Enabled = true;
                Browsebut.Enabled = true;
            }

            if (_musiccheck)
            {
                SetDefaultMusicbut.Enabled = true;
                SetDefaultMusiclab.Enabled = true;
            }
            else
            {
                SetDefaultMusicbut.Enabled = false;
                SetDefaultMusiclab.Enabled = false;
            }
            if (Popup == false && Message == false)
            {
                Messagecheckbox.Enabled = true;
                Popupcheckbox.Enabled = true;
            }
            else
            {
                if (Message)
                {
                    Popupcheckbox.Enabled = false;
                    Messagecheckbox.Enabled = true;
                }
                else
                {
                    Popupcheckbox.Enabled = true;
                    Messagecheckbox.Enabled = false;
                }
            }
            if (!Normal)
                _dataGridView.FirstDisplayedScrollingRowIndex = 0;
        }

        private void Restartbut_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            _start = false;
            Changebut.Enabled = true;
            Startbut.Text = "Start";
            Startbut.Enabled = true;
            startToolStripMenuItem.Text = "Start";
            startToolStripMenuItem.Enabled = true;
            Index = 0;
            ScrollIndex = 5;

            if (!Normal)
            {
                for (int i = 0; i < _dataGridView.Rows.Count; i++)
                    _dataGridView.Rows[i].Selected = false;
                _dataGridView.Rows[0].Selected = true;
                ProTimeShare();
                TimerWork();
                _dataGridView.FirstDisplayedScrollingRowIndex = Index;
            }
            else
            {
                //Set the time
                TimerWork();
            }

            if (Repeatcheckbox.Checked)
            {
                Repeattimes = _rep1;
                Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
            }
            else
            {
                Repeattimes = 0;
                Repeattimeslab.Text = ("Repeat times: 0");
            }

            Restartbut.Enabled = false;
            restartToolStripMenuItem.Enabled = false;
            notifyIcon.Icon = clockIcon;
        }

        private void Exitbut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Repeatcheckbox_CheckedChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (Repeatcheckbox.Checked)
            {
                Repeattimescheckbox.Enabled = true;
            }
            else
            {
                Repeattimescheckbox.Checked = false;
                Repeattimescheckbox.Enabled = false;
            }
        }

        private void Repeattimescheckbox_CheckedChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            RepeattimesNumericUpDown.Enabled = Repeattimescheckbox.Checked;
            RepeattimesNumericUpDown.Text = "1";
        }

        private void Repeattimescheckbox_ToggleStateChanging(object sender, Telerik.WinControls.UI.StateChangingEventArgs args)
        {
            RepeattimesNumericUpDown.Text = "1";
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Open();
        }

        private void TimerTray_Tick(object sender, EventArgs e)
        {
            if (Minimized && _startcheck && (_minutes == 0 && _seconds == 0 || RepeatTray))
            {
                if (icon == 0)
                {
                    notifyIcon.Icon = notificationIcon;
                    icon = 1;
                }
                else
                {
                    notifyIcon.Icon = clockIcon;
                    icon = 0;
                }
            }
        }

        private void ProTimerTray_Tick(object sender, EventArgs e)
        {
            if (Notificon)
            {
                notifyIcon.Icon = notificationIcon;
                Notificon = false;
            }
            else
            {
                notifyIcon.Icon = clockIcon;
                Notificon = true;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e)
        {
            typeof(NotifyIcon).GetMethod("ShowContextMenu", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(notifyIcon, null);
        }

        private void Browsebut_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = System.IO.Path.GetFileName(openFileDialog.FileName);
            string path = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
            BrowsetextBox.Text = (path + @"\" + filename);
            _musicUrl = (path + @"\" + filename);
            SetDefaultMusicbut.Enabled = true;
            SetDefaultMusiclab.Enabled = true;
            _musiccheck = true;
        }

        private void Musiccheckbox_CheckedChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (Musiccheckbox.Checked)
            {
                Browsebut.Enabled = true;
                BrowsetextBox.Enabled = true;
            }
            else
            {
                Browsebut.Enabled = false;
                BrowsetextBox.Enabled = false; ;
            }
        }

        private void SetDefaultMusicbut_Click(object sender, EventArgs e)
        {
            BrowsetextBox.Text = "Switch the music";
            _musicUrl = @"music.mp3";
            _musiccheck = false;
            SetDefaultMusicbut.Enabled = false;
            SetDefaultMusiclab.Enabled = false;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Startbut_Click(null, null);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restartbut_Click(null, null);
        }

        private void Popupcheckbox_CheckedChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Messagecheckbox.Enabled = !Popupcheckbox.Checked;
        }

        private void Messagecheckbox_CheckedChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            Popupcheckbox.Enabled = !Messagecheckbox.Checked;
        }

        public void Open()
        {
            Visible = true;
            ShowInTaskbar = true;
            Minimized = false;
            WindowState = FormWindowState.Normal;
            notifyIcon.Icon = clockIcon;
            notifyIcon.Visible = false;
            icon = 0;
            Notificon = true;
            RepeatTrayMessage = 1;
            RepeatTray = false;
            TimerTray.Stop();
            ProTimerTray.Stop();
        }

        public void TimerStart()
        {
            Timer.Stop();
            Time.Text = ("00:00");
            Startbut.Enabled = false;
            startToolStripMenuItem.Enabled = false;
            Changebut.Enabled = true;
            _start = false;
            Startbut.Text = "Start";
            startToolStripMenuItem.Text = "Start";
            Restartbut.Enabled = true;
            restartToolStripMenuItem.Enabled = true;
        }

        public void TimerWork()
        {
            _minutes = _restmin;
            _seconds = _restsec;

            _min1 = _minutes / 10;
            _min2 = _minutes % 10;
            _sec1 = _seconds / 10;
            _sec2 = _seconds % 10;
            Time.Text = (_min1 + "" + _min2 + ":" + _sec1 + "" + _sec2);
        }

        public void MessageTypes(int num)
        {
            var trayNotify = new TrayNotification(this);

            if (Message)
            {
                if (Music)
                {
                    Wmp.URL = _musicUrl;
                    Wmp.settings.volume = Volume;
                    Wmp.controls.play();
                }
                switch (num)
                {
                    case 1:
                        if (!Normal)
                            Timer.Stop();
                        RadMessageBox.Show(new Form { TopMost = true, StartPosition = FormStartPosition.CenterScreen }, "Time is over");
                        if (result == DialogResult.OK || result == DialogResult.None)
                        {
                            TopMost = false;
                            Wmp.close();
                        }
                        if (!Normal)
                            Timer.Start();
                        break;
                    case 2:
                        RadMessageBox.Show(new Form { TopMost = true, StartPosition = FormStartPosition.CenterScreen }, "Time is over. Repeat " + Repeattimes.ToString() + " time(s)");
                        if (result == DialogResult.OK || result == DialogResult.None)
                        {
                            TopMost = false;
                            Wmp.close();
                        }
                        Timer.Start();
                        break;
                }
            }

            if (Popup)
            {
                if (Music)
                {
                    Wmp.URL = _musicUrl;
                    Wmp.settings.volume = Volume;
                    Wmp.controls.play();
                }
                if (!Normal)
                    Timer.Stop();
                trayNotify.Show();
                switch (num)
                {
                    case 1:
                        trayNotify.TrayNotifylab.Location = new Point(60, 9);
                        trayNotify.TrayNotifylab.Text = "Time is over";
                        break;
                    case 2:
                        trayNotify.TrayNotifylab.Font = new Font(trayNotify.TrayNotifylab.Font.FontFamily.Name, 12);
                        trayNotify.TrayNotifylab.Location = new Point(15, 9);
                        trayNotify.TrayNotifylab.Text = ("Time is over. Repeat " + Repeattimes.ToString() + " time(s)");
                        break;
                }
            }

            if (Message == false && Popup == false)
            {
                if (Music)
                {
                    Wmp.URL = _musicUrl;
                    Wmp.settings.volume = Volume;
                    Wmp.controls.play();
                    switch (num)
                    {
                        case 1:
                            if (!Normal)
                                Timer.Stop();
                            RadMessageBox.Show(new Form { TopMost = true, StartPosition = FormStartPosition.CenterScreen }, "Turn off the music");
                            if (result == DialogResult.OK || result == DialogResult.None)
                            {
                                TopMost = false;
                                Wmp.close();
                            }
                            if (!Normal)
                                Timer.Start();
                            break;
                        case 2:
                            RadMessageBox.Show(new Form { TopMost = true, StartPosition = FormStartPosition.CenterScreen }, "Time is over. Repeat " + Repeattimes.ToString() + " time(s)");
                            if (result == DialogResult.OK || result == DialogResult.None)
                            {
                                TopMost = false;
                                Wmp.close();
                            }
                            Timer.Start();
                            break;
                    }
                }
                else if (Minimized && !Normal)
                    notifyIcon.ShowBalloonTip(500, "Message", "Time is over", ToolTipIcon.None);
                Timer.Start();
            }
        }

        private void Probut_Click(object sender, EventArgs e)
        {
            if (Normal)
            {
                Width += ProLength;
                Probut.Text = "<< Hide";
                Probut.Location = new Point(Probut.Location.X + ProLength, Probut.Location.Y);
                Repeattimeslab.Location = new Point(Repeattimeslab.Location.X + ProLength, Repeattimeslab.Location.Y);
                Panel.Location = new Point(((ProLength + _startWakeAppWidth) / 2) - (Panel.Width / 2), Panel.Location.Y);
                ProbutChanger(false);
            }
            else
            {
                Width -= ProLength;
                Probut.Text = "Pro >>";
                Probut.Location = new Point(Probut.Location.X - ProLength, Probut.Location.Y);
                Repeattimeslab.Location = new Point(Repeattimeslab.Location.X - ProLength, Repeattimeslab.Location.Y);
                Panel.Location = new Point(_startPanelLocationX, Panel.Location.Y);
                ProbutChanger(true);
            }
            CenterToScreen();
        }

        private void ProbutChanger(bool flag)
        {
            Addbut.Enabled = Addbut.Visible = Removebut.Enabled = Removebut.Visible = ProChangebut.Enabled =
                ProChangebut.Visible = AddAfterbut.Enabled = AddAfterbut.Visible = _dataGridView.Enabled = _dataGridView.Visible = !flag;
            Normal = flag;
        }

        private void Addbut_Click(object sender, EventArgs e)
        {
            bool message = false, popup = false, music = false;
            DataGridIdentify(ref message, ref popup, ref music);
            if (int.Parse(MinutesNumericUpDown.Text) > 0 || int.Parse(SecondsNumericUpDown.Text) > 0)
            {
                _dataGridView.Rows.Add(MinutesNumericUpDown.Text + ":" + SecondsNumericUpDown.Text, message, popup, music);
                DataTimes++;
            }
        }

        private void Removebut_Click(object sender, EventArgs e)
        {
            if (DataTimes != -1)
            {
                _dataGridView.Rows.RemoveAt(_dataGridView.CurrentCell.RowIndex);
                DataTimes--;
            }
        }

        private void OkButMethod()
        {
            Startbut.Enabled = true;
            startToolStripMenuItem.Enabled = true;
            SetTimebut.Enabled = false;
            Changebut.Enabled = true;
            MinutesNumericUpDown.Enabled = false;
            SecondsNumericUpDown.Enabled = false;
            Minuteslab.Enabled = false;
            Secondslab.Enabled = false;
            WriteTheTime.Enabled = false;
            Repeattimescheckbox.Enabled = false;
            RepeattimesNumericUpDown.Enabled = false;
            Browsebut.Enabled = false;
            BrowsetextBox.Enabled = false;
            SetDefaultMusicbut.Enabled = false;
            SetDefaultMusiclab.Enabled = false;
            Probut.Enabled = false;
            Addbut.Enabled = Removebut.Enabled = _dataGridView.Enabled = false;

            if (Repeatcheckbox.Checked)
            {
                if (Repeattimescheckbox.Checked)
                {
                    Repeattimes = int.Parse(RepeattimesNumericUpDown.Text);
                    Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
                }
                else
                {
                    Repeattimes = 0;
                    Repeattimeslab.Text = "Repeat times: 0";
                }
            }
            else
            {
                Repeattimes = 0;
                Repeattimeslab.Text = "Repeat times: 0";
            }

            _rep1 = Repeattimes;

            Message = Messagecheckbox.Checked;
            Messagecheckbox.Enabled = false;

            if (Repeatcheckbox.Checked)
            {
                Repeat = true;
                Repeattimeslab.Enabled = true;
            }
            else
                Repeat = false;
            Repeatcheckbox.Enabled = false;

            Music = Musiccheckbox.Checked;
            Musiccheckbox.Enabled = false;

            Popup = Popupcheckbox.Checked;
            Popupcheckbox.Enabled = false;

            if (Messagecheckbox.Checked || Musiccheckbox.Checked || Popupcheckbox.Checked)
            {
                _checking = true;
            }
        }

        private void ProTimeShare()
        {
            string minutes, seconds;
            int cut;
            string value = _dataGridView.Rows[Index].Cells[0].Value.ToString();
            cut = value.IndexOf(':');
            minutes = value.Substring(0, cut);
            seconds = value.Replace(minutes + ':', String.Empty);
            _minutes = Convert.ToInt32(minutes);
            _seconds = Convert.ToInt32(seconds);
            _restmin = _minutes;
            _restsec = _seconds;
        }

        private void DataGridViewMessageNotification()
        {
            for (int col = 0; col < _dataGridView.Rows[Index].Cells.Count; col++)
            {
                string value = _dataGridView.Rows[Index].Cells[col].Value.ToString();
                switch (col)
                {
                    case 0:
                        ProTimeShare();
                        break;
                    case 1:
                        if (value == "True")
                            Message = true;
                        else
                            Message = false;
                        break;
                    case 2:
                        if (value == "True")
                            Popup = true;
                        else
                            Popup = false;
                        break;
                    case 3:
                        if (value == "True")
                            Music = true;
                        else
                            Music = false;
                        break;
                }
            }
        }

        public void ProTimerWithoutRepeat()
        {
            if (Index < _dataGridView.Rows.Count - 1)
            {
                Time.Text = ("00:00");
                DataGridViewMessageNotification();
                MessageTypes(1);
                Index++;
                if (Popup == false)
                {
                    _dataGridView.Rows[Index - 1].Selected = false;
                    _dataGridView.Rows[Index].Selected = true;
                    if (Index == ScrollIndex)
                    {
                        _dataGridView.FirstDisplayedScrollingRowIndex = ScrollIndex;
                        ScrollIndex += 5;
                    }
                }
                ProTimeShare();
                TimerWork();
            }
            else
            {
                if (Repeattimescheckbox.Checked)
                    Repeattimeslab.Text = ("Repeat times: 0");
                TimerStart();
                DataGridViewMessageNotification();
                MessageTypes(1);
            }
        }

        public void ProTimerWithRepeat()
        {
            if (Index < _dataGridView.Rows.Count - 1)
            {
                Time.Text = ("00:00");
                DataGridViewMessageNotification();
                MessageTypes(1);
                Index++;
                if (Popup == false)
                {
                    _dataGridView.Rows[Index - 1].Selected = false;
                    _dataGridView.Rows[Index].Selected = true;
                    if (Index == ScrollIndex)
                    {
                        _dataGridView.FirstDisplayedScrollingRowIndex = ScrollIndex;
                        ScrollIndex += 5;
                    }
                }
                ProTimeShare();
                TimerWork();
            }
            else
            {
                Time.Text = ("00:00");
                DataGridViewMessageNotification();
                MessageTypes(1);
                _dataGridView.Rows[Index].Selected = false;
                Index = 0;
                _dataGridView.FirstDisplayedScrollingRowIndex = Index;
                ScrollIndex = 5;
                _dataGridView.Rows[Index].Selected = true;
                if (Repeattimescheckbox.Checked == false)
                {
                    Repeattimes++;
                    Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
                }
                else
                {
                    Repeattimes--;
                    Repeattimeslab.Text = ("Repeat times: " + Repeattimes);
                }
                ProTimeShare();
                TimerWork();
            }
        }

        private void ProChangebut_Click(object sender, EventArgs e)
        {
            bool message = false, popup = false, music = false;
            DataGridIdentify(ref message, ref popup, ref music);
            if (int.Parse(MinutesNumericUpDown.Text) > 0 || int.Parse(SecondsNumericUpDown.Text) > 0)
            {
                if (DataTimes != -1)
                {
                    int selectedIndex = _dataGridView.CurrentCell.RowIndex;
                    if (selectedIndex >= 0)
                    {
                        _dataGridView.Rows[selectedIndex].Cells[0].Value = (MinutesNumericUpDown.Text + ":" + SecondsNumericUpDown.Text);
                        _dataGridView.Rows[selectedIndex].Cells[1].Value = (message);
                        _dataGridView.Rows[selectedIndex].Cells[2].Value = (popup);
                        _dataGridView.Rows[selectedIndex].Cells[3].Value = (music);
                    }
                }
            }
        }

        private void DataGridIdentify(ref bool message, ref bool popup, ref bool music)
        {
            if (Messagecheckbox.Checked)
                message = true;
            if (Popupcheckbox.Checked)
                popup = true;
            if (Musiccheckbox.Checked)
                music = true;
        }

        private void AddAfterbut_Click(object sender, EventArgs e)
        {
            bool message = false, popup = false, music = false;
            DataGridIdentify(ref message, ref popup, ref music);
            if (int.Parse(MinutesNumericUpDown.Text) > 0 || int.Parse(SecondsNumericUpDown.Text) > 0)
            {
                if (DataTimes == -1)
                {
                    _dataGridView.Rows.Add(MinutesNumericUpDown.Text + ":" + SecondsNumericUpDown.Text, message, popup, music);
                    DataTimes++;
                }
                else
                {
                    int selectedIndex = _dataGridView.CurrentCell.RowIndex;
                    if (selectedIndex >= 0)
                    {
                        _dataGridView.Rows.Insert(++selectedIndex, MinutesNumericUpDown.Text + ":" + SecondsNumericUpDown.Text, message, popup, music);
                        DataTimes++;
                    }
                }
            }
        }

        private void WakeApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                notifyIcon.Visible = true;
                Minimized = true;
                if (_trayMessage == false)
                {
                    notifyIcon.ShowBalloonTip(500, "Message", "WakeUp! has been minimized", ToolTipIcon.None);
                    _trayMessage = true;
                }
                TimerTray.Start();
                icon = 0;
                RepeatTray = false;
                e.Cancel = true;
                Hide();
            }
        }
    }
}