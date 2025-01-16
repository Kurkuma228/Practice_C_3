using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДзC_.classes
{
    internal class BankAccFactory
    {
        private readonly Hashtable accounts = new();
        public Guid CreateAccount()
        {
            Guid numAcc = Guid.NewGuid();
            BankAcc acc = new BankAcc(numAcc);
            accounts.Add(numAcc, acc);
            return acc.Num;
        }
        public Guid CreateAccount(string accHolder)
        {
            Guid numAcc = Guid.NewGuid();
            BankAcc acc = new BankAcc(numAcc, accHolder);
            accounts.Add(numAcc, acc);
            return acc.Num;
        }
        public void AccClouser(Guid num)
        {
            if (!accounts.ContainsKey(num))
            {
                Console.WriteLine("Такого счета нет");
            }
            accounts.Remove(num);
        }
        public BankAcc GetAcc(Guid num)
        {
            
            return (BankAcc)accounts[num];
        }
    }
}
