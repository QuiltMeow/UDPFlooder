namespace UDP_Flooder
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAttack = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.labelSizeByte = new System.Windows.Forms.Label();
            this.chkRandomSize = new System.Windows.Forms.CheckBox();
            this.labelThread = new System.Windows.Forms.Label();
            this.numThread = new System.Windows.Forms.NumericUpDown();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.labelPacket = new System.Windows.Forms.Label();
            this.numPacket = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disappearWhenStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToTaskBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableByteCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableMultiCoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelByteCounter = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.timerSizeCount = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacket)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(110, 190);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(140, 45);
            this.btnAttack.TabIndex = 16;
            this.btnAttack.Text = "開始轟炸";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(20, 40);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(42, 12);
            this.labelIP.TabIndex = 1;
            this.labelIP.Text = "IP 位址";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(70, 37);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(135, 22);
            this.txtIP.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(255, 37);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(65, 22);
            this.txtPort.TabIndex = 4;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(215, 40);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(29, 12);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "端口";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(20, 85);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(29, 12);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "大小";
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(75, 80);
            this.trackBarSize.Maximum = 65000;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(245, 45);
            this.trackBarSize.TabIndex = 7;
            this.trackBarSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSize.Value = 1;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // labelSizeByte
            // 
            this.labelSizeByte.AutoSize = true;
            this.labelSizeByte.Location = new System.Drawing.Point(20, 105);
            this.labelSizeByte.Name = "labelSizeByte";
            this.labelSizeByte.Size = new System.Drawing.Size(49, 12);
            this.labelSizeByte.TabIndex = 6;
            this.labelSizeByte.Text = "(位元組)";
            // 
            // chkRandomSize
            // 
            this.chkRandomSize.AutoSize = true;
            this.chkRandomSize.Location = new System.Drawing.Point(330, 105);
            this.chkRandomSize.Name = "chkRandomSize";
            this.chkRandomSize.Size = new System.Drawing.Size(72, 16);
            this.chkRandomSize.TabIndex = 9;
            this.chkRandomSize.Text = "隨機大小";
            this.chkRandomSize.UseVisualStyleBackColor = true;
            this.chkRandomSize.CheckedChanged += new System.EventHandler(this.chkRandomSize_CheckedChanged);
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Location = new System.Drawing.Point(20, 145);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(41, 12);
            this.labelThread.TabIndex = 10;
            this.labelThread.Text = "執行緒";
            // 
            // numThread
            // 
            this.numThread.BackColor = System.Drawing.Color.White;
            this.numThread.Location = new System.Drawing.Point(70, 143);
            this.numThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numThread.Name = "numThread";
            this.numThread.ReadOnly = true;
            this.numThread.Size = new System.Drawing.Size(50, 22);
            this.numThread.TabIndex = 11;
            this.numThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(130, 145);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(64, 12);
            this.labelDelay.TabIndex = 12;
            this.labelDelay.Text = "延遲 (毫秒)";
            // 
            // numDelay
            // 
            this.numDelay.BackColor = System.Drawing.Color.White;
            this.numDelay.Location = new System.Drawing.Point(205, 143);
            this.numDelay.Name = "numDelay";
            this.numDelay.ReadOnly = true;
            this.numDelay.Size = new System.Drawing.Size(50, 22);
            this.numDelay.TabIndex = 13;
            this.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPacket
            // 
            this.labelPacket.AutoSize = true;
            this.labelPacket.Location = new System.Drawing.Point(265, 145);
            this.labelPacket.Name = "labelPacket";
            this.labelPacket.Size = new System.Drawing.Size(41, 12);
            this.labelPacket.TabIndex = 14;
            this.labelPacket.Text = "發包數";
            // 
            // numPacket
            // 
            this.numPacket.BackColor = System.Drawing.Color.White;
            this.numPacket.Location = new System.Drawing.Point(315, 143);
            this.numPacket.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPacket.Name = "numPacket";
            this.numPacket.ReadOnly = true;
            this.numPacket.Size = new System.Drawing.Size(50, 22);
            this.numPacket.TabIndex = 15;
            this.numPacket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPacket.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(439, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "選單";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disappearWhenStartToolStripMenuItem,
            this.minToTaskBarToolStripMenuItem,
            this.enableByteCounterToolStripMenuItem,
            this.enableMultiCoreToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.settingToolStripMenuItem.Text = "設定";
            // 
            // disappearWhenStartToolStripMenuItem
            // 
            this.disappearWhenStartToolStripMenuItem.CheckOnClick = true;
            this.disappearWhenStartToolStripMenuItem.Name = "disappearWhenStartToolStripMenuItem";
            this.disappearWhenStartToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.disappearWhenStartToolStripMenuItem.Text = "開始攻擊後完全隱藏";
            // 
            // minToTaskBarToolStripMenuItem
            // 
            this.minToTaskBarToolStripMenuItem.CheckOnClick = true;
            this.minToTaskBarToolStripMenuItem.Name = "minToTaskBarToolStripMenuItem";
            this.minToTaskBarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.minToTaskBarToolStripMenuItem.Text = "最小化後隱藏";
            // 
            // enableByteCounterToolStripMenuItem
            // 
            this.enableByteCounterToolStripMenuItem.CheckOnClick = true;
            this.enableByteCounterToolStripMenuItem.Name = "enableByteCounterToolStripMenuItem";
            this.enableByteCounterToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.enableByteCounterToolStripMenuItem.Text = "啟用發送位元計數器";
            this.enableByteCounterToolStripMenuItem.Click += new System.EventHandler(this.enableByteCounterToolStripMenuItem_Click);
            // 
            // enableMultiCoreToolStripMenuItem
            // 
            this.enableMultiCoreToolStripMenuItem.CheckOnClick = true;
            this.enableMultiCoreToolStripMenuItem.Name = "enableMultiCoreToolStripMenuItem";
            this.enableMultiCoreToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.enableMultiCoreToolStripMenuItem.Text = "啟用多核心進行攻擊";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // labelByteCounter
            // 
            this.labelByteCounter.Location = new System.Drawing.Point(260, 190);
            this.labelByteCounter.Name = "labelByteCounter";
            this.labelByteCounter.Size = new System.Drawing.Size(160, 12);
            this.labelByteCounter.TabIndex = 17;
            this.labelByteCounter.Text = "已傳送位元組 : 0";
            this.labelByteCounter.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "重置計數";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClearCount_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(330, 75);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(70, 22);
            this.txtSize.TabIndex = 8;
            this.txtSize.Text = "1";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // timerSizeCount
            // 
            this.timerSizeCount.Enabled = true;
            this.timerSizeCount.Interval = 1000;
            this.timerSizeCount.Tick += new System.EventHandler(this.timerSizeCount_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelByteCounter);
            this.Controls.Add(this.numPacket);
            this.Controls.Add(this.labelPacket);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.numThread);
            this.Controls.Add(this.labelThread);
            this.Controls.Add(this.chkRandomSize);
            this.Controls.Add(this.labelSizeByte);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "UDP Flooder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPacket)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelSizeByte;
        private System.Windows.Forms.CheckBox chkRandomSize;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.NumericUpDown numThread;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label labelPacket;
        private System.Windows.Forms.NumericUpDown numPacket;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disappearWhenStartToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem minToTaskBarToolStripMenuItem;
        private System.Windows.Forms.Label labelByteCounter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem enableByteCounterToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.ToolStripMenuItem enableMultiCoreToolStripMenuItem;
        private System.Windows.Forms.Timer timerSizeCount;
    }
}