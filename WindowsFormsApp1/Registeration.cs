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
    public partial class Registeration : Form
    {



        DataBase dataBase = new DataBase();
        public Registeration()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (Сheckгser())

            {
                return;
            }
            var login = textBox1.Text;
            var password = textBox2.Text;
            string quer = $"insert into register(login, password) values('{login}', '{password}')";
            SqlCommand command = new SqlCommand(quer, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");
                Authorization RegSuccessfully = new Authorization();
                this.Hide();
                RegSuccessfully.ShowDialog();

            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            dataBase.closeConnection();


        }
        private Boolean Сheckгser()
        {
            var login = textBox1.Text;
            var password = textBox2.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            string quertString = $"select  login, password from register where login = '{login}' and password = '{password}'";
            SqlCommand command = new SqlCommand(quertString, dataBase.getConnection());
            adapter.SelectCommand = command;

            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
            {
                return false;
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registeration_Load(object sender, EventArgs e)
        {

        }

       
    }
}
