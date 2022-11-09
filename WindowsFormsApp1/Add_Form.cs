using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Add_Form : Form
    {

        DataBase database = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            database.openConnection();

            var fam = textBox_Fam1.Text;
            var name = textBox_Name1.Text;
            var otchestvo = textBox_Otchestvo1.Text;
            var pol = textBox_Pol1.Text;
            var country = textBox_Country1.Text;
            var city = textBox_City1.Text;
            decimal number;


            if(decimal.TryParse(textBox_Number1.Text, out number))
            {

            
                var addQuery = $"insert into Clients (Фамилия, Имя, Отчество, Пол, Страна, Город, Номер_Телефона) values ('{fam}', '{name}', '{otchestvo}', '{pol}', '{country}', '{city}', '{number}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Телефон должен содержать числовой формат!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            database.closeConnection();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_FIO2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
