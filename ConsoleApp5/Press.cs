using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Press
    {
        private int copies;
        private string name;
        private double price;

        public int Copies { get => copies; set => copies = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public Press(string name, int copies, double price)
        {
            Name = name;
            Copies = copies;
            Price = price;
        }

        public double Cost()
        {
            return Copies * Price;
        }

        public void Output()
        {
            Console.WriteLine($"Издание: {Name}, Тираж: {Copies}," +
                $" Цена за экземпляр: {Price}, Стоимость тиража: {Cost():F2}");
        }
    }
}
