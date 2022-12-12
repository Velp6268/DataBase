namespace WindowsFormsApp1
{
    partial class ApplicationSupplier
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save1 = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Condition2 = new System.Windows.Forms.TextBox();
            this.textBox_ReleaseDate2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_MadeCountry = new System.Windows.Forms.TextBox();
            this.textBox_ModelAuto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_id3 = new System.Windows.Forms.TextBox();
            this.textBox_MarkaAuto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_save1);
            this.panel3.Controls.Add(this.btn_Change);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Location = new System.Drawing.Point(625, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 276);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Управление записими";
            // 
            // btn_save1
            // 
            this.btn_save1.Location = new System.Drawing.Point(41, 187);
            this.btn_save1.Name = "btn_save1";
            this.btn_save1.Size = new System.Drawing.Size(116, 41);
            this.btn_save1.TabIndex = 3;
            this.btn_save1.Text = "Сохранить";
            this.btn_save1.UseVisualStyleBackColor = true;
            this.btn_save1.Click += new System.EventHandler(this.btn_save1_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(41, 140);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(116, 41);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Изменить";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(41, 93);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 41);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(41, 46);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 41);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Новая запись";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.textBox_Condition2);
            this.panel2.Controls.Add(this.textBox_ReleaseDate2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_MadeCountry);
            this.panel2.Controls.Add(this.textBox_ModelAuto);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBox_id3);
            this.panel2.Controls.Add(this.textBox_MarkaAuto);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(59, 464);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 301);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_Condition2
            // 
            this.textBox_Condition2.Location = new System.Drawing.Point(245, 220);
            this.textBox_Condition2.Name = "textBox_Condition2";
            this.textBox_Condition2.Size = new System.Drawing.Size(138, 20);
            this.textBox_Condition2.TabIndex = 16;
            this.textBox_Condition2.TextChanged += new System.EventHandler(this.textBox_Country_TextChanged);
            // 
            // textBox_ReleaseDate2
            // 
            this.textBox_ReleaseDate2.Location = new System.Drawing.Point(245, 185);
            this.textBox_ReleaseDate2.MaxLength = 4;
            this.textBox_ReleaseDate2.Name = "textBox_ReleaseDate2";
            this.textBox_ReleaseDate2.Size = new System.Drawing.Size(138, 20);
            this.textBox_ReleaseDate2.TabIndex = 15;
            this.textBox_ReleaseDate2.TextChanged += new System.EventHandler(this.textBox_Pol_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Состояние:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Год выпуска:";
            // 
            // textBox_MadeCountry
            // 
            this.textBox_MadeCountry.Location = new System.Drawing.Point(245, 150);
            this.textBox_MadeCountry.Name = "textBox_MadeCountry";
            this.textBox_MadeCountry.Size = new System.Drawing.Size(138, 20);
            this.textBox_MadeCountry.TabIndex = 11;
            this.textBox_MadeCountry.TextChanged += new System.EventHandler(this.textBox_Otchestvo_TextChanged);
            // 
            // textBox_ModelAuto
            // 
            this.textBox_ModelAuto.Location = new System.Drawing.Point(245, 117);
            this.textBox_ModelAuto.Name = "textBox_ModelAuto";
            this.textBox_ModelAuto.Size = new System.Drawing.Size(138, 20);
            this.textBox_ModelAuto.TabIndex = 10;
            this.textBox_ModelAuto.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Страна Изгтовитель:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Модель Авто:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Код Заявки Поставщика";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBox_id3
            // 
            this.txtBox_id3.Location = new System.Drawing.Point(245, 48);
            this.txtBox_id3.Name = "txtBox_id3";
            this.txtBox_id3.Size = new System.Drawing.Size(138, 20);
            this.txtBox_id3.TabIndex = 6;
            this.txtBox_id3.TextChanged += new System.EventHandler(this.txtBox_id1_TextChanged);
            // 
            // textBox_MarkaAuto
            // 
            this.textBox_MarkaAuto.Location = new System.Drawing.Point(245, 84);
            this.textBox_MarkaAuto.Name = "textBox_MarkaAuto";
            this.textBox_MarkaAuto.Size = new System.Drawing.Size(138, 20);
            this.textBox_MarkaAuto.TabIndex = 4;
            this.textBox_MarkaAuto.TextChanged += new System.EventHandler(this.textBox_Fam_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Марка Авто:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Запись";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(22, 138);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(907, 293);
            this.dataGridView3.TabIndex = 5;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBox_Search);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 121);
            this.panel1.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(507, 47);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(53, 39);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(671, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Поиск:";
            // 
            // txtBox_Search
            // 
            this.txtBox_Search.Location = new System.Drawing.Point(736, 57);
            this.txtBox_Search.Name = "txtBox_Search";
            this.txtBox_Search.Size = new System.Drawing.Size(136, 20);
            this.txtBox_Search.TabIndex = 2;
            this.txtBox_Search.TextChanged += new System.EventHandler(this.txtBox_Search_TextChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(603, 47);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(53, 39);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заявка поставщику";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ApplicationSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 808);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.panel1);
            this.Name = "ApplicationSupplier";
            this.Text = "ApplicationSupplier";
            this.Load += new System.EventHandler(this.ApplicationSupplier_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Condition2;
        private System.Windows.Forms.TextBox textBox_ReleaseDate2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_MadeCountry;
        private System.Windows.Forms.TextBox textBox_ModelAuto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_id3;
        private System.Windows.Forms.TextBox textBox_MarkaAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label1;
    }
}