using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Cesar Roncancio
//CISS201
//Agile Development
//10/4/2020
namespace dropbox08
{
    class Program
    {
        static void Main(string[] args)
        {
            //create student
            CollegeStudent student = new CollegeStudent("Cesar", 80, 70, 90);
            //display the data
            Console.WriteLine(student);
            Console.ReadKey();
        }
    }
}
