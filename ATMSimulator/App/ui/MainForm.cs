namespace ATMSimulator {
    using ATMSimulator.App.bin;
    using ATMSimulator.App.bin.cards;
    using System.Windows.Forms;

    public partial class MainForm : Form {

        private MainBank mBank;
        public CashMachine cashMachine;

        public Card currentFirstCard;
        public Card currentSecondCard;

        public MainForm() {
            InitializeComponent();
            mBank = new MainBank();
            cashMachine = new CashMachine(this, mBank);
        }

        public void AddCard(CardInfo cardInfo) {
            mBank.AddCard(cardInfo);
        }
        public void DestroyCard(Card card) {
            if (currentFirstCard == card) {
                currentFirstCard = null;
            }
            else {
                currentSecondCard = null;
            }
            mBank.DestroyCard(card);
        }
        public void Start() {
            cashMachine.Start();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
