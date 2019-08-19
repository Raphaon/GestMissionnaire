namespace WindowsFormsApplication1
{
    partial class PastorFormTransfer
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_tranferDistrict = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tranferArea = new System.Windows.Forms.ComboBox();
            this.tb_code_trasfer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_oldPosition = new System.Windows.Forms.TextBox();
            this.cmb_churchPastor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_churchFrom = new System.Windows.Forms.ComboBox();
            this.dtp_dateOfTransfer = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_dateEffet = new System.Windows.Forms.DateTimePicker();
            this.cmb_churchTo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_DistrictTo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_otherPositionOc = new System.Windows.Forms.TextBox();
            this.cmb_pastorPosition = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_AreaTo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Code Transfer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Concern distrit : ";
            // 
            // cmb_tranferDistrict
            // 
            this.cmb_tranferDistrict.FormattingEnabled = true;
            this.cmb_tranferDistrict.Location = new System.Drawing.Point(151, 82);
            this.cmb_tranferDistrict.Name = "cmb_tranferDistrict";
            this.cmb_tranferDistrict.Size = new System.Drawing.Size(218, 26);
            this.cmb_tranferDistrict.TabIndex = 33;
            this.cmb_tranferDistrict.SelectedIndexChanged += new System.EventHandler(this.cmb_tranferDistrict_SelectedIndexChanged);
            this.cmb_tranferDistrict.SelectedValueChanged += new System.EventHandler(this.cmb_tranferDistrict_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(322, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 47);
            this.button2.TabIndex = 32;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Transfering a pastor ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Concern Area : ";
            // 
            // cmb_tranferArea
            // 
            this.cmb_tranferArea.FormattingEnabled = true;
            this.cmb_tranferArea.Location = new System.Drawing.Point(151, 24);
            this.cmb_tranferArea.Name = "cmb_tranferArea";
            this.cmb_tranferArea.Size = new System.Drawing.Size(218, 26);
            this.cmb_tranferArea.TabIndex = 24;
            this.cmb_tranferArea.SelectedIndexChanged += new System.EventHandler(this.cmb_tranferArea_SelectedIndexChanged);
            // 
            // tb_code_trasfer
            // 
            this.tb_code_trasfer.Location = new System.Drawing.Point(151, 305);
            this.tb_code_trasfer.Name = "tb_code_trasfer";
            this.tb_code_trasfer.ReadOnly = true;
            this.tb_code_trasfer.Size = new System.Drawing.Size(218, 25);
            this.tb_code_trasfer.TabIndex = 44;
            this.tb_code_trasfer.TextChanged += new System.EventHandler(this.Tb_code_trasfer_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_code_trasfer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_oldPosition);
            this.groupBox1.Controls.Add(this.cmb_churchPastor);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_tranferArea);
            this.groupBox1.Controls.Add(this.cmb_churchFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_tranferDistrict);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 346);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pastor From ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 260);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 18);
            this.label16.TabIndex = 54;
            this.label16.Text = "Position Ocupation :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "Pastor :";
            // 
            // tb_oldPosition
            // 
            this.tb_oldPosition.Location = new System.Drawing.Point(151, 260);
            this.tb_oldPosition.Name = "tb_oldPosition";
            this.tb_oldPosition.ReadOnly = true;
            this.tb_oldPosition.Size = new System.Drawing.Size(218, 25);
            this.tb_oldPosition.TabIndex = 53;
            // 
            // cmb_churchPastor
            // 
            this.cmb_churchPastor.FormattingEnabled = true;
            this.cmb_churchPastor.Location = new System.Drawing.Point(151, 206);
            this.cmb_churchPastor.Name = "cmb_churchPastor";
            this.cmb_churchPastor.Size = new System.Drawing.Size(218, 26);
            this.cmb_churchPastor.TabIndex = 54;
            this.cmb_churchPastor.SelectedIndexChanged += new System.EventHandler(this.Cmb_churchPastor_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 18);
            this.label12.TabIndex = 53;
            this.label12.Text = "Church From :";
            // 
            // cmb_churchFrom
            // 
            this.cmb_churchFrom.FormattingEnabled = true;
            this.cmb_churchFrom.Location = new System.Drawing.Point(151, 145);
            this.cmb_churchFrom.Name = "cmb_churchFrom";
            this.cmb_churchFrom.Size = new System.Drawing.Size(218, 26);
            this.cmb_churchFrom.TabIndex = 52;
            this.cmb_churchFrom.SelectedIndexChanged += new System.EventHandler(this.cmb_churchFrom_SelectedIndexChanged);
            // 
            // dtp_dateOfTransfer
            // 
            this.dtp_dateOfTransfer.Location = new System.Drawing.Point(184, 226);
            this.dtp_dateOfTransfer.Name = "dtp_dateOfTransfer";
            this.dtp_dateOfTransfer.Size = new System.Drawing.Size(200, 25);
            this.dtp_dateOfTransfer.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Date Of Transfer :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Take effet on :";
            // 
            // dtp_dateEffet
            // 
            this.dtp_dateEffet.Location = new System.Drawing.Point(184, 277);
            this.dtp_dateEffet.Name = "dtp_dateEffet";
            this.dtp_dateEffet.Size = new System.Drawing.Size(200, 25);
            this.dtp_dateEffet.TabIndex = 40;
            // 
            // cmb_churchTo
            // 
            this.cmb_churchTo.FormattingEnabled = true;
            this.cmb_churchTo.Location = new System.Drawing.Point(166, 153);
            this.cmb_churchTo.Name = "cmb_churchTo";
            this.cmb_churchTo.Size = new System.Drawing.Size(218, 26);
            this.cmb_churchTo.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 18);
            this.label14.TabIndex = 57;
            this.label14.Text = "Concern Area : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Position Ocupation :";
            // 
            // cmb_DistrictTo
            // 
            this.cmb_DistrictTo.FormattingEnabled = true;
            this.cmb_DistrictTo.Location = new System.Drawing.Point(166, 90);
            this.cmb_DistrictTo.Name = "cmb_DistrictTo";
            this.cmb_DistrictTo.Size = new System.Drawing.Size(218, 26);
            this.cmb_DistrictTo.TabIndex = 58;
            this.cmb_DistrictTo.SelectedIndexChanged += new System.EventHandler(this.cmb_DistrictTo_SelectedIndexChanged);
            this.cmb_DistrictTo.SelectedValueChanged += new System.EventHandler(this.cmb_DistrictTo_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "Church To :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 43;
            this.label7.Text = "or other position :";
            // 
            // tb_otherPositionOc
            // 
            this.tb_otherPositionOc.Location = new System.Drawing.Point(166, 421);
            this.tb_otherPositionOc.Name = "tb_otherPositionOc";
            this.tb_otherPositionOc.Size = new System.Drawing.Size(218, 25);
            this.tb_otherPositionOc.TabIndex = 37;
            // 
            // cmb_pastorPosition
            // 
            this.cmb_pastorPosition.FormattingEnabled = true;
            this.cmb_pastorPosition.Items.AddRange(new object[] {
            "Main Pastor",
            "Assis Pastor ",
            "Missionnaire",
            "Leader",
            "Supervisor"});
            this.cmb_pastorPosition.Location = new System.Drawing.Point(166, 343);
            this.cmb_pastorPosition.Name = "cmb_pastorPosition";
            this.cmb_pastorPosition.Size = new System.Drawing.Size(218, 26);
            this.cmb_pastorPosition.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 18);
            this.label15.TabIndex = 59;
            this.label15.Text = "Concern distrit : ";
            // 
            // cmb_AreaTo
            // 
            this.cmb_AreaTo.FormattingEnabled = true;
            this.cmb_AreaTo.Location = new System.Drawing.Point(166, 32);
            this.cmb_AreaTo.Name = "cmb_AreaTo";
            this.cmb_AreaTo.Size = new System.Drawing.Size(218, 26);
            this.cmb_AreaTo.TabIndex = 56;
            this.cmb_AreaTo.SelectedIndexChanged += new System.EventHandler(this.cmb_AreaTo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_AreaTo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmb_pastorPosition);
            this.groupBox2.Controls.Add(this.tb_otherPositionOc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmb_DistrictTo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmb_churchTo);
            this.groupBox2.Controls.Add(this.dtp_dateEffet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtp_dateOfTransfer);
            this.groupBox2.Location = new System.Drawing.Point(528, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 499);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Going to ";
            // 
            // PastorFormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PastorFormTransfer";
            this.Text = "PastorFormTransfer";
            this.Load += new System.EventHandler(this.PastorFormTransfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_tranferDistrict;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tranferArea;
        private System.Windows.Forms.TextBox tb_code_trasfer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_churchPastor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_churchFrom;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_oldPosition;
        private System.Windows.Forms.DateTimePicker dtp_dateOfTransfer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_dateEffet;
        private System.Windows.Forms.ComboBox cmb_churchTo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_DistrictTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_otherPositionOc;
        private System.Windows.Forms.ComboBox cmb_pastorPosition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_AreaTo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}