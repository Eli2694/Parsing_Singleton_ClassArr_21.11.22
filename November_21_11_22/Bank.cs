using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_21_11_22
{
    internal class Bank
    {
        //שם בנק, מספר סניף, קוד בנק, רחוב,עיר, טלפון.
        //------------------
        private string bank_name;
        public string Bank_name { get { return bank_name; } set { bank_name = value; } }
        //------------------
        private string bank_branch;
        public string Bank_branch { get { return bank_branch; } }
        //------------------
        public readonly string bank_code;
        public string Bank_code { get { return bank_code; } }
        //------------------
        private string address;
        public string Address { get { return address; } set { address = value; } }
        //------------------
        private string city;
        public string City { get { return city; } set { city = value; } }
        //------------------
        private string phone;
        public string Phone { get { return phone; } set { phone = value; } }

        // Constructor
        public Bank(string _bankCode , string _bankBranc )
        {
            bank_branch = _bankBranc;
            bank_code = _bankCode;
        }
          
        
    }
}
