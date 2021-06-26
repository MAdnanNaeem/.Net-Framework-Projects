using Banking_System.DL;
using Banking_System.DTO;
using Banking_System.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System.BL
{
   public class ClientBL
    {
        ClientDL clientDL;

       public ClientBL()
        {
            clientDL = new ClientDL();
        }

      
        public void getClientDataBL(ClientDTO clientDTO)
        {

            try
            {
                DataTable resource = clientDL.GetClientDataDL(clientDTO);
                if(resource != null)
                {

                    Login.dt = resource;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show( " Failed " + ex.Message );
            }
        }


        public ClientDTO LoginBL(ClientDTO clientDTO)
        {

            try
            {
                ClientDTO   dTO =  clientDL.LoginDL(clientDTO);

                if(dTO != null)
                {

                   getClientDataBL(dTO);

                }
                else
                {
                    MessageBox.Show("Wrong Credentials");
                   
                }
    

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return null;
        }

        
    }
}
