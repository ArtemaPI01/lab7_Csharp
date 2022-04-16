using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FIO fio = new FIO();
            fio.init("A", "Б", "В");
            Owner Alisher = new Owner();
            Alisher.init(fio, 0, 0);
            Alisher.enter();
            Alisher.print();
            int N = 2;
            Shop[] shop = new Shop[N];
            for (int i = 0; i < N; i++)
            {
                shop[i] = new Shop();
                shop[i].enter();
                shop[i].print();
                shop[i].cloakShop();
            }
            Warehouse home = new Warehouse();
            home.enter();
            home.print();
            home.Poisk("AVS");
            int a = 20;
            Console.WriteLine($"Время разгрузки {a} тонн товара: {home.cloakWarehouse(a)} минут");
            Boxoffice box = new Boxoffice();
            box.init(fio, 10, 10);
            Console.WriteLine($"Кол-во рабочих: {box.Workers}");
            box.Workers = 20;
            box.print();
            box.cloakBoxoffice(100);
        }
    }
}