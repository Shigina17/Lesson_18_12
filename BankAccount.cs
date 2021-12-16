#define DEBUG_ACCOUNT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// подключаем атрибуты
using System.Runtime.InteropServices;

// подключаем атрибут Conditional
using System.Diagnostics;

namespace Lesson_18_12
{
    class BankAccount
    {
        public TypeOfAccount type;
        private int balance;

        public BankAccount(TypeOfAccount type, int balance)
        {
            this.type = type;
            this.balance = balance;
        }

        public static BankAccount Current { get; internal set; }

        public enum TypeOfAccount
        {
            Current = 1,
            Saving
        }

        internal void PutOfMoneyFromAccount(BankAccount acc1, int v)
        {
            throw new NotImplementedException();
        }

        [Conditional("DEBUG")]
        public void DumpToScreen()
        {
            Console.WriteLine("Информация о счете:\n" + $"{type}\t{balance}$");
        }
    }
}
