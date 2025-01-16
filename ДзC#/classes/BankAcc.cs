using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДзC_.classes
{
    internal class BankAcc : BankAccFactory
    {
        public Guid Num;
        public string AccHolder;

        internal BankAcc(Guid Num)
        {
            this.Num = Num;
        }
        internal BankAcc(Guid Num, string AccHolder)
        {
            this.Num = Num;
            this.AccHolder = AccHolder;
        }
    }
}
