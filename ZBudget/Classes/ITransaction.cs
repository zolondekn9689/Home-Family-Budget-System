using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using ZBudget.Models.ZBudget;

namespace ZBudget.Classes
{
    public interface ITransaction
    {
        public void Transaction<T>([NotNull] ref Person from, [NotNull] ref Person to, T transferItem);
        public void RevertTransaction();

    }
}
