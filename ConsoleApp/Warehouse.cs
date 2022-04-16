using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Warehouse
    {
        private string[] product;
        private int station;
        public void init(string[] product, int station)
        {
            this.product = product;
            this.station = station;
        }
        public string[] Product { get; set; }

        public int Station
        {
            set
            {
                if (value < 1)
                    Console.WriteLine("Число меньше 1.");
                else
                    station = value;
            }
            get { return station; }
        }

        public void enter()
        {
            Console.Write("Введите товар:");
            product = Console.ReadLine().Split(' ');
            Console.Write("Введите кол-во пунктов приема: ");
            station = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine($"Склад:\nТовар:");
            foreach (string element in product)
                Console.Write($"{element} ");
            Console.WriteLine($"\nКол-во пунктов приема: {station}");
        }

        public int cloakWarehouse(int x)
        {
            int i = 0;
            int time = 0;
            while (i < x)
            {
                time += 15;
                i += station;
            }
            return time;
        }

        public void Poisk(string str)
        {
            foreach (string element in product)
            {
                if(string.Compare(element, str) == 0)
                {
                    Console.WriteLine($"{str} есть на складе.");
                    return;
                }
            }
            Console.WriteLine($"{str} нет на складе.");
        }
    }
}
