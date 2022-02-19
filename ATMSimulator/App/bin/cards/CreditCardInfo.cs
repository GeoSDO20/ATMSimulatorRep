namespace ATMSimulator.App.bin.cards {
    public class CreditCardInfo : CardInfo {
        public int creditLimit;

        public CreditCardInfo(string number, int creditLimit) : base(number) {
            this.creditLimit = creditLimit;
        }

        public override bool GetSum(int sum) {
            if (balance >= sum) {
                balance -= sum;
                return true;
            }
            else {
                int TempBalance = sum - balance;
                if (creditLimit >= TempBalance) {
                    creditLimit -= TempBalance;
                    balance = 0;
                    return true;
                }
                else {
                    return false;
                }
            }
        }
    }
}
