using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SectionC_1._14Sub
{
    
    


class Program
    {
        static void Main(string[] args)
        {
            
            
            string s=Directory.GetCurrentDirectory();
            Console.WriteLine(s);
            try
                {
                string filePath = s+ "\\Student_data.txt";
                

                FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);

                StreamReader sr = new StreamReader(fs);
                    string data = sr.ReadToEnd();
                    Console.WriteLine(data);

               
            




            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            Console.ReadLine();
        }
    }

}
