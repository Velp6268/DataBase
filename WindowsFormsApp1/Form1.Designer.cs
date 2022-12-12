namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_Search = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.textBox_Pol = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Otchestvo = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_id1 = new System.Windows.Forms.TextBox();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.textBox_Fam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save1 = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBox_Search);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 121);
            this.panel1.TabIndex = 0;
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список Клиентов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(907, 293);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.textBox_City);
            this.panel2.Controls.Add(this.textBox_Country);
            this.panel2.Controls.Add(this.textBox_Pol);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_Otchestvo);
            this.panel2.Controls.Add(this.textBox_Name);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBox_id1);
            this.panel2.Controls.Add(this.textBox_Number);
            this.panel2.Controls.Add(this.textBox_Fam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(36, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 335);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(148, 258);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(138, 20);
            this.textBox_City.TabIndex = 17;
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(148, 225);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(138, 20);
            this.textBox_Country.TabIndex = 16;
            // 
            // textBox_Pol
            // 
            this.textBox_Pol.Location = new System.Drawing.Point(148, 190);
            this.textBox_Pol.Name = "textBox_Pol";
            this.textBox_Pol.Size = new System.Drawing.Size(138, 20);
            this.textBox_Pol.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Город:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Страна:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Пол:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox_Otchestvo
            // 
            this.textBox_Otchestvo.Location = new System.Drawing.Point(148, 155);
            this.textBox_Otchestvo.Name = "textBox_Otchestvo";
            this.textBox_Otchestvo.Size = new System.Drawing.Size(138, 20);
            this.textBox_Otchestvo.TabIndex = 11;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(148, 122);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(138, 20);
            this.textBox_Name.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Отчество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Код Клиента";
            // 
            // txtBox_id1
            // 
            this.txtBox_id1.Location = new System.Drawing.Point(148, 57);
            this.txtBox_id1.Name = "txtBox_id1";
            this.txtBox_id1.Size = new System.Drawing.Size(138, 20);
            this.txtBox_id1.TabIndex = 6;
            this.txtBox_id1.TextChanged += new System.EventHandler(this.txtBox_id1_TextChanged);
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(148, 290);
            this.textBox_Number.MaxLength = 11;
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(138, 20);
            this.textBox_Number.TabIndex = 5;
            // 
            // textBox_Fam
            // 
            this.textBox_Fam.Location = new System.Drawing.Point(148, 89);
            this.textBox_Fam.Name = "textBox_Fam";
            this.textBox_Fam.Size = new System.Drawing.Size(138, 20);
            this.textBox_Fam.TabIndex = 4;
            this.textBox_Fam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Номер Телефона:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Фамилия:";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btn_save1);
            this.panel3.Controls.Add(this.btn_Change);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Location = new System.Drawing.Point(602, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(204, 276);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Управление записими";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 992);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.TextBox textBox_Fam;
        private System.Windows.Forms.Button btn_save1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_Search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_id1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox textBox_Otchestvo;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.TextBox textBox_Pol;
    }
}

