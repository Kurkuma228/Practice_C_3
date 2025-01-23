using System.Diagnostics;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using Тумаков_14_главы.attributes;
namespace Тумаков14.classes
{
    [DeveloperInfoForBank("Камиль", "Программистики")]
    internal class BankAccount
    {
        static Guid accNumber;
        decimal balance;
        AccountType accType;
        Queue<BankTransaction> queue;
        string accHolder;

        public BankAccount(decimal balance)
        {
            this.balance = balance;
            accNumber = GenAccountNumber();
            queue = new Queue<BankTransaction>();
        }
        public BankAccount(AccountType accountType)
        {
            accType = accountType;
            accNumber = GenAccountNumber();
            queue = new Queue<BankTransaction>();
        }
        public BankAccount(string accholder, decimal balance, AccountType accountType)
        {
            this.balance = balance;
            accType = accountType;
            accNumber = GenAccountNumber();
            queue = new Queue<BankTransaction>();
            accHolder = accholder;
        }
        public string accountHolder
        {
            get { return accHolder; }
            set { accHolder = value; }
        }
        public Guid accountNumber
        {
            get { return accNumber; }
        }
        public AccountType accountType
        {
            get { return accType; }
        }
        public Guid GenAccountNumber()
        {
            return Guid.NewGuid();
        }
        public void Deposit(decimal cash)
        {
            if (cash >= 0)
            {
                balance += cash;
                BankTransaction unitQueue = new BankTransaction(cash);
                queue.Enqueue(unitQueue);
            }
            else
            {
                Console.WriteLine("Нельзя внести отрицательное кол-во денег");
            }
        }
        public void Withdraw(decimal cash)
        {
            if (cash < balance)
            {
                if (cash > 0)
                {
                    balance -= cash;
                    BankTransaction unitQueue = new BankTransaction(cash);
                    queue.Enqueue(unitQueue);
                }
                else
                {
                    Console.WriteLine("Нельзя снять отрицательное кол-во денег");
                }
            }
            else
            {
                Console.WriteLine("На счете недостаточно средств");
            }
        }
        public void PrintAccBank()
        {
            Console.WriteLine($"Держатель счета: {accHolder}\nНомер счета: {accNumber}\nБаланс счета: {balance}\nТип счета: {accType}");
        }

        public void Transfer(BankAccount target, decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= target.balance)
                {
                    Withdraw(amount);
                    target.Deposit(amount);
                    Console.WriteLine($"Перевод выполнен. Баланс вашего счета: {balance}");
                }
                else
                {
                    Console.WriteLine("На счете недостаточно средств для совершения перевода");
                }
            }
            else
            {
                Console.WriteLine("Нельзя перевести отрицательное кол-во денег");
            }
        }
        public void Dispose()
        {
            foreach (BankTransaction t in queue)
            {
                File.AppendAllText(@"..\..\..\files\Transactions.txt", $"Сумма: {t.GetAmount}. Дата и время: {t.GetDateTime}\n");
            }
            GC.SuppressFinalize(queue);
        }
        public void PrintFileQueue()
        {
            string textQueue = File.ReadAllText(@"..\..\..\files\Transactions.txt");
            Console.WriteLine(textQueue);
        }

        [Conditional("DEBUG")]
        public void DumpToScreen()
        {

                foreach (BankTransaction i in queue)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
