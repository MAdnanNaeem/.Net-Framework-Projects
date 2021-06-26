using Banking_System.BL;
using Banking_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System.GUI
{
    public partial class Login : Form
    {
        ClientDTO clientDTO;
        ClientBL clientBL;
        public static DataTable dt;
        public Login()
        {
            InitializeComponent();
            clientDTO = new ClientDTO();
            clientBL = new ClientBL();
        }

        private void btn_login_Click(object sender, EventArgs e)
        { 
            
             if( txt_name.Text != "" && txt_password.Text != "")
            {
                clientDTO.AccountNo = txt_name.Text;
                clientDTO.ClientPassword = txt_password.Text;
                clientBL.LoginBL(clientDTO);
                DataTable data = dt;
                if(dt != null)
                {
                    Form1.dataTable = dt;
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    this.Show();
                    
                }
                

            }
             else
            {
                MessageBox.Show("Fill the required fields !");  
            }



        }
    }
}
