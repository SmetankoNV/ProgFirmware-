namespace ProgFirmware
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxScroll = new System.Windows.Forms.CheckBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAppBuild = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelBootBuild = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.labelBootVersion = new System.Windows.Forms.Label();
            this.labelBootName = new System.Windows.Forms.Label();
            this.labelFirmType = new System.Windows.Forms.Label();
            this.labelFirmLocation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabProgHex = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonProgram = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabProgHex.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(100, 13);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(66, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // checkBoxScroll
            // 
            this.checkBoxScroll.AutoSize = true;
            this.checkBoxScroll.Checked = true;
            this.checkBoxScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScroll.Location = new System.Drawing.Point(12, 17);
            this.checkBoxScroll.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxScroll.Name = "checkBoxScroll";
            this.checkBoxScroll.Size = new System.Drawing.Size(86, 17);
            this.checkBoxScroll.TabIndex = 14;
            this.checkBoxScroll.Text = "Enable scroll";
            this.checkBoxScroll.UseVisualStyleBackColor = true;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxLog.Location = new System.Drawing.Point(4, 41);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(810, 240);
            this.richTextBoxLog.TabIndex = 3;
            this.richTextBoxLog.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 58);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Location:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Name:";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(11, 24);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(190, 23);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "...";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAppBuild);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.labelBootBuild);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelAppVersion);
            this.groupBox2.Controls.Add(this.labelAppName);
            this.groupBox2.Controls.Add(this.labelBootVersion);
            this.groupBox2.Controls.Add(this.labelBootName);
            this.groupBox2.Controls.Add(this.labelFirmType);
            this.groupBox2.Controls.Add(this.labelFirmLocation);
            this.groupBox2.Controls.Add(this.buttonSelect);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(214, 294);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firmware";
            // 
            // labelAppBuild
            // 
            this.labelAppBuild.AutoSize = true;
            this.labelAppBuild.Location = new System.Drawing.Point(94, 266);
            this.labelAppBuild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppBuild.Name = "labelAppBuild";
            this.labelAppBuild.Size = new System.Drawing.Size(16, 13);
            this.labelAppBuild.TabIndex = 28;
            this.labelAppBuild.Text = "---";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Build:";
            // 
            // labelBootBuild
            // 
            this.labelBootBuild.AutoSize = true;
            this.labelBootBuild.Location = new System.Drawing.Point(94, 173);
            this.labelBootBuild.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBootBuild.Name = "labelBootBuild";
            this.labelBootBuild.Size = new System.Drawing.Size(16, 13);
            this.labelBootBuild.TabIndex = 26;
            this.labelBootBuild.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Build:";
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.Location = new System.Drawing.Point(94, 245);
            this.labelAppVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(16, 13);
            this.labelAppVersion.TabIndex = 24;
            this.labelAppVersion.Text = "---";
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Location = new System.Drawing.Point(94, 224);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(16, 13);
            this.labelAppName.TabIndex = 23;
            this.labelAppName.Text = "---";
            // 
            // labelBootVersion
            // 
            this.labelBootVersion.AutoSize = true;
            this.labelBootVersion.Location = new System.Drawing.Point(94, 152);
            this.labelBootVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBootVersion.Name = "labelBootVersion";
            this.labelBootVersion.Size = new System.Drawing.Size(16, 13);
            this.labelBootVersion.TabIndex = 22;
            this.labelBootVersion.Text = "---";
            // 
            // labelBootName
            // 
            this.labelBootName.AutoSize = true;
            this.labelBootName.Location = new System.Drawing.Point(94, 131);
            this.labelBootName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBootName.Name = "labelBootName";
            this.labelBootName.Size = new System.Drawing.Size(16, 13);
            this.labelBootName.TabIndex = 21;
            this.labelBootName.Text = "---";
            // 
            // labelFirmType
            // 
            this.labelFirmType.AutoSize = true;
            this.labelFirmType.Location = new System.Drawing.Point(92, 81);
            this.labelFirmType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirmType.Name = "labelFirmType";
            this.labelFirmType.Size = new System.Drawing.Size(16, 13);
            this.labelFirmType.TabIndex = 20;
            this.labelFirmType.Text = "---";
            // 
            // labelFirmLocation
            // 
            this.labelFirmLocation.AutoSize = true;
            this.labelFirmLocation.Location = new System.Drawing.Point(92, 58);
            this.labelFirmLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirmLocation.Name = "labelFirmLocation";
            this.labelFirmLocation.Size = new System.Drawing.Size(16, 13);
            this.labelFirmLocation.TabIndex = 19;
            this.labelFirmLocation.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Version:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Appication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Boot";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonClear);
            this.groupBox5.Controls.Add(this.checkBoxScroll);
            this.groupBox5.Controls.Add(this.richTextBoxLog);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(0, 294);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(818, 284);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(214, 292);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(604, 2);
            this.splitter1.TabIndex = 29;
            this.splitter1.TabStop = false;
            // 
            // tabProgHex
            // 
            this.tabProgHex.Controls.Add(this.groupBox4);
            this.tabProgHex.Controls.Add(this.groupBox3);
            this.tabProgHex.Location = new System.Drawing.Point(4, 22);
            this.tabProgHex.Margin = new System.Windows.Forms.Padding(2);
            this.tabProgHex.Name = "tabProgHex";
            this.tabProgHex.Padding = new System.Windows.Forms.Padding(2);
            this.tabProgHex.Size = new System.Drawing.Size(596, 268);
            this.tabProgHex.TabIndex = 0;
            this.tabProgHex.Text = "Программатор (HEX)";
            this.tabProgHex.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMinus);
            this.groupBox3.Controls.Add(this.buttonPlus);
            this.groupBox3.Controls.Add(this.textBoxSerial);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(214, 81);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial number";
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSerial.Location = new System.Drawing.Point(14, 32);
            this.textBoxSerial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(122, 29);
            this.textBoxSerial.TabIndex = 0;
            this.textBoxSerial.Text = "9000";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(140, 31);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(28, 30);
            this.buttonPlus.TabIndex = 1;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(172, 31);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(28, 30);
            this.buttonMinus.TabIndex = 2;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.buttonProgram);
            this.groupBox4.Location = new System.Drawing.Point(224, 12);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(370, 81);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // buttonProgram
            // 
            this.buttonProgram.Location = new System.Drawing.Point(4, 24);
            this.buttonProgram.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProgram.Name = "buttonProgram";
            this.buttonProgram.Size = new System.Drawing.Size(113, 44);
            this.buttonProgram.TabIndex = 15;
            this.buttonProgram.Text = "Program";
            this.buttonProgram.UseVisualStyleBackColor = true;
            this.buttonProgram.Click += new System.EventHandler(this.buttonProgram_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabProgHex);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(214, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(604, 294);
            this.tabControlMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 578);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabProgHex.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFirmLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxScroll;
        private System.Windows.Forms.Label labelAppVersion;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelBootVersion;
        private System.Windows.Forms.Label labelBootName;
        private System.Windows.Forms.Label labelFirmType;
        private System.Windows.Forms.Label labelAppBuild;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelBootBuild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabProgHex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonProgram;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}

