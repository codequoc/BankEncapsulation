﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private double balance = 0;
        public void Deposit(double depositAmount)
        {
            balance += depositAmount;
        }
        public void GetBalance()
        {
            Console.WriteLine($"Balance is { balance}");
        }
    }
}
