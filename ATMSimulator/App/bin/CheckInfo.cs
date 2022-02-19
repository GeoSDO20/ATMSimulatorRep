using System.Collections.Generic;

namespace ATMSimulator {
    public class CheckInfo {
        public int operationNumber;
        public string clientNumber;
        public byte operationType;
        public int sum;
        public int balance;
        public List<int> banknotes;
    }
}
