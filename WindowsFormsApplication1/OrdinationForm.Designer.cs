namespace WindowsFormsApplication1
{
    partial class OrdinationForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_ordinationDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_church = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_grade = new System.Windows.Forms.ComboBox();
            this.tb_otherOrdination = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_pastor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(276, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ordinate a pastor ";
            // 
            // dtp_ordinationDate
            // 
            this.dtp_ordinationDate.Location = new System.Drawing.Point(151, 393);
            this.dtp_ordinationDate.Name = "dtp_ordinationDate";
            this.dtp_ordinationDate.Size = new System.Drawing.Size(200, 25);
            this.dtp_ordinationDate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ordination Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Church :";
            // 
            // cmb_church
            // 
            this.cmb_church.FormattingEnabled = true;
            this.cmb_church.Location = new System.Drawing.Point(145, 206);
            this.cmb_church.Name = "cmb_church";
            this.cmb_church.Size = new System.Drawing.Size(218, 26);
            this.cmb_church.TabIndex = 11;
            this.cmb_church.SelectedIndexChanged += new System.EventHandler(this.Cmb_church_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Concern Area : ";
            // 
            // cmb_area
            // 
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(145, 89);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(218, 26);
            this.cmb_area.TabIndex = 9;
            this.cmb_area.SelectedIndexChanged += new System.EventHandler(this.Cmb_area_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Concern distrit : ";
            // 
            // cmb_district
            // 
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(145, 147);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(218, 26);
            this.cmb_district.TabIndex = 18;
            this.cmb_district.SelectedIndexChanged += new System.EventHandler(this.Cmb_district_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "Grade :";
            // 
            // cmb_grade
            // 
            this.cmb_grade.FormattingEnabled = true;
            this.cmb_grade.Items.AddRange(new object[] {
            "Reverend ",
            "Missionnaire",
            "Diacre ",
            "Diaconesse",
            "Evangeliste",
            "Apotre",
            "Supp Distrcit",
            "Supp Region",
            "Supp National ",
            "Vice Supre"});
            this.cmb_grade.Location = new System.Drawing.Point(145, 327);
            this.cmb_grade.Name = "cmb_grade";
            this.cmb_grade.Size = new System.Drawing.Size(218, 26);
            this.cmb_grade.TabIndex = 21;
            // 
            // tb_otherOrdination
            // 
            this.tb_otherOrdination.Location = new System.Drawing.Point(471, 327);
            this.tb_otherOrdination.Name = "tb_otherOrdination";
            this.tb_otherOrdination.Size = new System.Drawing.Size(165, 25);
            this.tb_otherOrdination.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Other :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Pastor :";
            // 
            // cmb_pastor
            // 
            this.cmb_pastor.FormattingEnabled = true;
            this.cmb_pastor.Location = new System.Drawing.Point(145, 266);
            this.cmb_pastor.Name = "cmb_pastor";
            this.cmb_pastor.Size = new System.Drawing.Size(218, 26);
            this.cmb_pastor.TabIndex = 24;
            // 
            // OrdinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_pastor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_otherOrdination);
            this.Controls.Add(this.cmb_grade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_district);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_ordinationDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_church);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_area);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdinationForm";
            this.Text = "OrdinationForm";
            this.Load += new System.EventHandler(this.OrdinationForm_Load);
            this.MouseLeave += new System.EventHandler(this.OrdinationForm_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_ordinationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_church;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_grade;
        private System.Windows.Forms.TextBox tb_otherOrdination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_pastor;
    }
}