using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTes
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        public void setAccName(String AccName)
        {
            accName = AccName;
        }
        public string getAccName()
        {
            return accName;
        }
        public void setAcid(String Acid)
        {
            acid = Acid;
        }
        public string getAcid()
        {
            return acid;
        }
        public void setBalance(int Balance)
        {
            balance = Balance;
        }
        public int getBalance()
        {
            return balance;
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
        }
        public void withdraw(int amount)
        {
            balance = balance - amount;
        }

        public Account(string accName, string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("AccName : " + accName);
            Console.WriteLine("Acid : " + acid);
            Console.WriteLine("balance : " + balance);
        }

    }
}
