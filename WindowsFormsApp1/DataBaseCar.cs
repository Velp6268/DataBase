using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    enum RowState2
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }


    public partial class DataBaseCar : Form
    {

        DataBase database = new DataBase();

        int selectedRow;

        private void CreateColumns()
        {
            dataGridView2.Columns.Add("КодАвто", "КодАвто");
            dataGridView2.Columns.Add("Марка", "Марка");
            dataGridView2.Columns.Add("Страна", "Страна");
            dataGridView2.Columns.Add("Год_Выпуска", "Год_Выпуска");
            dataGridView2.Columns.Add("Техничесие_характеристики", "Техничесие_характеристики");
            dataGridView2.Columns.Add("Особенности_исполнения", "Особенности_исполнения");
            dataGridView2.Columns.Add("Техническое_состояние", "Техническое_состояние");
            dataGridView2.Columns.Add("Цена", "Цена");
            dataGridView2.Columns.Add("IsNew", String.Empty);

        }


        private void ClearFields()
        {
            txtBox_id1.Text = "";
            textBox_Marka.Text = "";
            textBox_Cntry.Text = "";
            textBox_YearRelease.Text = "";
            textBox_TehHaracteristics.Text = "";
            textBox_Peculiarities.Text = "";
            textBox_TechnicalCondition.Text = "";
            textBox_Price.Text = "";
        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), record.GetDecimal(7), RowState2.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from [Cars]";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                txtBox_id1.Text = row.Cells[0].Value.ToString();
                textBox_Marka.Text = row.Cells[1].Value.ToString();
                textBox_Cntry.Text = row.Cells[2].Value.ToString();
                textBox_YearRelease.Text = row.Cells[3].Value.ToString();
                textBox_TehHaracteristics.Text = row.Cells[4].Value.ToString();
                textBox_Peculiarities.Text = row.Cells[5].Value.ToString();
                textBox_TechnicalCondition.Text = row.Cells[6].Value.ToString();
                textBox_Price.Text = row.Cells[7].Value.ToString();

            }
        }


        private void DataBaseCar_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from Cars where concat (КодАвто, Марка, Страна, Год_Выпуска, ТехническиеХарактеристики, ОсобенностиИсполнения, ТехническоеСостояние, Цена) like '%" + txtBox_Search.Text + "%'";

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
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[8].Value = RowState.Deleted;

                return;
            }

            dataGridView2.Rows[index].Cells[8].Value = RowState.Deleted;


        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Cars where КодАвто = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var marka = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var country = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var release = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var haracteristics = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var peculiarities = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    var condition = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    var price = dataGridView2.Rows[index].Cells[7].Value.ToString();

                    var changeQuery = $"update Cars set Марка = '{marka}', Страна = '{country}', Год_Выпуска = '{release}', ТехническиеХарактеристики = '{haracteristics}', ОсобенностиИсполнения = '{peculiarities}', ТехническоеСостояние = '{condition}', Цена = '{price}' where КодАвто = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }

            database.closeConnection();
        }


        private void txtBox_Search_TextChanged_1(object sender, EventArgs e)
        {
            Search(dataGridView2);
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
            RefreshDataGrid(dataGridView2);
            ClearFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Car addcarform = new Add_Car();
            addcarform.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click_1(object sender, EventArgs e)
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
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;


            var id = txtBox_id1.Text;
            var marka = textBox_Marka.Text;
            var country = textBox_Cntry.Text;
            var release = textBox_YearRelease.Text;
            var haracteristics = textBox_TehHaracteristics.Text;
            var peculiarities = textBox_Peculiarities.Text;
            var condition = textBox_TechnicalCondition.Text;
            decimal price;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_Price.Text, out price))
                {
                    dataGridView2.Rows[selectedRowIndex].SetValues(id, marka, country, release, haracteristics, peculiarities, condition, price);
                    dataGridView2.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Цена должена иметь числовой формат!");
                }
            }

        }

        private void btn_Change_Click_1(object sender, EventArgs e)
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


        
        public DataBaseCar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBox_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataBaseCar_Load_1(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        private void btn_Clear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
