using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Owner
    {
        FIO fio;
        private int income;
        private int expenses;
        public void init(FIO fio, int income, int expenses)
        {
            this.fio = fio;
            this.income = income;
            this.expenses = expenses;
        }
        public void enter()
        {
            Console.Write("Введите ФИО владельца:\n");
            fio.enter();
            Console.Write("Введите доходы: ");
            income = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите расходы: ");
            expenses = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine("\nИнформация о владельце:\n");
            fio.print();
            Console.WriteLine($"Доходы: {income}  Расходы: {expenses} Прибыль: {profitOwner()}");
        }
        public int profitOwner()
        {
            return income - expenses;
        }
    }
}