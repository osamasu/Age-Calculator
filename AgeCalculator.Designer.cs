namespace Design
{
    partial class AgeCalculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeCalculator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Years = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_Months = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Days = new System.Windows.Forms.Label();
            this.CB_Custom = new System.Windows.Forms.CheckBox();
            this.DT_SpecificDate = new System.Windows.Forms.DateTimePicker();
            this.DT_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Calculate = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetToolStripMenuItem.Text = "&Reset";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.CB_Custom);
            this.panel1.Controls.Add(this.DT_SpecificDate);
            this.panel1.Controls.Add(this.DT_DateOfBirth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BT_Calculate);
            this.panel1.Location = new System.Drawing.Point(15, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 333);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.TB_Years);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.TB_Months);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TB_Days);
            this.panel3.Location = new System.Drawing.Point(19, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 100);
            this.panel3.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kelson Sans BG", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Years:";
            // 
            // TB_Years
            // 
            this.TB_Years.AutoSize = true;
            this.TB_Years.Font = new System.Drawing.Font("Kelson Sans BG", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Years.Location = new System.Drawing.Point(44, 54);
            this.TB_Years.Name = "TB_Years";
            this.TB_Years.Size = new System.Drawing.Size(32, 36);
            this.TB_Years.TabIndex = 27;
            this.TB_Years.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kelson Sans BG", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "Months:";
            // 
            // TB_Months
            // 
            this.TB_Months.AutoSize = true;
            this.TB_Months.Font = new System.Drawing.Font("Kelson Sans BG", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Months.Location = new System.Drawing.Point(200, 54);
            this.TB_Months.Name = "TB_Months";
            this.TB_Months.Size = new System.Drawing.Size(32, 36);
            this.TB_Months.TabIndex = 25;
            this.TB_Months.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kelson Sans BG", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Days:";
            // 
            // TB_Days
            // 
            this.TB_Days.AutoSize = true;
            this.TB_Days.Font = new System.Drawing.Font("Kelson Sans BG", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Days.Location = new System.Drawing.Point(335, 54);
            this.TB_Days.Name = "TB_Days";
            this.TB_Days.Size = new System.Drawing.Size(32, 36);
            this.TB_Days.TabIndex = 23;
            this.TB_Days.Text = "0";
            // 
            // CB_Custom
            // 
            this.CB_Custom.AutoSize = true;
            this.CB_Custom.Font = new System.Drawing.Font("Victor Mono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Custom.Location = new System.Drawing.Point(370, 158);
            this.CB_Custom.Name = "CB_Custom";
            this.CB_Custom.Size = new System.Drawing.Size(86, 25);
            this.CB_Custom.TabIndex = 14;
            this.CB_Custom.Text = "Custom";
            this.CB_Custom.UseVisualStyleBackColor = true;
            this.CB_Custom.CheckedChanged += new System.EventHandler(this.CB_Custom_CheckedChanged);
            // 
            // DT_SpecificDate
            // 
            this.DT_SpecificDate.Enabled = false;
            this.DT_SpecificDate.Location = new System.Drawing.Point(149, 159);
            this.DT_SpecificDate.MaxDate = new System.DateTime(2023, 8, 30, 0, 0, 0, 0);
            this.DT_SpecificDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DT_SpecificDate.Name = "DT_SpecificDate";
            this.DT_SpecificDate.Size = new System.Drawing.Size(200, 24);
            this.DT_SpecificDate.TabIndex = 13;
            this.DT_SpecificDate.Value = new System.DateTime(2023, 8, 30, 0, 0, 0, 0);
            // 
            // DT_DateOfBirth
            // 
            this.DT_DateOfBirth.Location = new System.Drawing.Point(149, 104);
            this.DT_DateOfBirth.MaxDate = new System.DateTime(2023, 8, 30, 0, 0, 0, 0);
            this.DT_DateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DT_DateOfBirth.Name = "DT_DateOfBirth";
            this.DT_DateOfBirth.Size = new System.Drawing.Size(200, 24);
            this.DT_DateOfBirth.TabIndex = 12;
            this.DT_DateOfBirth.Value = new System.DateTime(2023, 8, 30, 0, 0, 0, 0);
            this.DT_DateOfBirth.ValueChanged += new System.EventHandler(this.DT_DateOfBirth_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Readex Pro SemiBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 73);
            this.label3.TabIndex = 11;
            this.label3.Text = "Age Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Readex Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Readex Pro SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Specific Date:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Design.Properties.Resources.old_people_man_boy_icon_143391;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(456, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 197);
            this.panel2.TabIndex = 8;
            // 
            // BT_Calculate
            // 
            this.BT_Calculate.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_Calculate.FlatAppearance.BorderSize = 3;
            this.BT_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Calculate.Font = new System.Drawing.Font("Kelson Sans RU", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Calculate.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.BT_Calculate.IconColor = System.Drawing.Color.Black;
            this.BT_Calculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_Calculate.Location = new System.Drawing.Point(468, 216);
            this.BT_Calculate.Name = "BT_Calculate";
            this.BT_Calculate.Size = new System.Drawing.Size(168, 74);
            this.BT_Calculate.TabIndex = 7;
            this.BT_Calculate.Text = "Calculate";
            this.BT_Calculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Calculate.UseVisualStyleBackColor = false;
            this.BT_Calculate.Click += new System.EventHandler(this.BT_Calculate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(220)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(682, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "AgeCalculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private FontAwesome.Sharp.IconButton BT_Calculate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_SpecificDate;
        private System.Windows.Forms.DateTimePicker DT_DateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CB_Custom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TB_Years;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TB_Months;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TB_Days;
    }
}
