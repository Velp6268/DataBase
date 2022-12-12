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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    enum RowState3
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }


    public partial class ApplicationSupplier : Form
    {

        DataBase database = new DataBase();

        int selectedRow;

        public ApplicationSupplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView3.Columns.Add("КодЗаявкаПоставщику", "КодЗаявкаПоставщику");
            dataGridView3.Columns.Add("КодМенеджера", "КодМенеджера");
            dataGridView3.Columns.Add("МаркаАвто", "МаркаАвто");
            dataGridView3.Columns.Add("МодельАвто", "МодельАвто");
            dataGridView3.Columns.Add("СтранаИзготовитель", "СтранаИзготовитель");
            dataGridView3.Columns.Add("ГодВыпуска", "ГодВыпуска");
            dataGridView3.Columns.Add("Состояние", "Состояние");
            dataGridView3.Columns.Add("IsNew", String.Empty);

        }

        private void ClearFields()
        {
            txtBox_id3.Text = "";
            textBox_MarkaAuto.Text = "";
            textBox_ModelAuto.Text = "";
            textBox_MadeCountry.Text = "";
            textBox_ReleaseDate2.Text = "";
            textBox_Condition2.Text = "";
           
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from [RequestSupplier]";

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
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                txtBox_id3.Text = row.Cells[0].Value.ToString();
                textBox_MarkaAuto.Text = row.Cells[1].Value.ToString();
                textBox_ModelAuto.Text = row.Cells[2].Value.ToString();
                textBox_MadeCountry.Text = row.Cells[3].Value.ToString();
                textBox_ReleaseDate2.Text = row.Cells[4].Value.ToString();
                textBox_Condition2.Text = row.Cells[5].Value.ToString();
                

            }
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from RequestSupplier where concat (КодЗаявкаПоставщику, КодМенеджера, МаркаАвто, МодельАвто, СтранаИзготовитель, ГодВыпуска, Состояние) like '%" + txtBox_Search.Text + "%'";

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
            int index = dataGridView3.CurrentCell.RowIndex;

            dataGridView3.Rows[index].Visible = false;

            if (dataGridView3.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView3.Rows[index].Cells[7].Value = RowState.Deleted;

                return;
            }

            dataGridView3.Rows[index].Cells[7].Value = RowState.Deleted;


        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView3.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from RequestSupplier where КодЗаявкаПоставщику = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id3 = dataGridView3.Rows[index].Cells[0].Value.ToString();
                    var idManager = dataGridView3.Rows[index].Cells[1].Value.ToString();
                    var markaAuto = dataGridView3.Rows[index].Cells[2].Value.ToString();
                    var modelAuto = dataGridView3.Rows[index].Cells[3].Value.ToString();
                    var madeCountry = dataGridView3.Rows[index].Cells[4].Value.ToString();
                    var releaseDate2 = dataGridView3.Rows[index].Cells[5].Value.ToString();
                    var condition2 = dataGridView3.Rows[index].Cells[6].Value.ToString();
                   

                    var changeQuery = $"update RequestSupplier set КодМенеджера = '{idManager}', МаркаАвто = '{markaAuto}', МодельАвто = '{modelAuto}', СтранаИзготовитель = '{madeCountry}', ГодВыпуска = '{releaseDate2}', Состояние = '{condition2}' where КодЗаявкаПоставщику = '{id3}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }

            database.closeConnection();
        }


        private void Change()
        {
            var selectedRowIndex = dataGridView3.CurrentCell.RowIndex;

            var id3 = txtBox_id3.Text;
            var markaAuto = textBox_MarkaAuto.Text;
            var modelAuto = textBox_ModelAuto.Text;
            var madeCountry = textBox_MadeCountry.Text;
            var releaseDate2 = textBox_ReleaseDate2.Text;
            var condition2 = textBox_Condition2.Text;


            if (dataGridView3.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
               
                
                    dataGridView3.Rows[selectedRowIndex].SetValues(id3, markaAuto, modelAuto, madeCountry, releaseDate2, condition2);
                    dataGridView3.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                
               
            }

        }


        private void ApplicationSupplier_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView3);
        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Country_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Pol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Otchestvo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Fam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView3);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView3);
            ClearFields();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_ApplicationSupplier addfrm = new Add_ApplicationSupplier();
            addfrm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ClearFields();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_idMenager_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
