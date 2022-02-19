using System;

namespace ATMSimulator {
    public class OperationActivity : Activity {
        public readonly static byte KEY_SELL = 1;
        public readonly static byte KEY_GET = 2;
        private byte modeKey;
        public OperationActivity(MainForm mForm, byte modeKey) : base(mForm) {
            this.modeKey = modeKey;
        }

        public override void Close() {
            base.Close();
            mForm.ContinueBTN.Visible = false;
            mForm.EnterSumPanel.Visible = false;
            mForm.MenuBtnLabel.Visible = false;
            mForm.SumTB.Clear();
        }


        private void PutSum() {
            int sum = 0;
            string text = "";
            SimpleKeyboard keyboard = new SimpleKeyboard(mForm, this);
            keyboard.SubSimpleBtns((button, inputStr) => {
                text = mForm.SumTB.Text;
                if (text.Length >= 8) return;
                text += inputStr;
                mForm.SumTB.Text = text;

            });
            keyboard.SubEnterBtn((button) => {
                sum = int.Parse(text);
                (bool, string) result;
                if (modeKey == KEY_GET) {
                    result = listener.GetSum(MenuManager.currentCard, sum);
                    if (result.Item1) mForm.DropedMoney.Visible = true;
                }
                else {
                    result.Item1 = listener.SellSum(MenuManager.currentCard, sum);
                    result.Item2 = "Не достаточно средств!";
                }
                if (!result.Item1) {
                    Close();
                    new NotificationActivity(mForm)
                    .ShowCancelBtn()
                    .ShowMenuBtn()
                    .SetText("Операция не удалась", result.Item2)
                    .Start();
                    return;
                }
                Close();
                new PrintCheckActivity(mForm).Start();
            });
            keyboard.SubClearBtn((button) => {
                SimpleKeyboard.Backspace(mForm.SumTB);
            });
            keyboard.SubCancelBtn((button) => {
                Close();
                new MenuActivity(mForm).Start();
            });
        }
        private void BintBtns() {
            RegisterHandler(mForm.ContinueBTN, new EventHandler((obj1, obj2) => {
                Close();
                new ReturnCardActivity(mForm).Start();
            }));
            RegisterHandler(mForm.MenuBtnLabel, new EventHandler((obj1, obj2) => {
                Close();
                new MenuActivity(mForm).Start();
            }));
        }
        public override void Start() {
            base.Start();
            mForm.EnterSumPanel.Visible = true;
            mForm.MenuBtnLabel.Visible = true;
            mForm.ContinueBTN.Visible = true;
            BintBtns();
            PutSum();
        }
    }
}
