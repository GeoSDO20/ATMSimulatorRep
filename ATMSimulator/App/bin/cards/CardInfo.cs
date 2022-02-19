using System;

namespace ATMSimulator.App.bin.cards {
    public class CardInfo : ICardInfo {
        public readonly string number;
        public int balance;
        public int password;

        public CardInfo(string number) {
            this.number = number;
        }

        public bool CheckPassword(int password) {
            return this.password == password ? true : false;
        }

        public int GetBalance() {
            return balance;
        }

        public string GetNumber() {
            return number;
        }

        public virtual bool GetSum(int sum) {
            Console.WriteLine(sum.ToString());
            if (sum > balance) return false;
            balance -= sum;
            Console.WriteLine(balance.ToString());
            return true;
        }
    }
}
