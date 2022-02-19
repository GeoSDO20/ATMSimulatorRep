namespace ATMSimulator.App.ui {
    using ATMSimulator.App.bin.cards;
    using System;
    using System.Windows.Forms;

    public partial class StartSettingsDialog : Form {
        private MainForm mForm;
        public StartSettingsDialog() {
            InitializeComponent();
            this.mForm = new MainForm();
            Bind();
        }
        private void Bind() {
            typeFirstCard.SelectedIndex = 0;
            typeSecondCard.SelectedIndex = 1;
        }
        private void typeSecondCard_SelectedIndexChanged(object sender, EventArgs e) {
            switch (typeSecondCard.SelectedIndex) {
                case 0:
                    secondCardLimit.Enabled = false;
                    break;
                case 1:
                    secondCardLimit.Enabled = true;
                    break;
            }
        }

        private void typeFirstCard_SelectedIndexChanged(object sender, EventArgs e) {
            switch (typeFirstCard.SelectedIndex) {
                case 0:
                    firstCardLimit.Enabled = false;
                    break;
                case 1:
                    firstCardLimit.Enabled = true;
                    break;
            }
        }

        private void CreateBtnFirstCard_Click(object sender, EventArgs e) {
            if (!CreateFirstCard()) { return; };
            firstCardPanel.Enabled = false;
            CreateBtnFirstCard.Enabled = false;
            RemuveBtnFirstCard.Enabled = true;
        }

        private void RemuveBtnFirstCard_Click(object sender, EventArgs e) {
            mForm.DestroyCard(mForm.currentFirstCard);
            firstCardPanel.Enabled = true;
            RemuveBtnFirstCard.Enabled = false;
            CreateBtnFirstCard.Enabled = true;
            button10.Enabled = false;
        }

        private void CreateBtnSecondCard_Click(object sender, EventArgs e) {
            if (!CreateSecondCard()) { return; };
            secondCardPanel.Enabled = false;
            CreateBtnSecondCard.Enabled = false;
            RemuveBtnSecondCard.Enabled = true;
        }

        private void RemuveBtnSecondCard_Click(object sender, EventArgs e) {
            mForm.DestroyCard(mForm.currentSecondCard);
            secondCardPanel.Enabled = true;
            RemuveBtnSecondCard.Enabled = false;
            CreateBtnSecondCard.Enabled = true;
            button10.Enabled = false;

        }

        private void button10_Click(object sender, EventArgs e) {
            if (CreateBtnFirstCard.Enabled || CreateBtnSecondCard.Enabled) return;
            mForm.Show();
            mForm.Start();
            Hide();

        }
        private bool CreateSecondCard() {
            string number = secondCardNumber.Text;
            if (mForm.currentFirstCard != null) {
                if (mForm.currentFirstCard.GetNumber() == number) {
                    errorLabelCardSecond.Text = "*номер карты не уникален!\nНомера карт должны быть разными.";
                    return false;
                }
            }
            if (secondCardPassword.Text == "" || secondCardPassword.Text.Length < 4) {
                errorLabelCardSecond.Text = "*поле пороля не может бить пустым!";
                return false;
            }
            int password = int.Parse(secondCardPassword.Text);
            int limit = (int)secondCardLimit.Value;
            int balance = (int)secondCardBalance.Value;
            CardInfo cardInfo = null;
            mForm.currentSecondCard = new Card(number);
            if (typeSecondCard.SelectedIndex == 0) {
                cardInfo = new CardInfo(number);
            }
            else {
                cardInfo = new CreditCardInfo(number, limit);
            }
            cardInfo.balance = balance;
            cardInfo.password = password;
            mForm.currentSecondCard = new Card(number);
            mForm.AddCard(cardInfo);
            if (mForm.currentFirstCard != null && mForm.currentSecondCard != null) {
                button10.Enabled = true;
            }
            return true;
        }
        private bool CreateFirstCard() {
            string number = firstCardNumber.Text;
            if (mForm.currentSecondCard != null) {
                if (mForm.currentSecondCard.GetNumber() == number) {
                    errorlabelCardFirst.Text = "*номер карты не уникален!\nНомера карт должны быть разными.";
                    return false;
                }
            }
            if (firstCardPassword.Text == "" || firstCardPassword.Text.Length < 4) {
                errorlabelCardFirst.Text = "*поле пороля не может бить пустым!";
                return false;
            }
            int password = int.Parse(firstCardPassword.Text);
            int limit = (int)firstCardLimit.Value;
            int balance = (int)firstCardBalance.Value;
            CardInfo cardInfo = null;
            mForm.currentFirstCard = new Card(number);
            if (typeFirstCard.SelectedIndex == 0) {
                cardInfo = new CardInfo(number);
            }
            else {
                cardInfo = new CreditCardInfo(number, limit);
            }
            cardInfo.balance = balance;
            cardInfo.password = password;
            mForm.currentFirstCard = new Card(number);
            mForm.AddCard(cardInfo);
            if (mForm.currentFirstCard != null && mForm.currentSecondCard != null) {
                button10.Enabled = true;
            }
            return true;
        }

        private void StartSettingsDialog_FormClosed(object sender, FormClosedEventArgs e) {
            if (mForm.currentFirstCard == null || mForm.currentSecondCard == null) {
                Application.Exit();
            }
        }
    }
}
