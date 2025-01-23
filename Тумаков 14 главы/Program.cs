using System;
using System.Reflection;
using Тумаков_14_главы.attributes;
using Тумаков_14_главы.classes;
using Тумаков14.classes;

namespace Тумаков14
{
    class HomeWork
    {
        static void Main()
        {
            Console.WriteLine("Упражнение 14.1");
            Task1();

            Console.WriteLine("Упражнение 14.2");
            Task2();

            Console.WriteLine("Домашнее задание 14.1");
            Task3();
        }
        /*Упражнение 14.1 Использование предопределенного условного атрибута для условного
        выполнения кода (указывает компиляторам, что при отсутствии символа условной
        компиляции, вызов метода или атрибут следует игнорировать). В классе банковский счет
        добавить метод DumpToScreen, который отображает детали банковского счета. Для
        выполнения этого метода использовать условный атрибут, зависящий от символа условной
        компиляции DEBUG_ACCOUNT. Протестировать метод DumpToScreen.*/
        static void Task1()
        {
            BankAccount bankAcc = new BankAccount("Сергей", 123124, AccountType.Сберегательный);
            bankAcc.Withdraw(2131);
            bankAcc.Deposit(2313141241);
            bankAcc.DumpToScreen();
        }
        /*Упражнение 14.2 Создать пользовательский атрибут DeveloperInfoAttribute. Этот атрибут
        позволяет хранить в метаданных класса имя разработчика и, дополнительно, дату
        разработки класса. Атрибут должен позволять многократное использование. Использовать
        этот атрибут для записи имени разработчика класса рациональные числа (упражнение 12.2).*/
        static void Task2()
        {
            Type type = typeof(RationalNums);
            object[] attributes = type.GetCustomAttributes(typeof(DeveloperInfoAttribute), false);
            foreach (DeveloperInfoAttribute attribute in attributes)
            {
                Console.WriteLine($"{attribute.NameDeveloper}, {attribute.TimeDevelope}");
            }
        }
        /*Домашнее задание 14.1 Создать пользовательский атрибут для класса из домашнего
        задания 13.1. Атрибут позволяет хранить в метаданных класса имя разработчика и название
        организации. Протестировать.*/
        static void Task3()
        {
            Type type = typeof(BankAccount);
            object[] attributes = type.GetCustomAttributes(typeof(DeveloperInfoForBankAttribute), false);
            foreach (DeveloperInfoForBankAttribute attribute in attributes)
            {
                Console.WriteLine($"{attribute.DeveloperName}, {attribute.OrganizationName}");
            }
        }
    }
}