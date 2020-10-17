namespace Yeelight_Control
{
    partial class Devices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devices));
            this.button_Discover = new System.Windows.Forms.Button();
            this.listBox_Devices = new System.Windows.Forms.ListBox();
            this.label_Hostname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.button_Name = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Open = new System.Windows.Forms.Button();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Discover
            // 
            this.button_Discover.Location = new System.Drawing.Point(12, 347);
            this.button_Discover.Name = "button_Discover";
            this.button_Discover.Size = new System.Drawing.Size(123, 30);
            this.button_Discover.TabIndex = 0;
            this.button_Discover.Text = "Discover Devices";
            this.button_Discover.UseVisualStyleBackColor = true;
            this.button_Discover.Click += new System.EventHandler(this.button_Discover_Click);
            // 
            // listBox_Devices
            // 
            this.listBox_Devices.FormattingEnabled = true;
            this.listBox_Devices.Location = new System.Drawing.Point(12, 12);
            this.listBox_Devices.Name = "listBox_Devices";
            this.listBox_Devices.Size = new System.Drawing.Size(360, 329);
            this.listBox_Devices.TabIndex = 1;
            this.listBox_Devices.SelectedIndexChanged += new System.EventHandler(this.listBox_Devices_SelectedIndexChanged);
            // 
            // label_Hostname
            // 
            this.label_Hostname.AutoSize = true;
            this.label_Hostname.Location = new System.Drawing.Point(378, 12);
            this.label_Hostname.Name = "label_Hostname";
            this.label_Hostname.Size = new System.Drawing.Size(121, 13);
            this.label_Hostname.TabIndex = 2;
            this.label_Hostname.Text = "Hostname: <Hostname>";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(378, 29);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(81, 13);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name: <Name>";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(6, 19);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.button_Name);
            this.groupBoxActions.Controls.Add(this.textBox_Name);
            this.groupBoxActions.Controls.Add(this.button_Delete);
            this.groupBoxActions.Location = new System.Drawing.Point(381, 55);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(291, 100);
            this.groupBoxActions.TabIndex = 5;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Actions";
            // 
            // button_Name
            // 
            this.button_Name.Location = new System.Drawing.Point(201, 69);
            this.button_Name.Name = "button_Name";
            this.button_Name.Size = new System.Drawing.Size(84, 23);
            this.button_Name.TabIndex = 7;
            this.button_Name.Text = "Rename";
            this.button_Name.UseVisualStyleBackColor = true;
            this.button_Name.Click += new System.EventHandler(this.button_Name_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(6, 71);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(189, 20);
            this.textBox_Name.TabIndex = 6;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(387, 311);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(285, 30);
            this.button_Open.TabIndex = 7;
            this.button_Open.Text = "Open Yeelight Control";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 389);
            this.Controls.Add(this.button_Open);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Hostname);
            this.Controls.Add(this.listBox_Devices);
            this.Controls.Add(this.button_Discover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeelight Control - Devices";
            this.Load += new System.EventHandler(this.Devices_Load);
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Discover;
        private System.Windows.Forms.ListBox listBox_Devices;
        private System.Windows.Forms.Label label_Hostname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button button_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Open;
    }
}