namespace WindowsFormsApplication1
{
    partial class addTrainning
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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_TrainDateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_typeOfTrain = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_trainName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_trainGrade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_trainDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_pastor = new System.Windows.Forms.ComboBox();
            this.cmb_Area = new System.Windows.Forms.ComboBox();
            this.cmb_church = new System.Windows.Forms.ComboBox();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 45);
            this.button3.TabIndex = 30;
            this.button3.Text = "Add(+)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 45);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancel ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "New Pastor Trainning ";
            // 
            // dtp_TrainDateStart
            // 
            this.dtp_TrainDateStart.Location = new System.Drawing.Point(183, 351);
            this.dtp_TrainDateStart.Name = "dtp_TrainDateStart";
            this.dtp_TrainDateStart.Size = new System.Drawing.Size(200, 25);
            this.dtp_TrainDateStart.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Trainning start  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type of Trainnig :";
            // 
            // cmb_typeOfTrain
            // 
            this.cmb_typeOfTrain.FormattingEnabled = true;
            this.cmb_typeOfTrain.Items.AddRange(new object[] {
            "Biblical Trainning",
            "Academique"});
            this.cmb_typeOfTrain.Location = new System.Drawing.Point(143, 179);
            this.cmb_typeOfTrain.Name = "cmb_typeOfTrain";
            this.cmb_typeOfTrain.Size = new System.Drawing.Size(240, 26);
            this.cmb_typeOfTrain.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pastor Code : ";
            // 
            // tb_trainName
            // 
            this.tb_trainName.Location = new System.Drawing.Point(145, 236);
            this.tb_trainName.Name = "tb_trainName";
            this.tb_trainName.Size = new System.Drawing.Size(240, 25);
            this.tb_trainName.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Trainning Name :";
            // 
            // tb_trainGrade
            // 
            this.tb_trainGrade.Location = new System.Drawing.Point(143, 289);
            this.tb_trainGrade.Name = "tb_trainGrade";
            this.tb_trainGrade.Size = new System.Drawing.Size(240, 25);
            this.tb_trainGrade.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Grade : ";
            // 
            // dtp_trainDateEnd
            // 
            this.dtp_trainDateEnd.Location = new System.Drawing.Point(183, 409);
            this.dtp_trainDateEnd.Name = "dtp_trainDateEnd";
            this.dtp_trainDateEnd.Size = new System.Drawing.Size(200, 25);
            this.dtp_trainDateEnd.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 414);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 43;
            this.label11.Text = "Trainning end  : ";
            // 
            // cmb_pastor
            // 
            this.cmb_pastor.FormattingEnabled = true;
            this.cmb_pastor.Location = new System.Drawing.Point(480, 73);
            this.cmb_pastor.Name = "cmb_pastor";
            this.cmb_pastor.Size = new System.Drawing.Size(240, 26);
            this.cmb_pastor.TabIndex = 45;
            // 
            // cmb_Area
            // 
            this.cmb_Area.FormattingEnabled = true;
            this.cmb_Area.Location = new System.Drawing.Point(101, 29);
            this.cmb_Area.Name = "cmb_Area";
            this.cmb_Area.Size = new System.Drawing.Size(229, 26);
            this.cmb_Area.TabIndex = 55;
            this.cmb_Area.SelectedIndexChanged += new System.EventHandler(this.Cmb_Area_SelectedIndexChanged);
            // 
            // cmb_church
            // 
            this.cmb_church.FormattingEnabled = true;
            this.cmb_church.Location = new System.Drawing.Point(97, 70);
            this.cmb_church.Name = "cmb_church";
            this.cmb_church.Size = new System.Drawing.Size(229, 26);
            this.cmb_church.TabIndex = 57;
            this.cmb_church.SelectedIndexChanged += new System.EventHandler(this.Cmb_church_SelectedIndexChanged);
            // 
            // cmb_district
            // 
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Location = new System.Drawing.Point(480, 24);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(240, 26);
            this.cmb_district.TabIndex = 56;
            this.cmb_district.SelectedIndexChanged += new System.EventHandler(this.Cmb_district_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "Area : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 18);
            this.label12.TabIndex = 60;
            this.label12.Text = "District  : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 18);
            this.label13.TabIndex = 61;
            this.label13.Text = "Church : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_church);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_pastor);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmb_Area);
            this.groupBox1.Controls.Add(this.cmb_district);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 107);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Concern Pastor";
            // 
            // addTrainning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 548);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_trainDateEnd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_trainGrade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_trainName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_TrainDateStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_typeOfTrain);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addTrainning";
            this.Text = "adding a pastor Trainning";
            this.Load += new System.EventHandler(this.AddTrainning_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_TrainDateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_typeOfTrain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_trainName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_trainGrade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_trainDateEnd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_pastor;
        private System.Windows.Forms.ComboBox cmb_Area;
        private System.Windows.Forms.ComboBox cmb_church;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}