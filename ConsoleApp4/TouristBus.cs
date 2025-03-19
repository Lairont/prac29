using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class TouristBus : Bus
    {
        private int excursionCost;
        public int ExcursionCost { get => excursionCost; set => excursionCost = value; }
        public TouristBus() {}
        public TouristBus(string mark, int seats, int price, int excursionCost) : base(mark, seats, price)
            
        {
            this.ExcursionCost = excursionCost;
        }

        public override int TotalCost()
        {
            return Seats * (Price + excursionCost);
        }

        public override void Info()
        {
            base.Info();
            Console.WriteLine($" Стоимость экскурсии: {TotalCost()}");
        }
    }
}
