using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_Car : Form
    {

        DataBase database = new DataBase();

        public Add_Car()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var marka = textBox_Marka.Text;
            var country = textBox_Cntry.Text;
            var release = textBox_YearRelease.Text;
            var haracteristics = textBox_TehHaracteristics.Text;
            var peculiarities = textBox_Peculiarities.Text;
            var condition = textBox_TechnicalCondition.Text;
            decimal price;


            if (decimal.TryParse(textBox_Price.Text, out price))
            {


                var addQuery = $"insert into Cars (Марка, Страна, Год_Выпуска, ТехническиеХарактеристики, ОсобенностиИсполнения, ТехническоеСостояние, Цена) values ('{marka}', '{country}', '{release}', '{haracteristics}', '{peculiarities}', '{condition}', '{price}')";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Цена должена содержать числовой формат!!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





            database.closeConnection();
        }
    }
}
