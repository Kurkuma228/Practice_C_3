using ДзC_.classes;

namespace homework
{
    class Metodichka1
    {
        static void Main()
        {
            //Упражнение 13.1
            Console.WriteLine("Упражнение 13.1 - 13.2");
            Task1();

            //Домашнее задание 13.1
            Console.WriteLine("Домашнее задание 13.1 - 13.2");
            Task2();
        }

        /*Упражнение 13.1 Из класса банковский счет удалить методы, возвращающие значения
        полей номер счета и тип счета, заменить эти методы на свойства только для чтения.
        Добавить свойство для чтения и записи типа string для отображения поля держатель
        банковского счета. Изменить класс BankTransaction, созданный для хранений финансовых
        операций со счетом, - заменить методы доступа к данным на свойства для чтения.*/

        /*Упражнение 13.2 Добавить индексатор в класс банковский счет для получения доступа к
        любому объекту BankTransaction.*/
        static void Task1()
        {
            Console.WriteLine();
            BankAccount bankAcc1 = new BankAccount("Алексей", 213124, AccountType.Сберегательный);

            Console.WriteLine("До изменений:");
            bankAcc1.PrintAccBank();

            bankAcc1.accountHolder = "Сергей";
            Console.WriteLine("\nПосле изменений:");
            bankAcc1.PrintAccBank();

            Console.WriteLine($"Номер счета: {bankAcc1.accountNumber}, Тип счета: {bankAcc1.accountType}");
        }

        /*Домашнее задание 13.1 В классе здания из домашнего задания 7.1 все методы для
        заполнения и получения значений полей заменить на свойства. Написать тестовый пример.*/

        /*Домашнее задание 13.2 Создать класс для нескольких зданий. Поле класса – массив на 10
        зданий. В классе создать индексатор, возвращающий здание по его номеру.*/
        static void Task2()
        {
            try
            {
                Building building = new Building();
                building.GenUniqiueNum();

                Console.WriteLine("Введите высоту здания");
                building.heightbuilding = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество этажей в здании");
                building.floorsamount = byte.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество квартир в здании");
                building.apartsamount = byte.Parse(Console.ReadLine());

                Console.WriteLine("Введите количество подъездов в здании");
                building.entranceamount = byte.Parse(Console.ReadLine());
                building.Print();

                Buildings buildings = new Buildings();
                buildings.SetBuildings();

                Console.WriteLine("Введите номер здания от 0 до 9 включительно");
                buildings[byte.Parse(Console.ReadLine())].Print();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}