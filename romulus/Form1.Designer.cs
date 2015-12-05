namespace romulus
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox_converter = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_romanNumber = new System.Windows.Forms.Label();
            this.textBox_romanNumber = new System.Windows.Forms.TextBox();
            this.label_decimalNumber = new System.Windows.Forms.Label();
            this.textBox_decimalNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_colours = new System.Windows.Forms.CheckBox();
            this.checkBox_autoCopy = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_errorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_converter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_converter
            // 
            this.groupBox_converter.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_converter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox_converter.Controls.Add(this.label_romanNumber);
            this.groupBox_converter.Controls.Add(this.textBox_romanNumber);
            this.groupBox_converter.Controls.Add(this.label_decimalNumber);
            this.groupBox_converter.Controls.Add(this.textBox_decimalNumber);
            this.groupBox_converter.Controls.Add(this.button1);
            this.groupBox_converter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_converter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(139)))), ((int)(((byte)(255)))));
            this.groupBox_converter.Location = new System.Drawing.Point(16, 14);
            this.groupBox_converter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_converter.Name = "groupBox_converter";
            this.groupBox_converter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_converter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_converter.Size = new System.Drawing.Size(547, 180);
            this.groupBox_converter.TabIndex = 0;
            this.groupBox_converter.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(36, 125);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 3999;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(506, 56);
            this.trackBar1.SmallChange = 500;
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TickFrequency = 500;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label_romanNumber
            // 
            this.label_romanNumber.AutoSize = true;
            this.label_romanNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_romanNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_romanNumber.Location = new System.Drawing.Point(275, 34);
            this.label_romanNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_romanNumber.Name = "label_romanNumber";
            this.label_romanNumber.Size = new System.Drawing.Size(90, 29);
            this.label_romanNumber.TabIndex = 2;
            this.label_romanNumber.Text = "Roman";
            this.label_romanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_romanNumber
            // 
            this.textBox_romanNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_romanNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_romanNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_romanNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_romanNumber.Enabled = false;
            this.textBox_romanNumber.Location = new System.Drawing.Point(280, 69);
            this.textBox_romanNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_romanNumber.Name = "textBox_romanNumber";
            this.textBox_romanNumber.ReadOnly = true;
            this.textBox_romanNumber.Size = new System.Drawing.Size(246, 34);
            this.textBox_romanNumber.TabIndex = 1;
            this.textBox_romanNumber.Click += new System.EventHandler(this.textbox_roman_click);
            this.textBox_romanNumber.TextChanged += new System.EventHandler(this.textBox_romanNumber_TextChanged);
            // 
            // label_decimalNumber
            // 
            this.label_decimalNumber.AutoSize = true;
            this.label_decimalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decimalNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_decimalNumber.Location = new System.Drawing.Point(14, 34);
            this.label_decimalNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_decimalNumber.Name = "label_decimalNumber";
            this.label_decimalNumber.Size = new System.Drawing.Size(101, 29);
            this.label_decimalNumber.TabIndex = 1;
            this.label_decimalNumber.Text = "Decimal";
            this.label_decimalNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_decimalNumber
            // 
            this.textBox_decimalNumber.AcceptsReturn = true;
            this.textBox_decimalNumber.AcceptsTab = true;
            this.textBox_decimalNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_decimalNumber.Location = new System.Drawing.Point(20, 69);
            this.textBox_decimalNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_decimalNumber.Name = "textBox_decimalNumber";
            this.textBox_decimalNumber.Size = new System.Drawing.Size(246, 34);
            this.textBox_decimalNumber.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox_decimalNumber, "Write in a Decimal to convert it into a Roman numeral.");
            this.textBox_decimalNumber.Click += new System.EventHandler(this.textbox_decimal_click);
            this.textBox_decimalNumber.TextChanged += new System.EventHandler(this.textBox_decimalNumber_TextChanged);
            this.textBox_decimalNumber.Enter += new System.EventHandler(this.textBox_decimal_Enter);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(20, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 36);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(451, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Authors: TKi; CKl";
            // 
            // checkBox_colours
            // 
            this.checkBox_colours.AutoSize = true;
            this.checkBox_colours.Checked = true;
            this.checkBox_colours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_colours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_colours.Location = new System.Drawing.Point(16, 199);
            this.checkBox_colours.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_colours.Name = "checkBox_colours";
            this.checkBox_colours.Size = new System.Drawing.Size(74, 21);
            this.checkBox_colours.TabIndex = 2;
            this.checkBox_colours.TabStop = false;
            this.checkBox_colours.Text = "Colours";
            this.toolTip1.SetToolTip(this.checkBox_colours, "Enables or disables feedback colors while decimal input.");
            this.checkBox_colours.UseVisualStyleBackColor = true;
            this.checkBox_colours.CheckStateChanged += new System.EventHandler(this.checkBox_colours_CheckStateChanged);
            // 
            // checkBox_autoCopy
            // 
            this.checkBox_autoCopy.AutoSize = true;
            this.checkBox_autoCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_autoCopy.Location = new System.Drawing.Point(98, 199);
            this.checkBox_autoCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_autoCopy.Name = "checkBox_autoCopy";
            this.checkBox_autoCopy.Size = new System.Drawing.Size(87, 21);
            this.checkBox_autoCopy.TabIndex = 3;
            this.checkBox_autoCopy.TabStop = false;
            this.checkBox_autoCopy.Text = "AutoCopy";
            this.toolTip1.SetToolTip(this.checkBox_autoCopy, "Enables or disables automatic copy of the Roman numeral.");
            this.checkBox_autoCopy.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_errorMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 227);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(579, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_errorMessage
            // 
            this.toolStripStatusLabel_errorMessage.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_errorMessage.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_errorMessage.Margin = new System.Windows.Forms.Padding(11, 3, 0, 2);
            this.toolStripStatusLabel_errorMessage.Name = "toolStripStatusLabel_errorMessage";
            this.toolStripStatusLabel_errorMessage.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel_errorMessage.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.button1;
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 249);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox_autoCopy);
            this.Controls.Add(this.checkBox_colours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_converter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Romulus";
            this.groupBox_converter.ResumeLayout(false);
            this.groupBox_converter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_converter;
        private System.Windows.Forms.TextBox textBox_decimalNumber;
        private System.Windows.Forms.Label label_decimalNumber;
        private System.Windows.Forms.Label label_romanNumber;
        private System.Windows.Forms.TextBox textBox_romanNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_colours;
        private System.Windows.Forms.CheckBox checkBox_autoCopy;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_errorMessage;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

