using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Boxoffice
    {
        FIO fio;
        private int workers;
        private int count;
        public void init(FIO fio, int workers, int count)
        {
            this.fio = fio;
            this.workers = workers;
            this.count = count;
        }
        public void enter()
        {
            Console.Write("Введите ФИО старшего кассира:\n");
            fio.enter();
            Console.Write("Введите кол-во кассиров: ");
            workers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во касс: ");
            count = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine("\nИнформация о кассе:\nФИО старшего кассира:");
            fio.print();
            Console.WriteLine($"Кассиры: {workers}  Кассы: {count}");
        }
        public void cloakBoxoffice(int x)
        {
            int a;
            if (count - workers < 0)
                a = (x / count) * 2;
            else
                a = (x / workers) * 2;
            Console.WriteLine($"\nВремя обслуживания {x} клиентов - {a} минут.\n");
        }
    }
}
