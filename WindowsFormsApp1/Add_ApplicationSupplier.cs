using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_ApplicationSupplier : Form
    {
        DataBase database = new DataBase();

        public Add_ApplicationSupplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var markaAuto = textBox_MarkaAuto.Text;
            var idManager = textBox_idMenager.Text;
            var modelAuto = textBox_ModelAuto.Text;
            var madeCountry = textBox_MadeCountry.Text;
            var releaseDate2 = textBox_ReleaseDate2.Text;
            var condition2 = textBox_Condition2.Text;

            var addQuery = $"insert into RequestSupplier (КодМенеджера, МаркаАвто, МодельАвто, СтранаИзготовитель, ГодВыпуска, Состояние) values ('{idManager}','{markaAuto}', '{modelAuto}', '{madeCountry}', '{releaseDate2}', '{condition2}')";

            var command = new SqlCommand(addQuery, database.getConnection());

            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
