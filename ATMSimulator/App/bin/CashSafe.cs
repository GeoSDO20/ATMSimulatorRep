namespace ATMSimulator.App.bin {
    using System;
    using System.Collections.Generic;

    public class CashSafe {

        public List<int> balanceList = new List<int>();
        public int balance;
        public int newBalance;
        public List<int> outBalanceList = new List<int>();
        public List<int> newBalanceList = new List<int>();
        public void SetBalance(int balance) {
            this.balance = balance;
            balanceList.Clear();
            BanknoteParse(balanceList, balance);
            Console.WriteLine(this.balance);
            Console.WriteLine("Хранилище приняло:");
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            foreach (var item in balanceList) {
                switch (item) {
                    case 5000:
                        count1++;
                        break;
                    case 1000:
                        count2++;
                        break;
                    case 500:
                        count3++;
                        break;
                    case 100:
                        count4++;
                        break;
                    case 50:
                        count5++;
                        break;
                }
            }
            Console.WriteLine(
                $"5000 = {count1}" +
                $"\n1000 = {count2}" +
                $"\n500 = {count3}" +
                $"\n100 = {count4}" +
                $"\n50 = {count5}");

        }
        delegate bool BanknoteParser(int banknote);
        private int BanknoteParse(List<int> balanceList, int sum) {
            BanknoteParser parser = (banknote) => {
                if (sum % banknote == 0) {
                    sum -= banknote;
                    balanceList.Add(banknote);
                    return true;
                }
                return false;
            };
            int packCount = 0;
            int packNumber = 0;
            int packLimit = 0;
            while (sum >= 50) {
                if (packCount == packLimit) {
                    packNumber++;
                    packCount = 0;
                }
                packCount++;
                if (packNumber == 0 && parser(50)) { packLimit = 2; continue; }
                if (packNumber == 1 && parser(100)) { packLimit = 2; continue; }
                if (packNumber == 2 && parser(500)) { packLimit = 2; continue; }
                if (packNumber == 3 && parser(1000)) { packLimit = 4; continue; }
                if (packNumber == 4 && parser(5000)) { packLimit = 4; continue; }
                if (sum % 50 == 0) { packNumber = 0; continue; }
                if (sum % 100 == 0) { packNumber = 1; continue; }
                if (sum % 500 == 0) { packNumber = 2; continue; }
                if (sum % 1000 == 0) { packNumber = 3; continue; }
                if (sum % 5000 == 0) { packNumber = 4; continue; }

            }
            return sum;
        }


        public bool GentOutBalanceList(int sum) {
            outBalanceList = new List<int>();
            var tempBalanceList = balanceList;
            var tempSum = sum;
            while (sum != 0) {
                int itemIndex = tempBalanceList.IndexOf(5000);
                if (sum % 5000 == 0 && itemIndex != -1) {
                    sum -= 5000;
                    outBalanceList.Add(5000);
                    tempBalanceList.RemoveAt(itemIndex);
                    continue;
                }
                itemIndex = tempBalanceList.IndexOf(1000);
                if (sum % 1000 == 0 && itemIndex != -1) {
                    sum -= 1000;
                    outBalanceList.Add(1000);
                    tempBalanceList.RemoveAt(itemIndex);
                    continue;
                }
                itemIndex = tempBalanceList.IndexOf(500);
                if (sum % 500 == 0 && itemIndex != -1) {
                    sum -= 500;
                    outBalanceList.Add(500);
                    tempBalanceList.RemoveAt(itemIndex);
                    continue;
                }
                itemIndex = tempBalanceList.IndexOf(100);
                if (sum % 100 == 0 && itemIndex != -1) {
                    sum -= 100;
                    outBalanceList.Add(100);
                    tempBalanceList.RemoveAt(itemIndex);
                    continue;
                }
                itemIndex = tempBalanceList.IndexOf(50);
                if (sum % 50 == 0 && itemIndex != -1) {
                    sum -= 50;
                    outBalanceList.Add(50);
                    tempBalanceList.RemoveAt(itemIndex);
                    continue;
                }
                break;

            }
            if (sum != 0) return false;
            newBalanceList = tempBalanceList;
            newBalance = balance - tempSum;

            return true;
        }

        public List<int> GetSum() {
            balance = newBalance;
            balanceList = newBalanceList;
            Console.WriteLine("Было выдано:");
            foreach (var item in outBalanceList) {
                Console.Write(item + ", ");
            }
            Console.WriteLine("Осталось: ");
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            foreach (var item in balanceList) {
                switch (item) {
                    case 5000:
                        count1++;
                        break;
                    case 1000:
                        count2++;
                        break;
                    case 500:
                        count3++;
                        break;
                    case 100:
                        count4++;
                        break;
                    case 50:
                        count5++;
                        break;
                }
            }
            Console.WriteLine(
                $"5000 = {count1}" +
                $"\n1000 = {count2}" +
                $"\n500 = {count3}" +
                $"\n100 = {count4}" +
                $"\n50 = {count5}");
            return outBalanceList;
        }
    }
}
