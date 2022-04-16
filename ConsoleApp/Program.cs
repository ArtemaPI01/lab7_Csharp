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
            Shop shop = new Shop();
            shop.enter();
            shop.print();
            shop.cloakShop();
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
