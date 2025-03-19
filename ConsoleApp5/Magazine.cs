using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Magazine : Press
    {
        private string quality;

        public string Quality
        {
            get => quality;
            set
            {
                if (value == "высокое" || value == "среднее" || value == "низкое")
                quality = value;
            else
                    quality = "среднее";
            }
        }

        public Magazine(string name, int copies, double price, string quality)
            : base(name, copies, price)
        {
            Quality = quality;
        }

        public new double Cost()
        {
            double baseCost = base.Cost();
            if (Quality == "высокое") return baseCost * 1.1;
            if (Quality == "низкое") return baseCost * 0.9;
            return baseCost;
        }

        public new void Output()
        {
            Console.WriteLine($"Журнал: {Name}, Тираж: {Copies}, Цена за экземпляр: {Price:F2}," +
                $" Качество бумаги: {Quality}, Итоговая стоимость тиража: {Cost():F2}");
        }
    }
}
