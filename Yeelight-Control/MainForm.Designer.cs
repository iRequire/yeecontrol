namespace Yeelight_Control
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.button_Temperature = new System.Windows.Forms.Button();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.button_Brightness = new System.Windows.Forms.Button();
            this.label_Brightness = new System.Windows.Forms.Label();
            this.button_White = new System.Windows.Forms.Button();
            this.button_Color = new System.Windows.Forms.Button();
            this.button_ToggleOff = new System.Windows.Forms.Button();
            this.button_ToggleOn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Devices = new System.Windows.Forms.CheckedListBox();
            this.button_Dropdown = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_Edit = new System.Windows.Forms.GroupBox();
            this.button_Overwrite = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.textBox_Rename = new System.Windows.Forms.TextBox();
            this.button_Rename = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_Preset = new System.Windows.Forms.TextBox();
            this.button_SavePreset = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Devices = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_Edit.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.button_White);
            this.groupBox1.Controls.Add(this.button_Color);
            this.groupBox1.Controls.Add(this.button_ToggleOff);
            this.groupBox1.Controls.Add(this.button_ToggleOn);
            this.groupBox1.Location = new System.Drawing.Point(118, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 115);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.trackBarTemperature);
            this.groupBox5.Controls.Add(this.button_Temperature);
            this.groupBox5.Controls.Add(this.label_Temperature);
            this.groupBox5.Controls.Add(this.trackBarBrightness);
            this.groupBox5.Controls.Add(this.button_Brightness);
            this.groupBox5.Controls.Add(this.label_Brightness);
            this.groupBox5.Location = new System.Drawing.Point(106, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 88);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Brightness/Temperature";
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.AutoSize = false;
            this.trackBarTemperature.Location = new System.Drawing.Point(6, 60);
            this.trackBarTemperature.Maximum = 6500;
            this.trackBarTemperature.Minimum = 1700;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Size = new System.Drawing.Size(107, 22);
            this.trackBarTemperature.TabIndex = 6;
            this.trackBarTemperature.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarTemperature.Value = 4000;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // button_Temperature
            // 
            this.button_Temperature.Location = new System.Drawing.Point(158, 59);
            this.button_Temperature.Name = "button_Temperature";
            this.button_Temperature.Size = new System.Drawing.Size(34, 23);
            this.button_Temperature.TabIndex = 8;
            this.button_Temperature.Text = "OK";
            this.button_Temperature.UseVisualStyleBackColor = true;
            this.button_Temperature.Click += new System.EventHandler(this.button_Temperature_Click);
            // 
            // label_Temperature
            // 
            this.label_Temperature.AutoSize = true;
            this.label_Temperature.Location = new System.Drawing.Point(114, 65);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(38, 13);
            this.label_Temperature.TabIndex = 7;
            this.label_Temperature.Text = "4000K";
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.AutoSize = false;
            this.trackBarBrightness.Location = new System.Drawing.Point(6, 14);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = 1;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(107, 22);
            this.trackBarBrightness.TabIndex = 3;
            this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBrightness.Value = 100;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            // 
            // button_Brightness
            // 
            this.button_Brightness.Location = new System.Drawing.Point(158, 14);
            this.button_Brightness.Name = "button_Brightness";
            this.button_Brightness.Size = new System.Drawing.Size(34, 23);
            this.button_Brightness.TabIndex = 5;
            this.button_Brightness.Text = "OK";
            this.button_Brightness.UseVisualStyleBackColor = true;
            this.button_Brightness.Click += new System.EventHandler(this.button_Brightness_Click);
            // 
            // label_Brightness
            // 
            this.label_Brightness.AutoSize = true;
            this.label_Brightness.Location = new System.Drawing.Point(119, 19);
            this.label_Brightness.Name = "label_Brightness";
            this.label_Brightness.Size = new System.Drawing.Size(33, 13);
            this.label_Brightness.TabIndex = 4;
            this.label_Brightness.Text = "100%";
            // 
            // button_White
            // 
            this.button_White.Location = new System.Drawing.Point(6, 84);
            this.button_White.Name = "button_White";
            this.button_White.Size = new System.Drawing.Size(76, 23);
            this.button_White.TabIndex = 6;
            this.button_White.Text = "White";
            this.button_White.UseVisualStyleBackColor = true;
            this.button_White.Click += new System.EventHandler(this.button_White_Click);
            // 
            // button_Color
            // 
            this.button_Color.Location = new System.Drawing.Point(6, 52);
            this.button_Color.Name = "button_Color";
            this.button_Color.Size = new System.Drawing.Size(76, 23);
            this.button_Color.TabIndex = 2;
            this.button_Color.Text = "Color";
            this.button_Color.UseVisualStyleBackColor = true;
            this.button_Color.Click += new System.EventHandler(this.button_Color_Click);
            // 
            // button_ToggleOff
            // 
            this.button_ToggleOff.Location = new System.Drawing.Point(43, 19);
            this.button_ToggleOff.Name = "button_ToggleOff";
            this.button_ToggleOff.Size = new System.Drawing.Size(39, 25);
            this.button_ToggleOff.TabIndex = 1;
            this.button_ToggleOff.Text = "OFF";
            this.button_ToggleOff.UseVisualStyleBackColor = true;
            this.button_ToggleOff.Click += new System.EventHandler(this.button_ToggleOff_Click);
            // 
            // button_ToggleOn
            // 
            this.button_ToggleOn.Location = new System.Drawing.Point(6, 19);
            this.button_ToggleOn.Name = "button_ToggleOn";
            this.button_ToggleOn.Size = new System.Drawing.Size(31, 25);
            this.button_ToggleOn.TabIndex = 0;
            this.button_ToggleOn.Text = "ON";
            this.button_ToggleOn.UseVisualStyleBackColor = true;
            this.button_ToggleOn.Click += new System.EventHandler(this.button_ToggleOn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox_Devices);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 144);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lights";
            // 
            // checkedListBox_Devices
            // 
            this.checkedListBox_Devices.FormattingEnabled = true;
            this.checkedListBox_Devices.Location = new System.Drawing.Point(6, 13);
            this.checkedListBox_Devices.Name = "checkedListBox_Devices";
            this.checkedListBox_Devices.Size = new System.Drawing.Size(410, 124);
            this.checkedListBox_Devices.TabIndex = 0;
            // 
            // button_Dropdown
            // 
            this.button_Dropdown.Location = new System.Drawing.Point(12, 195);
            this.button_Dropdown.Name = "button_Dropdown";
            this.button_Dropdown.Size = new System.Drawing.Size(100, 25);
            this.button_Dropdown.TabIndex = 12;
            this.button_Dropdown.Text = "Toggle Presets";
            this.button_Dropdown.UseVisualStyleBackColor = true;
            this.button_Dropdown.Click += new System.EventHandler(this.button_Dropdown_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox_Edit);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 167);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurations/Presets";
            // 
            // groupBox_Edit
            // 
            this.groupBox_Edit.Controls.Add(this.button_Overwrite);
            this.groupBox_Edit.Controls.Add(this.button_Delete);
            this.groupBox_Edit.Controls.Add(this.textBox_Rename);
            this.groupBox_Edit.Controls.Add(this.button_Rename);
            this.groupBox_Edit.Location = new System.Drawing.Point(197, 19);
            this.groupBox_Edit.Name = "groupBox_Edit";
            this.groupBox_Edit.Size = new System.Drawing.Size(219, 76);
            this.groupBox_Edit.TabIndex = 4;
            this.groupBox_Edit.TabStop = false;
            this.groupBox_Edit.Text = "Edit Configuration";
            // 
            // button_Overwrite
            // 
            this.button_Overwrite.Location = new System.Drawing.Point(6, 45);
            this.button_Overwrite.Name = "button_Overwrite";
            this.button_Overwrite.Size = new System.Drawing.Size(75, 21);
            this.button_Overwrite.TabIndex = 3;
            this.button_Overwrite.Text = "Overwrite";
            this.button_Overwrite.UseVisualStyleBackColor = true;
            this.button_Overwrite.Click += new System.EventHandler(this.button_Overwrite_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(87, 45);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(59, 21);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // textBox_Rename
            // 
            this.textBox_Rename.Location = new System.Drawing.Point(6, 19);
            this.textBox_Rename.Name = "textBox_Rename";
            this.textBox_Rename.Size = new System.Drawing.Size(140, 20);
            this.textBox_Rename.TabIndex = 0;
            this.textBox_Rename.Text = "YeelightPreset";
            // 
            // button_Rename
            // 
            this.button_Rename.Location = new System.Drawing.Point(152, 18);
            this.button_Rename.Name = "button_Rename";
            this.button_Rename.Size = new System.Drawing.Size(63, 21);
            this.button_Rename.TabIndex = 1;
            this.button_Rename.Text = "Rename";
            this.button_Rename.UseVisualStyleBackColor = true;
            this.button_Rename.Click += new System.EventHandler(this.button_Rename_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_Preset);
            this.groupBox4.Controls.Add(this.button_SavePreset);
            this.groupBox4.Location = new System.Drawing.Point(197, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(219, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save Configuration";
            // 
            // textBox_Preset
            // 
            this.textBox_Preset.Location = new System.Drawing.Point(6, 19);
            this.textBox_Preset.Name = "textBox_Preset";
            this.textBox_Preset.Size = new System.Drawing.Size(140, 20);
            this.textBox_Preset.TabIndex = 0;
            this.textBox_Preset.Text = "YeelightPreset";
            // 
            // button_SavePreset
            // 
            this.button_SavePreset.Location = new System.Drawing.Point(152, 18);
            this.button_SavePreset.Name = "button_SavePreset";
            this.button_SavePreset.Size = new System.Drawing.Size(61, 21);
            this.button_SavePreset.TabIndex = 1;
            this.button_SavePreset.Text = "Save";
            this.button_SavePreset.UseVisualStyleBackColor = true;
            this.button_SavePreset.Click += new System.EventHandler(this.button_SavePreset_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(185, 134);
            this.listBox1.TabIndex = 2;
            // 
            // button_Devices
            // 
            this.button_Devices.Location = new System.Drawing.Point(12, 162);
            this.button_Devices.Name = "button_Devices";
            this.button_Devices.Size = new System.Drawing.Size(100, 25);
            this.button_Devices.TabIndex = 15;
            this.button_Devices.Text = "Open Devices";
            this.button_Devices.UseVisualStyleBackColor = true;
            this.button_Devices.Click += new System.EventHandler(this.button_Devices_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(444, 20);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(232, 15);
            this.toolStripStatusLabel1.Text = "Yeelight Control 1.0 | www.yeecontrol.com";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 486);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Devices);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Dropdown);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeeControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox_Edit.ResumeLayout(false);
            this.groupBox_Edit.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ToggleOff;
        private System.Windows.Forms.Button button_ToggleOn;
        private System.Windows.Forms.Button button_Color;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label_Brightness;
        private System.Windows.Forms.Button button_Brightness;
        private System.Windows.Forms.Button button_White;
        private System.Windows.Forms.Button button_Dropdown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_SavePreset;
        private System.Windows.Forms.TextBox textBox_Preset;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox_Edit;
        private System.Windows.Forms.TextBox textBox_Rename;
        private System.Windows.Forms.Button button_Rename;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Overwrite;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.Button button_Temperature;
        private System.Windows.Forms.Label label_Temperature;
        private System.Windows.Forms.CheckedListBox checkedListBox_Devices;
        private System.Windows.Forms.Button button_Devices;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

