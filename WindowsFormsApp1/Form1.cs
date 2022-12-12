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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }

    public partial class Form1 : Form
    {

        DataBase database = new DataBase();

        int selectedRow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void CreateColumns()
        {
            dataGridView1.Columns.Add("КодКлиента", "КодКлиента");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Отчество", "Отчество");
            dataGridView1.Columns.Add("Пол", "Пол");
            dataGridView1.Columns.Add("Страна", "Страна");
            dataGridView1.Columns.Add("Город", "Город");
            dataGridView1.Columns.Add("Номер_Телефона", "Номер_Телефона");
            dataGridView1.Columns.Add("IsNew", String.Empty);
           
        }


        private void ClearFields()
        {
            txtBox_id1.Text = "";
            textBox_Fam.Text = "";
            textBox_Name.Text = "";
            textBox_Otchestvo.Text = "";
            textBox_Pol.Text = "";
            textBox_Country.Text = "";
            textBox_City.Text = "";
            textBox_Number.Text = "";
        }
     

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetDecimal(7), RowState.ModifiedNew);
        }

        private void RefreshDataGrid (DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from [Clients]";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                txtBox_id1.Text = row.Cells[0].Value.ToString();
                textBox_Fam.Text = row.Cells[1].Value.ToString();
                textBox_Name.Text = row.Cells[2].Value.ToString();
                textBox_Otchestvo.Text = row.Cells[3].Value.ToString();
                textBox_Pol.Text = row.Cells[4].Value.ToString();
                textBox_Country.Text = row.Cells[5].Value.ToString();
                textBox_City.Text = row.Cells[6].Value.ToString();
                textBox_Number.Text = row.Cells[7].Value.ToString();

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }


        private void Search (DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Clients where concat (КодКлиента, Фамилия, Имя, Отчество, Пол, Страна, Город, Номер_Телефона) like '%" + txtBox_Search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, database.getConnection());

            database.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();



        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;

                return;
            }

            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;


        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Clients where КодКлиента = {id}";

                    var command  = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var fam = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var otchestvo = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var pol = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var country = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var city = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var number = dataGridView1.Rows[index].Cells[7].Value.ToString();

                    var changeQuery = $"update Clients set Фамилия = '{fam}', Имя = '{name}', Отчество = '{otchestvo}', Пол = '{pol}', Страна = '{country}', Город = '{city}', Номер_Телефона = '{number}' where КодКлиента = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }

            database.closeConnection();
        }


        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            Update();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = txtBox_id1.Text;
            var fam = textBox_Fam.Text;
            var name = textBox_Name.Text;
            var otchestvo = textBox_Otchestvo.Text;
            var pol = textBox_Pol.Text;
            var country = textBox_Country.Text;
            var city = textBox_City.Text;
            decimal number;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(decimal.TryParse(textBox_Number.Text, out number))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, fam, name, otchestvo, pol, country, city, number);
                    dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Телефон должен иметь числовой формат!");
                }
            }

        } 

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBox_id1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
