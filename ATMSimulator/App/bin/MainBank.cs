namespace ATMSimulator.App.bin {
    using ATMSimulator.App.bin.cards;
    using System.Collections.Generic;

    public class MainBank {
        private Dictionary<string, ICardInfo> customerСards = new Dictionary<string, ICardInfo>();

        public void AddCard(ICardInfo cardInfo) {
            customerСards.Add(cardInfo.GetNumber(), cardInfo);
        }
        public void DestroyCard(Card card) {
            customerСards.Remove(card.GetNumber());
        }

        public bool CheckPassword(Card card, int password) {
            return customerСards[card.GetNumber()].CheckPassword(password);
        }

        public int GetBalance(Card card) {
            return customerСards[card.GetNumber()].GetBalance();
        }

        public bool GetSum(Card card, int sum) {
            ICardInfo cardInfo = customerСards[card.GetNumber()];
            return cardInfo.GetSum(sum);
        }

        //Метод заглушка, функция не реализована до конца.
        public bool SellSum(Card card, int sum) {
            ICardInfo cardInfo = customerСards[card.GetNumber()];
            return cardInfo.GetSum(sum);
        }

    }





}
