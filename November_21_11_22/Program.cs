using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_21_11_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathSnifimFile = "snifim.txt";

            Singleton_manager s1 = Singleton_manager.Instance();
            int num_of_lines = s1.getNumOfLinesInFile(pathSnifimFile);
            Bank[] bank_array = s1.createBankArr(pathSnifimFile, num_of_lines);
            Bank findMatch = s1.searchBank(bank_array[8].Bank_code, bank_array[8].Bank_branch, bank_array);

            Console.ReadLine(); 
            
        }
    }
}
