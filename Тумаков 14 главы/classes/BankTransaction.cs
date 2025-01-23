using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков14.classes
{
    internal class BankTransaction
    {
        decimal amount;
        DateTime dateTime;

        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            dateTime = DateTime.Now;
        }
        public decimal GetAmount
        {
            get { return amount; }
        }
        public DateTime GetDateTime
        {
            get { return dateTime; }
        }
    }
}
