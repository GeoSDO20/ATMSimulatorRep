using ATMSimulator.App.bin.cards;

namespace ATMSimulator {
    public interface IMenuListener {
        void PutCard(Card card);
        bool EnterPassword(Card card, int password);
        bool SellSum(Card card, int sum);
        (bool, string) GetSum(Card card, int sum);
        string PrintCheck();

        int GetBalance(Card card);
        void CardWasBan(Card card);

    }
}
