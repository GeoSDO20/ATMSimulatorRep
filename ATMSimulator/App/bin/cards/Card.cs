namespace ATMSimulator.App.bin.cards {
    public class Card {
        private string number;

        public Card(string number) {
            this.number = number;
        }

        public string GetNumber() {
            return number;
        }
        public void SetNumber(string number) {
            this.number = number;
        }
    }
}
