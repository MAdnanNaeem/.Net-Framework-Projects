using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System.DTO
{
  public  class ClientDTO
    {
        private string _AccountNo;
        private string _ClientPassword;

        public ClientDTO() { }

        public string AccountNo { get => _AccountNo; set => _AccountNo = value; }
        public string ClientPassword { get => _ClientPassword; set => _ClientPassword = value; }
    }
}
