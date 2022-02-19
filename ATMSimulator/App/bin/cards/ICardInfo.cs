namespace ATMSimulator.App.bin {
    public interface ICardInfo {
        bool GetSum(int sum);
        string GetNumber();
        int GetBalance();
        bool CheckPassword(int password);
    }
}
