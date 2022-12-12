namespace WindowsFormsApp1
{
    partial class Add_ApplicationSupplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_idMenager = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Condition2 = new System.Windows.Forms.TextBox();
            this.textBox_ReleaseDate2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_MadeCountry = new System.Windows.Forms.TextBox();
            this.textBox_ModelAuto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_MarkaAuto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_id1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(147, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 77);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Заявка поставщику";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_idMenager);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_Condition2);
            this.panel2.Controls.Add(this.textBox_ReleaseDate2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_MadeCountry);
            this.panel2.Controls.Add(this.textBox_ModelAuto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_MarkaAuto);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBox_id1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(147, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 431);
            this.panel2.TabIndex = 8;
            // 
            // textBox_idMenager
            // 
            this.textBox_idMenager.Location = new System.Drawing.Point(305, 106);
            this.textBox_idMenager.Name = "textBox_idMenager";
            this.textBox_idMenager.Size = new System.Drawing.Size(138, 20);
            this.textBox_idMenager.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "КодМенеджера:";
            // 
            // textBox_Condition2
            // 
            this.textBox_Condition2.Location = new System.Drawing.Point(305, 239);
            this.textBox_Condition2.Name = "textBox_Condition2";
            this.textBox_Condition2.Size = new System.Drawing.Size(138, 20);
            this.textBox_Condition2.TabIndex = 35;
            // 
            // textBox_ReleaseDate2
            // 
            this.textBox_ReleaseDate2.Location = new System.Drawing.Point(305, 204);
            this.textBox_ReleaseDate2.MaxLength = 4;
            this.textBox_ReleaseDate2.Name = "textBox_ReleaseDate2";
            this.textBox_ReleaseDate2.Size = new System.Drawing.Size(138, 20);
            this.textBox_ReleaseDate2.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Состояние:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Год выпуска:";
            // 
            // textBox_MadeCountry
            // 
            this.textBox_MadeCountry.Location = new System.Drawing.Point(305, 172);
            this.textBox_MadeCountry.Name = "textBox_MadeCountry";
            this.textBox_MadeCountry.Size = new System.Drawing.Size(138, 20);
            this.textBox_MadeCountry.TabIndex = 31;
            // 
            // textBox_ModelAuto
            // 
            this.textBox_ModelAuto.Location = new System.Drawing.Point(305, 137);
            this.textBox_ModelAuto.Name = "textBox_ModelAuto";
            this.textBox_ModelAuto.Size = new System.Drawing.Size(138, 20);
            this.textBox_ModelAuto.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Страна Изготовитель:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Модель Авто:";
            // 
            // textBox_MarkaAuto
            // 
            this.textBox_MarkaAuto.Location = new System.Drawing.Point(305, 67);
            this.textBox_MarkaAuto.Name = "textBox_MarkaAuto";
            this.textBox_MarkaAuto.Size = new System.Drawing.Size(138, 20);
            this.textBox_MarkaAuto.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Марка Авто:";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(175, 318);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(108, 47);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, -36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Код Клиента";
            // 
            // txtBox_id1
            // 
            this.txtBox_id1.Location = new System.Drawing.Point(277, -43);
            this.txtBox_id1.Name = "txtBox_id1";
            this.txtBox_id1.Size = new System.Drawing.Size(138, 20);
            this.txtBox_id1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // Add_ApplicationSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Add_ApplicationSupplier";
            this.Text = "Add_ApplicationSupplier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_id1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Condition2;
        private System.Windows.Forms.TextBox textBox_ReleaseDate2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_MadeCountry;
        private System.Windows.Forms.TextBox textBox_ModelAuto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_MarkaAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_idMenager;
        private System.Windows.Forms.Label label2;
    }
}