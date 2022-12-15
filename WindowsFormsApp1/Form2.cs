using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        DataBase dataBase = new DataBase();

        private void button1_Click(object sender, EventArgs e) //Clients
        {
                
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Hide();
                this.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                DataBaseCar form2 = new DataBaseCar();
                form2.ShowDialog();
                this.Hide();
                this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicationSupplier form3 = new ApplicationSupplier();
            form3.ShowDialog();
            this.Hide();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RequestCarSupplier form4 = new RequestCarSupplier();
            form4.ShowDialog();
            this.Hide();
            this.Show();
        }
    }
}


