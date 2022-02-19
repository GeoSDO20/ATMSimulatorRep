using System.Collections.Generic;

namespace ATMSimulator.App.bin {
    public class PrinterCheck {
        public static readonly byte KEY_SELL_OPERATION = 1;
        public static readonly byte KEY_GET_OPERATION = 2;
        public static readonly byte KEY_BALANCE_OPERATION = 3;

        public string PrintCheck(CheckInfo check) {
            switch (check.operationType) {
                case 1:
                    return
                        $"Транзакция: {check.operationNumber}" +
                        $"\nКлиент: {check.clientNumber}" +
                        $"\nОперация: перевод" +
                        $"\nСумма: {check.sum}" +
                        $"\nОперация успешна!" +
                        $"\nСпасибо за визит!";
                case 2:
                    return
                        $"Транзакция: {check.operationNumber}" +
                        $"\nКлиент: {check.clientNumber}" +
                        $"\nОперация: вывод средств" +
                        $"\nСумма: {check.sum}" +
                        $"\nВыдано:" + "\n" +
                        printBanknote(check.banknotes) +
                        $"\nОперация успешна!" +
                        $"\nСпасибо за визит!";
                case 3:
                    return
                        $"Транзакция: {check.operationNumber}" +
                        $"\nКлиент: {check.clientNumber}" +
                        $"\nОперация: баланс счёта" +
                        $"\nСумма: {check.sum}" +
                        $"\nСпасибо за визит!";
            }
            return "";
        }
        private string convertBanknote(string name, int count) {
            if (count == 0) return "";
            return count + " " + name + "\n";
        }
        private string printBanknote(List<int> banknoteList) {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;

            foreach (var item in banknoteList) {
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

            string resultString =
                convertBanknote("5000", count1) +
                convertBanknote("1000", count2) +
                convertBanknote("500", count3) +
                convertBanknote("100", count4) +
                convertBanknote("50", count5);
            return resultString;
        }
    }
}
