namespace ATMSimulator {
    using System;

    public class BalanceActivity : Activity {
        public BalanceActivity(MainForm mForm) : base(mForm) {
        }
        public override void Close() {
            base.Close();
            mForm.BalancePanel.Visible = false;
            mForm.ContinueBTN.Visible = false;
            mForm.MenuBtnLabel.Visible = false;
            mForm.printBtn.Visible = false;
        }

        private void BindBtns() {
            RegisterHandler(mForm.printBtn, new EventHandler((obj1, obj2) => {
                Close();
                new PrintCheckActivity(mForm).Start();
            }));
            RegisterHandler(mForm.ContinueBTN, new EventHandler((obj1, obj2) => {
                Close();
                new ReturnCardActivity(mForm).Start();
            }));
            RegisterHandler(mForm.MenuBtnLabel, new EventHandler((obj1, obj2) => {
                Close();
                new MenuActivity(mForm).Start();
            }));
            SimpleKeyboard keyboard = new SimpleKeyboard(mForm, this);
            keyboard.SubCancelBtn((button) => {
                Close();
                new MenuActivity(mForm).Start();
            });
        }

        private void StartBalance() {
            mForm.ContinueBTN.Visible = true;
            mForm.MenuBtnLabel.Visible = true;
            mForm.BalancePanel.Visible = true;
            mForm.printBtn.Visible = true;
            int balance = listener.GetBalance(MenuManager.currentCard);
            mForm.BalanceLabel.Text = balance.ToString();
        }
        public override void Start() {
            BindBtns();
            StartBalance();
        }
    }
}
