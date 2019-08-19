namespace WindowsFormsApplication1
{
     partial class districtsAddForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_town = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_districtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_district_Code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cmb_districtBase = new System.Windows.Forms.ComboBox();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(630, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 70);
            this.button4.TabIndex = 27;
            this.button4.Text = "Add a Supervisor";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(515, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 26;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 25;
            this.button2.Text = "Add (+)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(515, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add (+)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 164);
            this.dataGridView1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 33);
            this.label5.TabIndex = 22;
            this.label5.Text = "Management Of district";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Town :";
            // 
            // cmb_town
            // 
            this.cmb_town.FormattingEnabled = true;
            this.cmb_town.Items.AddRange(new object[] {
            "Yaoundé",
            "Littoral",
            "Bamenda",
            "Buea",
            "Est ",
            "Ouest",
            "Sud-Ouest",
            "Center",
            "Adamaoua",
            "Nord"});
            this.cmb_town.Location = new System.Drawing.Point(141, 321);
            this.cmb_town.Name = "cmb_town";
            this.cmb_town.Size = new System.Drawing.Size(244, 26);
            this.cmb_town.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Base :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name : ";
            // 
            // tb_districtName
            // 
            this.tb_districtName.Location = new System.Drawing.Point(141, 218);
            this.tb_districtName.Name = "tb_districtName";
            this.tb_districtName.Size = new System.Drawing.Size(244, 25);
            this.tb_districtName.TabIndex = 16;
            this.tb_districtName.TextChanged += new System.EventHandler(this.Tb_districtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code : ";
            // 
            // tb_district_Code
            // 
            this.tb_district_Code.Location = new System.Drawing.Point(141, 162);
            this.tb_district_Code.Name = "tb_district_Code";
            this.tb_district_Code.ReadOnly = true;
            this.tb_district_Code.Size = new System.Drawing.Size(244, 25);
            this.tb_district_Code.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Area :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 267);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 26);
            this.button5.TabIndex = 30;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cmb_districtBase
            // 
            this.cmb_districtBase.FormattingEnabled = true;
            this.cmb_districtBase.Location = new System.Drawing.Point(141, 267);
            this.cmb_districtBase.Name = "cmb_districtBase";
            this.cmb_districtBase.Size = new System.Drawing.Size(244, 26);
            this.cmb_districtBase.TabIndex = 31;
            // 
            // cmb_area
            // 
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(141, 94);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(244, 26);
            this.cmb_area.TabIndex = 32;
            this.cmb_area.SelectedIndexChanged += new System.EventHandler(this.Cmb_area_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Detail Region selected";
            // 
            // districtsAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 545);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_area);
            this.Controls.Add(this.cmb_districtBase);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_town);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_districtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_district_Code);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "districtsAddForm";
            this.Text = "districts";
            this.Load += new System.EventHandler(this.DistrictsAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_town;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_districtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_district_Code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmb_districtBase;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.Label label7;

    }
}