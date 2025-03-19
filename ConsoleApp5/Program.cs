using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Press press = new Press("Газета 'Новости'", 900, 7);
            press.Output();

            Magazine magazine = new Magazine("Книга", 500, 34, "высокое");
            magazine.Output();

            Press pressReference = magazine;
            pressReference.Output();
            Console.ReadLine();
        }
    }
}
