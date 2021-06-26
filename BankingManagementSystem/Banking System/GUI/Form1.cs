using Banking_System.BL;
using Banking_System.DTO;
using Banking_System.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class Form1 : Form
    {
        ClientBL clientBL;
       public static DataTable dataTable;
       
        public Form1()
        {
            InitializeComponent();
            clientBL = new ClientBL();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            clientGrid.DataSource = dataTable;

            DataColumn dcRowString = dataTable.Columns.Add("_RowString", typeof(string));
            foreach (DataRow dataRow in dataTable.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dataTable.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i].ToString());
                    sb.Append(",");
                }
                dataRow[dcRowString] = sb.ToString();
            }

            clientGrid.Columns["_RowString"].Visible = false;
        }

     
        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
             dataTable.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", txt_search.Text);
        }
    }
}
