using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bus> busList = new List<Bus>();
            int price = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Введите марку {i + 1} автобуса: ");
                string mark = Console.ReadLine();
                Console.Write($"Введите кол-во мест {i + 1}-го автобуса: ");
                int seats = int.Parse(Console.ReadLine());
                Console.Write($"Введите цену билета {i + 1}-го автобуса: ");
                int tprice = int.Parse(Console.ReadLine());
                busList.Add(new Bus(mark, seats, tprice));
            }
            foreach (var busn in busList)
            {
                busn.Info();
            }
            foreach (var bus2 in busList)
            {
                price += bus2.TotalCost();
            }
            Console.WriteLine($"Стоимость всех билетов: {price} руб");
            Console.WriteLine();

            for (int i = 0; i < busList.Count; i++)
            {
                Console.Write($"Введите стоимость экскурсии для автобуса {i + 1}: ");
                int excursionCost = int.Parse(Console.ReadLine());
            }

            // Выводим информацию о туристических автобусах
            Console.WriteLine("\nТуристические автобусы (с экскурсиями):");
            foreach (var bus in busList)
            {
                bus.Info();
            }

            // Считаем общую стоимость с экскурсиями
            int touristPrice = 0;
            foreach (var bus in busList)
            {
                touristPrice += bus.TotalCost();
            }
            Console.WriteLine($"Стоимость всех билетов с экскурсиями: {touristPrice} руб");
            Console.ReadLine();
        }
    }
}
