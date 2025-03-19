using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Bus
    {
        private string mark;
        private int seats;
        private int price;

        public string Mark { get => mark; set => mark = value; }
        public int Seats { get => seats; set => seats = value; }
        public int Price { get => price; set => price = value; }

        public Bus()
        {
        }
        public Bus(string mark, int seats, int price)
        {
            this.Mark = mark;
            this.Seats = seats;
            this.Price = price;
        }

        public virtual int TotalCost()
        {
            return seats * price;
        }

        public virtual void Info()
        {
            Console.WriteLine($"Марка: {mark}, Мест: {seats}, Цена билета: {price}, Общая стоимость: {TotalCost()}");
        }
    }
}
