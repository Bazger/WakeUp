namespace WakeUp
{
    partial class TrayNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrayNotification));
            this.timerOpen = new System.Windows.Forms.Timer(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.TrayNotifylab = new System.Windows.Forms.Label();
            this.visualStudio2012LightTheme = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.OKbut = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.OKbut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // timerOpen
            // 
            this.timerOpen.Interval = 1;
            this.timerOpen.Tick += new System.EventHandler(this.timerOpen_Tick);
            // 
            // timerClose
            // 
            this.timerClose.Interval = 1;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // TrayNotifylab
            // 
            this.TrayNotifylab.AutoSize = true;
            this.TrayNotifylab.Location = new System.Drawing.Point(60, 9);
            this.TrayNotifylab.Name = "TrayNotifylab";
            this.TrayNotifylab.Size = new System.Drawing.Size(38, 13);
            this.TrayNotifylab.TabIndex = 0;
            this.TrayNotifylab.Text = "label1";
            // 
            // OKbut
            // 
            this.OKbut.Location = new System.Drawing.Point(105, 51);
            this.OKbut.Name = "OKbut";
            this.OKbut.Size = new System.Drawing.Size(47, 23);
            this.OKbut.TabIndex = 1;
            this.OKbut.Text = "OK";
            this.OKbut.ThemeName = "VisualStudio2012Light";
            this.OKbut.Click += new System.EventHandler(this.OKbut_Click);
            // 
            // TrayNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 86);
            this.Controls.Add(this.OKbut);
            this.Controls.Add(this.TrayNotifylab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrayNotification";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Message";
            this.ThemeName = "VisualStudio2012Light";
            this.Load += new System.EventHandler(this.TrayNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OKbut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerOpen;
        public System.Windows.Forms.Timer timerClose;
        public System.Windows.Forms.Label TrayNotifylab;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme;
        private Telerik.WinControls.UI.RadButton OKbut;
    }
}