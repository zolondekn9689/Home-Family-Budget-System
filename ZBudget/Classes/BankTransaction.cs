using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using ZBudget.Models.ZBudget;

namespace ZBudget.Classes
{
    public class BankTransaction : ITransaction
    {
        private int Id { get; set; }
        private Person From { get; set; }
        private Person To { get; set; }
        public int TransferAmount { get; set; }

        public BankTransaction()
        {
            Id = new Random().Next(1, 9999999);
            TransferAmount = 0;
            From = null;
            To = null;
        }

        public void RevertTransaction()
        {
            To.Balance -= TransferAmount;
            From.Balance += TransferAmount;
        }

        

        public bool Transaction<T>(ref Person from, ref Person to, T transferItem)
        {
            if (typeof(T) != typeof(double) || typeof(T) != typeof(int) || typeof(T) != typeof(float))
                return false;

            this.TransferAmount = Convert.ToInt32(transferItem);
            To = to;
            From = from;

            if (!HasEnough())
                return false;

            To.Balance += TransferAmount;
            From.Balance -= TransferAmount;
            return true;

        }

        

        private bool HasEnough()
        {
            return (From.Balance >= TransferAmount);
        }

        
    }
}
