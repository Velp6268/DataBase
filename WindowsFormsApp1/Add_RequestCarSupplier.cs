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
    public partial class Add_RequestCarSupplier : Form
    {
        DataBase database = new DataBase();

        public Add_RequestCarSupplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var idManager = txtBox_idManager3.Text;
            var markaAuto = textBox_MarkaAuto.Text;
            var modelAuto = textBox_ModelAuto.Text;
            var releaseDate2 = textBox_ReleaseDate2.Text;
            

            var addQuery = $"insert into RequestCarDriver (КодМенеджера, МаркаАвто, МодельАвто, ГодВыпуска) values ('{idManager}','{markaAuto}', '{modelAuto}', '{releaseDate2}')";

            var command = new SqlCommand(addQuery, database.getConnection());

            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }
    }
}
