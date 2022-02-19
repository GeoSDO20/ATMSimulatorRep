using ATMSimulator.App.bin;
using ATMSimulator.App.bin.cards;
using System.Collections.Generic;

namespace ATMSimulator {
    public class CashMachine : IMenuListener {
        private MainForm mForm;
        private MainBank mBank;
        private CashSafe safe;
        private int transactionCounter;
        private CheckInfo check;
        private PrinterCheck checkPrinter;
        private List<Card> banCardList = new List<Card>();
        private static int operationCont = 0;

        public int GetNextOperationCount() {
            operationCont++;
            return operationCont;
        }
        public CashMachine(MainForm mForm, MainBank mBank) {
            this.mForm = mForm;
            this.mBank = mBank;
            safe = new CashSafe();
            checkPrinter = new PrinterCheck();
            safe.SetBalance(500000);
        }
        public void Start() {
            new MenuManager(mForm);
        }
        public IMenuListener GetListener() {
            return this;
        }

        public void CardWasBan(Card card) {
            banCardList.Add(card);
        }

        public bool EnterPassword(Card card, int password) {
            return mBank.CheckPassword(card, password);
        }

        public bool SellSum(Card card, int sum) {
            check.operationType = PrinterCheck.KEY_SELL_OPERATION;
            check.sum = sum;
            transactionCounter++;
            return mBank.SellSum(card, sum);
        }

        public int GetBalance(Card card) {
            int balance = mBank.GetBalance(card);
            check.operationType = PrinterCheck.KEY_BALANCE_OPERATION;
            check.sum = balance;
            transactionCounter++;
            return balance;
        }
        public (bool, string) GetSum(Card card, int sum) {
            bool canGet = safe.GentOutBalanceList(sum);
            if (canGet) {
                if (mBank.GetSum(card, sum)) {
                    transactionCounter++;
                    check.operationType = PrinterCheck.KEY_GET_OPERATION;
                    check.sum = sum;
                    check.banknotes = safe.GetSum();
                    return (true, "");
                }
                return (false, "Недостаточно средств.");
            }
            else {
                return (false, "Нет купюр!");
            }
        }

        public string PrintCheck() {
            check.operationNumber = transactionCounter;
            return checkPrinter.PrintCheck(check);
        }

        public void PutCard(Card card) {
            check = new CheckInfo();
            check.clientNumber = card.GetNumber();
        }
    }
}
