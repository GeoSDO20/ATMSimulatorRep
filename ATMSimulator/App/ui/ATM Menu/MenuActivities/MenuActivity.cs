namespace ATMSimulator {
    using System;

    public class MenuActivity : Activity {
        public MenuActivity(MainForm mForm) : base(mForm) { }

        public override void Close() {
            base.Close();
            mForm.MenuPanel.Visible = false;
            mForm.ContinueBTN.Visible = false;
        }

        public override void Start() {
            base.Start();
            BindBtns();
            StartMenu();
        }
        private void BindBtns() {
            RegisterHandler(mForm.btnBalanceLabel, new EventHandler((obj1, obj2) => {
                Close();
                new BalanceActivity(mForm).Start();
            }));
            RegisterHandler(mForm.btnGetLabel, new EventHandler((obj1, obj2) => {
                Close();
                new OperationActivity(mForm, OperationActivity.KEY_GET).Start();
            }));
            RegisterHandler(mForm.btnSellLabel, new EventHandler((obj1, obj2) => {
                Close();
                new OperationActivity(mForm, OperationActivity.KEY_SELL).Start();
            }));
            RegisterHandler(mForm.ContinueBTN, new EventHandler((obj1, obj2) => {
                Close();
                new ReturnCardActivity(mForm).Start();
            }));
        }
        private void StartMenu() {
            mForm.MenuPanel.Visible = true;
            mForm.ContinueBTN.Visible = true;
            SimpleKeyboard keyboard = new SimpleKeyboard(mForm, this);
            keyboard.SubCancelBtn((button) => {
                Close();
                new ReturnCardActivity(mForm).Start();
            });
        }
    }
}
