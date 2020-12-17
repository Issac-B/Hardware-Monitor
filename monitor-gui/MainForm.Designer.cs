namespace ohm_arduino_gui
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
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.comPortCombo = new System.Windows.Forms.ComboBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.switchTimer = new System.Windows.Forms.Label();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.line2GPUClock = new System.Windows.Forms.CheckBox();
            this.line1GPUClock = new System.Windows.Forms.CheckBox();
            this.line2CPUClock = new System.Windows.Forms.CheckBox();
            this.line1CPUClock = new System.Windows.Forms.CheckBox();
            this.comboBoxSwitchTimer = new System.Windows.Forms.ComboBox();
            this.line2GPU = new System.Windows.Forms.CheckBox();
            this.line2CPU = new System.Windows.Forms.CheckBox();
            this.line1GPU = new System.Windows.Forms.CheckBox();
            this.line1CPU = new System.Windows.Forms.CheckBox();
            this.line1RAM = new System.Windows.Forms.CheckBox();
            this.line2RAM = new System.Windows.Forms.CheckBox();
            this.notifyIconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 2000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // comPortCombo
            // 
            this.comPortCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortCombo.FormattingEnabled = true;
            this.comPortCombo.Location = new System.Drawing.Point(12, 17);
            this.comPortCombo.Name = "comPortCombo";
            this.comPortCombo.Size = new System.Drawing.Size(369, 21);
            this.comPortCombo.TabIndex = 1;
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(12, 48);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(369, 230);
            this.logBox.TabIndex = 2;
            this.logBox.Text = "";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OHM - Arduino";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // notifyIconMenu
            // 
            this.notifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWindowToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyIconMenu.Name = "notifyIconMenu";
            this.notifyIconMenu.Size = new System.Drawing.Size(149, 48);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.showWindowToolStripMenuItem.Text = "Show window";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Line1
            // 
            this.Line1.AutoSize = true;
            this.Line1.Location = new System.Drawing.Point(387, 17);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(36, 13);
            this.Line1.TabIndex = 7;
            this.Line1.Text = "Line 1";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(387, 80);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(36, 13);
            this.line2.TabIndex = 11;
            this.line2.Text = "Line 2";
            // 
            // switchTimer
            // 
            this.switchTimer.AutoSize = true;
            this.switchTimer.Location = new System.Drawing.Point(389, 148);
            this.switchTimer.Name = "switchTimer";
            this.switchTimer.Size = new System.Drawing.Size(70, 13);
            this.switchTimer.TabIndex = 12;
            this.switchTimer.Text = "Switch timer :";
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(392, 268);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(229, 27);
            this.buttonSaveSettings.TabIndex = 28;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.saveSettings);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "seconds";
            // 
            // line2GPUClock
            // 
            this.line2GPUClock.AutoSize = true;
            this.line2GPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2GPUClock;
            this.line2GPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2GPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2GPUClock.Location = new System.Drawing.Point(486, 122);
            this.line2GPUClock.Name = "line2GPUClock";
            this.line2GPUClock.Size = new System.Drawing.Size(79, 17);
            this.line2GPUClock.TabIndex = 24;
            this.line2GPUClock.Text = "GPU Clock";
            this.line2GPUClock.UseVisualStyleBackColor = true;
            // 
            // line1GPUClock
            // 
            this.line1GPUClock.AutoSize = true;
            this.line1GPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1GPUClock;
            this.line1GPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1GPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1GPUClock.Location = new System.Drawing.Point(486, 59);
            this.line1GPUClock.Name = "line1GPUClock";
            this.line1GPUClock.Size = new System.Drawing.Size(79, 17);
            this.line1GPUClock.TabIndex = 23;
            this.line1GPUClock.Text = "GPU Clock";
            this.line1GPUClock.UseVisualStyleBackColor = true;
            // 
            // line2CPUClock
            // 
            this.line2CPUClock.AutoSize = true;
            this.line2CPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2CPUClock;
            this.line2CPUClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line2CPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2CPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2CPUClock.Location = new System.Drawing.Point(392, 122);
            this.line2CPUClock.Name = "line2CPUClock";
            this.line2CPUClock.Size = new System.Drawing.Size(78, 17);
            this.line2CPUClock.TabIndex = 22;
            this.line2CPUClock.Text = "CPU Clock";
            this.line2CPUClock.UseVisualStyleBackColor = true;
            // 
            // line1CPUClock
            // 
            this.line1CPUClock.AutoSize = true;
            this.line1CPUClock.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1CPUClock;
            this.line1CPUClock.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1CPUClock", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1CPUClock.Location = new System.Drawing.Point(392, 59);
            this.line1CPUClock.Name = "line1CPUClock";
            this.line1CPUClock.Size = new System.Drawing.Size(78, 17);
            this.line1CPUClock.TabIndex = 21;
            this.line1CPUClock.Text = "CPU Clock";
            this.line1CPUClock.UseVisualStyleBackColor = true;
            // 
            // comboBoxSwitchTimer
            // 
            this.comboBoxSwitchTimer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ohm_arduino_gui.Properties.Settings.Default, "switchTimer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxSwitchTimer.FormattingEnabled = true;
            this.comboBoxSwitchTimer.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.comboBoxSwitchTimer.Location = new System.Drawing.Point(459, 145);
            this.comboBoxSwitchTimer.Name = "comboBoxSwitchTimer";
            this.comboBoxSwitchTimer.Size = new System.Drawing.Size(41, 21);
            this.comboBoxSwitchTimer.TabIndex = 13;
            this.comboBoxSwitchTimer.Text = global::ohm_arduino_gui.Properties.Settings.Default.switchTimer;
            // 
            // line2GPU
            // 
            this.line2GPU.AutoSize = true;
            this.line2GPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2GPU;
            this.line2GPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2GPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2GPU.Location = new System.Drawing.Point(486, 99);
            this.line2GPU.Name = "line2GPU";
            this.line2GPU.Size = new System.Drawing.Size(49, 17);
            this.line2GPU.TabIndex = 9;
            this.line2GPU.Text = "GPU";
            this.line2GPU.UseVisualStyleBackColor = true;
            // 
            // line2CPU
            // 
            this.line2CPU.AutoSize = true;
            this.line2CPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line2CPU;
            this.line2CPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line2CPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line2CPU.Location = new System.Drawing.Point(392, 99);
            this.line2CPU.Name = "line2CPU";
            this.line2CPU.Size = new System.Drawing.Size(48, 17);
            this.line2CPU.TabIndex = 8;
            this.line2CPU.Text = "CPU";
            this.line2CPU.UseVisualStyleBackColor = true;
            // 
            // line1GPU
            // 
            this.line1GPU.AutoSize = true;
            this.line1GPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1GPU;
            this.line1GPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1GPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1GPU.Location = new System.Drawing.Point(486, 36);
            this.line1GPU.Name = "line1GPU";
            this.line1GPU.Size = new System.Drawing.Size(49, 17);
            this.line1GPU.TabIndex = 5;
            this.line1GPU.Text = "GPU";
            this.line1GPU.UseVisualStyleBackColor = true;
            // 
            // line1CPU
            // 
            this.line1CPU.AutoSize = true;
            this.line1CPU.Checked = global::ohm_arduino_gui.Properties.Settings.Default.line1CPU;
            this.line1CPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.line1CPU.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ohm_arduino_gui.Properties.Settings.Default, "line1CPU", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.line1CPU.Location = new System.Drawing.Point(392, 36);
            this.line1CPU.Name = "line1CPU";
            this.line1CPU.Size = new System.Drawing.Size(48, 17);
            this.line1CPU.TabIndex = 4;
            this.line1CPU.Text = "CPU";
            this.line1CPU.UseVisualStyleBackColor = true;
            // 
            // line1RAM
            // 
            this.line1RAM.AutoSize = true;
            this.line1RAM.Location = new System.Drawing.Point(541, 36);
            this.line1RAM.Name = "line1RAM";
            this.line1RAM.Size = new System.Drawing.Size(50, 17);
            this.line1RAM.TabIndex = 31;
            this.line1RAM.Text = "RAM";
            this.line1RAM.UseVisualStyleBackColor = true;
            // 
            // line2RAM
            // 
            this.line2RAM.AutoSize = true;
            this.line2RAM.Location = new System.Drawing.Point(541, 99);
            this.line2RAM.Name = "line2RAM";
            this.line2RAM.Size = new System.Drawing.Size(50, 17);
            this.line2RAM.TabIndex = 32;
            this.line2RAM.Text = "RAM";
            this.line2RAM.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 308);
            this.Controls.Add(this.line2RAM);
            this.Controls.Add(this.line1RAM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.line2GPUClock);
            this.Controls.Add(this.line1GPUClock);
            this.Controls.Add(this.line2CPUClock);
            this.Controls.Add(this.line1CPUClock);
            this.Controls.Add(this.comboBoxSwitchTimer);
            this.Controls.Add(this.switchTimer);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line2GPU);
            this.Controls.Add(this.line2CPU);
            this.Controls.Add(this.Line1);
            this.Controls.Add(this.line1GPU);
            this.Controls.Add(this.line1CPU);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.comPortCombo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "OpenHardwareMonitor - Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.ComboBox comPortCombo;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconMenu;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox line1CPU;
        private System.Windows.Forms.CheckBox line1GPU;
        private System.Windows.Forms.Label Line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.CheckBox line2GPU;
        private System.Windows.Forms.CheckBox line2CPU;
        private System.Windows.Forms.Label switchTimer;
        private System.Windows.Forms.ComboBox comboBoxSwitchTimer;
        private System.Windows.Forms.CheckBox line1CPUClock;
        private System.Windows.Forms.CheckBox line2CPUClock;
        private System.Windows.Forms.CheckBox line1GPUClock;
        private System.Windows.Forms.CheckBox line2GPUClock;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox line1RAM;
        private System.Windows.Forms.CheckBox line2RAM;
    }
}

