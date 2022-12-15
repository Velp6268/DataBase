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
    enum RowState4
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }
    public partial class RequestCarSupplier : Form
    {
        DataBase database = new DataBase();

        int selectedRow;


        public RequestCarSupplier()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView4.Columns.Add("КодЗаявкаПерегонщику", "КодЗаявкаПерегонщику");
            dataGridView4.Columns.Add("КодМенеджера", "КодМенеджера");
            dataGridView4.Columns.Add("МаркаАвто", "МаркаАвто");
            dataGridView4.Columns.Add("МодельАвто", "МодельАвто");
            dataGridView4.Columns.Add("ГодВыпуска", "ГодВыпуска");
            dataGridView4.Columns.Add("IsNew", String.Empty);

        }

        private void ClearFields()
        {
            txtBox_idManager.Text = "";
            textBox_MarkaAuto.Text = "";
            textBox_ModelAuto.Text = ""; 
            textBox_ReleaseDate2.Text = "";

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3),record.GetString(4), RowState.ModifiedNew);
        }



        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from [RequestCarDriver]";

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
                DataGridViewRow row = dataGridView4.Rows[selectedRow];

                txtBox_idManager.Text = row.Cells[0].Value.ToString();
                textBox_MarkaAuto.Text = row.Cells[1].Value.ToString();
                textBox_ModelAuto.Text = row.Cells[2].Value.ToString();
                textBox_ReleaseDate2.Text = row.Cells[3].Value.ToString();

            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from RequestCarDriver where concat (КодЗаявкаПерегонщику, КодМенеджера, МаркаАвто, МодельАвто, ГодВыпуска) like '%" + txtBox_Search.Text + "%'";

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
            int index = dataGridView4.CurrentCell.RowIndex;

            dataGridView4.Rows[index].Visible = false;

            if (dataGridView4.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView4.Rows[index].Cells[5].Value = RowState.Deleted;

                return;
            }

            dataGridView4.Rows[index].Cells[5].Value = RowState.Deleted;

        }


        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView4.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView4.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from RequestCarDriver where КодЗаявкаПерегонщику = {id}";

                    var command = new SqlCommand(deleteQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var idCarDriver = dataGridView4.Rows[index].Cells[0].Value.ToString();
                    var idManager = dataGridView4.Rows[index].Cells[1].Value.ToString();
                    var markaAuto = dataGridView4.Rows[index].Cells[2].Value.ToString();
                    var modelAuto = dataGridView4.Rows[index].Cells[3].Value.ToString();
                    var releaseDate2 = dataGridView4.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update RequestCarDriver set КодМенеджера = '{idManager}', МаркаАвто = '{markaAuto}', МодельАвто = '{modelAuto}', ГодВыпуска = '{releaseDate2}' where КодЗаявкаПерегонщику = '{idCarDriver}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());
                    command.ExecuteNonQuery();
                }

            }

            database.closeConnection();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView4.CurrentCell.RowIndex;

            var idManager = txtBox_idManager.Text;
            var markaAuto = textBox_MarkaAuto.Text;
            var modelAuto = textBox_ModelAuto.Text;
            var releaseDate2 = textBox_ReleaseDate2.Text;



            if (dataGridView4.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {


                dataGridView4.Rows[selectedRowIndex].SetValues(idManager, markaAuto, modelAuto, releaseDate2);
                dataGridView4.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;


            }

        }

        private void RequestCarSupplier_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView4);
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView4);
            ClearFields();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_RequestCarSupplier addfrm = new Add_RequestCarSupplier();
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

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView4);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }

      
    
}
