using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReadWriteUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to a file.
            using (StreamWriter sw = new StreamWriter("D://phase1project.txt"))
            {
                sw.Write("Rainbow School Teacher Data......");
                sw.WriteLine("\n");

                sw.WriteLine("ID    Name        Class_and_Section");
                sw.WriteLine("1     Vijaya      12A");
                sw.WriteLine("2     Latha       12B");
                sw.WriteLine("3     Esaki       11A");
                sw.WriteLine("4     Durai       10A");
                sw.WriteLine("5     Lakshmi     9A");
                sw.WriteLine("6     Subhasri    9C");
                         
                sw.Close();
            }

            // Read from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("D://phase1project.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            //Updating the file
            String s1 = File.ReadAllText("D://phase1project.txt");
            s1 = s1.Replace("ID","Id");
            File.WriteAllText("D://phase1project.txt", s1);

        }
    }
}
