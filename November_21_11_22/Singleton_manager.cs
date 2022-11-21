using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace November_21_11_22
{
    internal class Singleton_manager
    {
        // variable
        static Singleton_manager instance;

        // Constructor 
        protected Singleton_manager()
        {

        }
        // Function Of Creating Singleton Object
        public static Singleton_manager Instance()
        {
            if(instance == null)
            {
                instance = new Singleton_manager(); 
            }
            return instance;    
        }
        //Function to get number of lines in text file
        public int getNumOfLinesInFile(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine(); // titles
            int cLines = 0;
            while(sr.ReadLine() is string s)
            {
                cLines++;
            }
            sr.Close();
            return cLines;
        }
        // Function - Create Array of Banks
        public Bank[] createBankArr(string filePath , int numOfBanks)
        {
            Bank[] banks_arr = new Bank[numOfBanks];
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine(); // titles

            for (int i = 0; i < numOfBanks; i++)
            {
                line = sr.ReadLine(); // titles
                string[] str = line.Split(',');
                banks_arr[i] = new Bank(str[0], str[2]);
                banks_arr[i].Bank_name = str[1];
                banks_arr[i].Address = str[4];
                banks_arr[i].City = str[5];
                banks_arr[i].Phone = str[8];    

            }
            
            return banks_arr;   
        }

        // Function - Return Bank by bank_code and bank_branch

        public Bank searchBank(string bank_code, string bank_branch , Bank[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Bank_code.Equals(bank_code) && arr[i].Bank_branch.Equals(bank_branch))
                {
                    return arr[i];  
                }
            }

            return null;    
        }



    }
}
