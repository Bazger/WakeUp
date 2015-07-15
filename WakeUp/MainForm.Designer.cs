namespace WakeUp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.WriteTheTime = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Minuteslab = new System.Windows.Forms.Label();
            this.Secondslab = new System.Windows.Forms.Label();
            this.Repeattimeslab = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimerTray = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SetDefaultMusiclab = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.Restartbut = new Telerik.WinControls.UI.RadButton();
            this.Changebut = new Telerik.WinControls.UI.RadButton();
            this.Startbut = new Telerik.WinControls.UI.RadButton();
            this.ProTimerTray = new System.Windows.Forms.Timer(this.components);
            this.visualStudio2012LightTheme = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.Exitbut = new Telerik.WinControls.UI.RadButton();
            this.SetTimebut = new Telerik.WinControls.UI.RadButton();
            this.Browsebut = new Telerik.WinControls.UI.RadButton();
            this.Probut = new Telerik.WinControls.UI.RadButton();
            this.SetDefaultMusicbut = new Telerik.WinControls.UI.RadButton();
            this.Addbut = new Telerik.WinControls.UI.RadButton();
            this.AddAfterbut = new Telerik.WinControls.UI.RadButton();
            this.ProChangebut = new Telerik.WinControls.UI.RadButton();
            this.Removebut = new Telerik.WinControls.UI.RadButton();
            this.Messagecheckbox = new Telerik.WinControls.UI.RadCheckBox();
            this.Popupcheckbox = new Telerik.WinControls.UI.RadCheckBox();
            this.Musiccheckbox = new Telerik.WinControls.UI.RadCheckBox();
            this.Repeatcheckbox = new Telerik.WinControls.UI.RadCheckBox();
            this.MinutesNumericUpDown = new Telerik.WinControls.UI.RadSpinEditor();
            this.Repeattimescheckbox = new Telerik.WinControls.UI.RadCheckBox();
            this.SecondsNumericUpDown = new Telerik.WinControls.UI.RadSpinEditor();
            this.RepeattimesNumericUpDown = new Telerik.WinControls.UI.RadSpinEditor();
            this.BrowsetextBox = new Telerik.WinControls.UI.RadTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restartbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Changebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Startbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetTimebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browsebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Probut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetDefaultMusicbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAfterbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProChangebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Removebut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Messagecheckbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Popupcheckbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Musiccheckbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeatcheckbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeattimescheckbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeattimesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowsetextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // WriteTheTime
            // 
            this.WriteTheTime.AutoSize = true;
            this.WriteTheTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteTheTime.Location = new System.Drawing.Point(13, 9);
            this.WriteTheTime.Name = "WriteTheTime";
            this.WriteTheTime.Size = new System.Drawing.Size(157, 18);
            this.WriteTheTime.TabIndex = 1;
            this.WriteTheTime.Text = "Write the timer options";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time.Location = new System.Drawing.Point(96, 86);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(119, 46);
            this.Time.TabIndex = 4;
            this.Time.Text = "00:00";
            // 
            // Minuteslab
            // 
            this.Minuteslab.AutoSize = true;
            this.Minuteslab.Location = new System.Drawing.Point(265, 49);
            this.Minuteslab.Name = "Minuteslab";
            this.Minuteslab.Size = new System.Drawing.Size(48, 13);
            this.Minuteslab.TabIndex = 5;
            this.Minuteslab.Text = "minutes";
            // 
            // Secondslab
            // 
            this.Secondslab.AutoSize = true;
            this.Secondslab.Location = new System.Drawing.Point(266, 78);
            this.Secondslab.Name = "Secondslab";
            this.Secondslab.Size = new System.Drawing.Size(49, 13);
            this.Secondslab.TabIndex = 7;
            this.Secondslab.Text = "seconds";
            // 
            // Repeattimeslab
            // 
            this.Repeattimeslab.AutoSize = true;
            this.Repeattimeslab.Enabled = false;
            this.Repeattimeslab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Repeattimeslab.Location = new System.Drawing.Point(202, 368);
            this.Repeattimeslab.Name = "Repeattimeslab";
            this.Repeattimeslab.Size = new System.Drawing.Size(101, 16);
            this.Repeattimeslab.TabIndex = 14;
            this.Repeattimeslab.Text = "Repeat times: 0";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(111, 98);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Enabled = false;
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Enabled = false;
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // TimerTray
            // 
            this.TimerTray.Interval = 1000;
            this.TimerTray.Tick += new System.EventHandler(this.TimerTray_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "C:\\";
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Browse music files";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // SetDefaultMusiclab
            // 
            this.SetDefaultMusiclab.AutoSize = true;
            this.SetDefaultMusiclab.Location = new System.Drawing.Point(166, 120);
            this.SetDefaultMusiclab.Name = "SetDefaultMusiclab";
            this.SetDefaultMusiclab.Size = new System.Drawing.Size(156, 13);
            this.SetDefaultMusiclab.TabIndex = 20;
            this.SetDefaultMusiclab.Text = "Change to the default music:";
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Restartbut);
            this.Panel.Controls.Add(this.Changebut);
            this.Panel.Controls.Add(this.Startbut);
            this.Panel.Controls.Add(this.Time);
            this.Panel.Location = new System.Drawing.Point(9, 204);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(310, 135);
            this.Panel.TabIndex = 29;
            // 
            // Restartbut
            // 
            this.Restartbut.Enabled = false;
            this.Restartbut.Location = new System.Drawing.Point(217, 3);
            this.Restartbut.Name = "Restartbut";
            this.Restartbut.Size = new System.Drawing.Size(87, 52);
            this.Restartbut.TabIndex = 34;
            this.Restartbut.Text = "Restart";
            this.Restartbut.ThemeName = "VisualStudio2012Light";
            this.Restartbut.Click += new System.EventHandler(this.Restartbut_Click);
            // 
            // Changebut
            // 
            this.Changebut.Enabled = false;
            this.Changebut.Location = new System.Drawing.Point(7, 3);
            this.Changebut.Name = "Changebut";
            this.Changebut.Size = new System.Drawing.Size(84, 52);
            this.Changebut.TabIndex = 34;
            this.Changebut.Text = "Change";
            this.Changebut.ThemeName = "VisualStudio2012Light";
            this.Changebut.Click += new System.EventHandler(this.Changebut_Click);
            // 
            // Startbut
            // 
            this.Startbut.Enabled = false;
            this.Startbut.Location = new System.Drawing.Point(96, 3);
            this.Startbut.Name = "Startbut";
            this.Startbut.Size = new System.Drawing.Size(115, 52);
            this.Startbut.TabIndex = 32;
            this.Startbut.Text = "Start";
            this.Startbut.ThemeName = "VisualStudio2012Light";
            this.Startbut.Click += new System.EventHandler(this.Startbut_Click);
            // 
            // ProTimerTray
            // 
            this.ProTimerTray.Interval = 1000;
            this.ProTimerTray.Tick += new System.EventHandler(this.ProTimerTray_Tick);
            // 
            // Exitbut
            // 
            this.Exitbut.Location = new System.Drawing.Point(16, 368);
            this.Exitbut.Name = "Exitbut";
            this.Exitbut.Size = new System.Drawing.Size(49, 22);
            this.Exitbut.TabIndex = 32;
            this.Exitbut.Text = "Exit";
            this.Exitbut.ThemeName = "VisualStudio2012Light";
            this.Exitbut.Click += new System.EventHandler(this.Exitbut_Click);
            // 
            // SetTimebut
            // 
            this.SetTimebut.Location = new System.Drawing.Point(16, 162);
            this.SetTimebut.Name = "SetTimebut";
            this.SetTimebut.Size = new System.Drawing.Size(83, 38);
            this.SetTimebut.TabIndex = 33;
            this.SetTimebut.Text = "OK";
            this.SetTimebut.ThemeName = "VisualStudio2012Light";
            this.SetTimebut.Click += new System.EventHandler(this.SetTimebut_Click);
            // 
            // Browsebut
            // 
            this.Browsebut.Enabled = false;
            this.Browsebut.Location = new System.Drawing.Point(105, 176);
            this.Browsebut.Name = "Browsebut";
            this.Browsebut.Size = new System.Drawing.Size(58, 24);
            this.Browsebut.TabIndex = 34;
            this.Browsebut.Text = "Browse";
            this.Browsebut.ThemeName = "VisualStudio2012Light";
            this.Browsebut.Click += new System.EventHandler(this.Browsebut_Click);
            // 
            // Probut
            // 
            this.Probut.Location = new System.Drawing.Point(259, 8);
            this.Probut.Name = "Probut";
            this.Probut.Size = new System.Drawing.Size(60, 23);
            this.Probut.TabIndex = 25;
            this.Probut.Text = "Pro >>";
            this.Probut.ThemeName = "VisualStudio2012Light";
            this.Probut.Click += new System.EventHandler(this.Probut_Click);
            // 
            // SetDefaultMusicbut
            // 
            this.SetDefaultMusicbut.Location = new System.Drawing.Point(206, 139);
            this.SetDefaultMusicbut.Name = "SetDefaultMusicbut";
            this.SetDefaultMusicbut.Size = new System.Drawing.Size(59, 24);
            this.SetDefaultMusicbut.TabIndex = 19;
            this.SetDefaultMusicbut.Text = "Change";
            this.SetDefaultMusicbut.ThemeName = "VisualStudio2012Light";
            this.SetDefaultMusicbut.Click += new System.EventHandler(this.SetDefaultMusicbut_Click);
            // 
            // Addbut
            // 
            this.Addbut.Enabled = false;
            this.Addbut.Location = new System.Drawing.Point(331, 42);
            this.Addbut.Name = "Addbut";
            this.Addbut.Size = new System.Drawing.Size(73, 23);
            this.Addbut.TabIndex = 27;
            this.Addbut.Text = "Add";
            this.Addbut.ThemeName = "VisualStudio2012Light";
            this.Addbut.Visible = false;
            this.Addbut.Click += new System.EventHandler(this.Addbut_Click);
            // 
            // AddAfterbut
            // 
            this.AddAfterbut.Enabled = false;
            this.AddAfterbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAfterbut.Location = new System.Drawing.Point(331, 71);
            this.AddAfterbut.Name = "AddAfterbut";
            this.AddAfterbut.Size = new System.Drawing.Size(73, 23);
            this.AddAfterbut.TabIndex = 31;
            this.AddAfterbut.Text = "Add after";
            this.AddAfterbut.ThemeName = "VisualStudio2012Light";
            this.AddAfterbut.Visible = false;
            this.AddAfterbut.Click += new System.EventHandler(this.AddAfterbut_Click);
            // 
            // ProChangebut
            // 
            this.ProChangebut.Enabled = false;
            this.ProChangebut.Location = new System.Drawing.Point(331, 100);
            this.ProChangebut.Name = "ProChangebut";
            this.ProChangebut.Size = new System.Drawing.Size(73, 23);
            this.ProChangebut.TabIndex = 30;
            this.ProChangebut.Text = "Change";
            this.ProChangebut.ThemeName = "VisualStudio2012Light";
            this.ProChangebut.Visible = false;
            this.ProChangebut.Click += new System.EventHandler(this.ProChangebut_Click);
            // 
            // Removebut
            // 
            this.Removebut.Enabled = false;
            this.Removebut.Location = new System.Drawing.Point(331, 129);
            this.Removebut.Name = "Removebut";
            this.Removebut.Size = new System.Drawing.Size(73, 23);
            this.Removebut.TabIndex = 28;
            this.Removebut.Text = "Remove";
            this.Removebut.ThemeName = "VisualStudio2012Light";
            this.Removebut.Visible = false;
            this.Removebut.Click += new System.EventHandler(this.Removebut_Click);
            // 
            // Messagecheckbox
            // 
            this.Messagecheckbox.Location = new System.Drawing.Point(16, 42);
            this.Messagecheckbox.Name = "Messagecheckbox";
            this.Messagecheckbox.Size = new System.Drawing.Size(127, 18);
            this.Messagecheckbox.TabIndex = 12;
            this.Messagecheckbox.Text = "Message notification";
            this.Messagecheckbox.ThemeName = "VisualStudio2012Light";
            this.Messagecheckbox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Messagecheckbox_CheckedChanged);
            // 
            // Popupcheckbox
            // 
            this.Popupcheckbox.Location = new System.Drawing.Point(16, 68);
            this.Popupcheckbox.Name = "Popupcheckbox";
            this.Popupcheckbox.Size = new System.Drawing.Size(165, 18);
            this.Popupcheckbox.TabIndex = 21;
            this.Popupcheckbox.Text = "Popup Message Notification";
            this.Popupcheckbox.ThemeName = "VisualStudio2012Light";
            this.Popupcheckbox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Popupcheckbox_CheckedChanged);
            // 
            // Musiccheckbox
            // 
            this.Musiccheckbox.Location = new System.Drawing.Point(16, 91);
            this.Musiccheckbox.Name = "Musiccheckbox";
            this.Musiccheckbox.Size = new System.Drawing.Size(112, 18);
            this.Musiccheckbox.TabIndex = 13;
            this.Musiccheckbox.Text = "Music notification";
            this.Musiccheckbox.ThemeName = "VisualStudio2012Light";
            this.Musiccheckbox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Musiccheckbox_CheckedChanged);
            // 
            // Repeatcheckbox
            // 
            this.Repeatcheckbox.Location = new System.Drawing.Point(16, 116);
            this.Repeatcheckbox.Name = "Repeatcheckbox";
            this.Repeatcheckbox.Size = new System.Drawing.Size(58, 18);
            this.Repeatcheckbox.TabIndex = 0;
            this.Repeatcheckbox.Text = "Repeat";
            this.Repeatcheckbox.ThemeName = "VisualStudio2012Light";
            this.Repeatcheckbox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Repeatcheckbox_CheckedChanged);
            // 
            // MinutesNumericUpDown
            // 
            this.MinutesNumericUpDown.Location = new System.Drawing.Point(205, 42);
            this.MinutesNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.MinutesNumericUpDown.Name = "MinutesNumericUpDown";
            this.MinutesNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.MinutesNumericUpDown.TabIndex = 23;
            this.MinutesNumericUpDown.TabStop = false;
            this.MinutesNumericUpDown.ThemeName = "VisualStudio2012Light";
            // 
            // Repeattimescheckbox
            // 
            this.Repeattimescheckbox.Enabled = false;
            this.Repeattimescheckbox.Location = new System.Drawing.Point(16, 139);
            this.Repeattimescheckbox.Name = "Repeattimescheckbox";
            this.Repeattimescheckbox.Size = new System.Drawing.Size(91, 18);
            this.Repeattimescheckbox.TabIndex = 15;
            this.Repeattimescheckbox.Text = "Repeat times:";
            this.Repeattimescheckbox.ThemeName = "VisualStudio2012Light";
            this.Repeattimescheckbox.ToggleStateChanging += new Telerik.WinControls.UI.StateChangingEventHandler(this.Repeattimescheckbox_ToggleStateChanging);
            this.Repeattimescheckbox.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.Repeattimescheckbox_CheckedChanged);
            // 
            // SecondsNumericUpDown
            // 
            this.SecondsNumericUpDown.Location = new System.Drawing.Point(205, 71);
            this.SecondsNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsNumericUpDown.Name = "SecondsNumericUpDown";
            this.SecondsNumericUpDown.Size = new System.Drawing.Size(55, 20);
            this.SecondsNumericUpDown.TabIndex = 22;
            this.SecondsNumericUpDown.TabStop = false;
            this.SecondsNumericUpDown.ThemeName = "VisualStudio2012Light";
            // 
            // RepeattimesNumericUpDown
            // 
            this.RepeattimesNumericUpDown.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RepeattimesNumericUpDown.Enabled = false;
            this.RepeattimesNumericUpDown.Location = new System.Drawing.Point(108, 136);
            this.RepeattimesNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.RepeattimesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RepeattimesNumericUpDown.Name = "RepeattimesNumericUpDown";
            // 
            // 
            // 
            this.RepeattimesNumericUpDown.RootElement.ControlBounds = new System.Drawing.Rectangle(108, 136, 100, 20);
            this.RepeattimesNumericUpDown.RootElement.StretchVertically = true;
            this.RepeattimesNumericUpDown.Size = new System.Drawing.Size(55, 21);
            this.RepeattimesNumericUpDown.TabIndex = 35;
            this.RepeattimesNumericUpDown.TabStop = false;
            this.RepeattimesNumericUpDown.ThemeName = "VisualStudio2012Light";
            this.RepeattimesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BrowsetextBox
            // 
            this.BrowsetextBox.Location = new System.Drawing.Point(169, 180);
            this.BrowsetextBox.Name = "BrowsetextBox";
            this.BrowsetextBox.Size = new System.Drawing.Size(144, 20);
            this.BrowsetextBox.TabIndex = 18;
            this.BrowsetextBox.TabStop = false;
            this.BrowsetextBox.Text = "Switch the music";
            this.BrowsetextBox.ThemeName = "VisualStudio2012Light";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(410, 42);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(444, 158);
            this.dataGridView.TabIndex = 36;
            this.dataGridView.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Time";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Message notification";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Popup notification";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Music";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 402);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BrowsetextBox);
            this.Controls.Add(this.RepeattimesNumericUpDown);
            this.Controls.Add(this.SecondsNumericUpDown);
            this.Controls.Add(this.MinutesNumericUpDown);
            this.Controls.Add(this.Repeattimescheckbox);
            this.Controls.Add(this.Repeatcheckbox);
            this.Controls.Add(this.Musiccheckbox);
            this.Controls.Add(this.Popupcheckbox);
            this.Controls.Add(this.Messagecheckbox);
            this.Controls.Add(this.Removebut);
            this.Controls.Add(this.ProChangebut);
            this.Controls.Add(this.AddAfterbut);
            this.Controls.Add(this.Addbut);
            this.Controls.Add(this.Probut);
            this.Controls.Add(this.SetDefaultMusicbut);
            this.Controls.Add(this.Browsebut);
            this.Controls.Add(this.SetTimebut);
            this.Controls.Add(this.Exitbut);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.Secondslab);
            this.Controls.Add(this.SetDefaultMusiclab);
            this.Controls.Add(this.Repeattimeslab);
            this.Controls.Add(this.Minuteslab);
            this.Controls.Add(this.WriteTheTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WakeUp";
            this.ThemeName = "VisualStudio2012Light";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WakeApp_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restartbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Changebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Startbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exitbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetTimebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Browsebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Probut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetDefaultMusicbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAfterbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProChangebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Removebut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Messagecheckbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Popupcheckbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Musiccheckbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeatcheckbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeattimescheckbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeattimesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrowsetextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WriteTheTime;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Minuteslab;
        private System.Windows.Forms.Label Secondslab;
        private System.Windows.Forms.Label Repeattimeslab;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label SetDefaultMusiclab;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        public System.Windows.Forms.Timer Timer;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.Timer TimerTray;
        public int icon;
        private System.Windows.Forms.Panel Panel;
        public System.Windows.Forms.Timer ProTimerTray;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme;
        private Telerik.WinControls.UI.RadButton Startbut;
        private Telerik.WinControls.UI.RadButton Exitbut;
        private Telerik.WinControls.UI.RadButton SetTimebut;
        private Telerik.WinControls.UI.RadButton Restartbut;
        private Telerik.WinControls.UI.RadButton Changebut;
        private Telerik.WinControls.UI.RadButton Browsebut;
        private Telerik.WinControls.UI.RadButton Probut;
        private Telerik.WinControls.UI.RadButton SetDefaultMusicbut;
        private Telerik.WinControls.UI.RadButton Addbut;
        private Telerik.WinControls.UI.RadButton AddAfterbut;
        private Telerik.WinControls.UI.RadButton ProChangebut;
        private Telerik.WinControls.UI.RadButton Removebut;
        private Telerik.WinControls.UI.RadCheckBox Messagecheckbox;
        private Telerik.WinControls.UI.RadCheckBox Popupcheckbox;
        private Telerik.WinControls.UI.RadCheckBox Musiccheckbox;
        private Telerik.WinControls.UI.RadCheckBox Repeatcheckbox;
        private Telerik.WinControls.UI.RadSpinEditor MinutesNumericUpDown;
        public Telerik.WinControls.UI.RadCheckBox Repeattimescheckbox;
        private Telerik.WinControls.UI.RadSpinEditor SecondsNumericUpDown;
        private Telerik.WinControls.UI.RadSpinEditor RepeattimesNumericUpDown;
        private Telerik.WinControls.UI.RadTextBox BrowsetextBox;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
    }
}

