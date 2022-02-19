using System;

namespace ATMSimulator {
    public class PassInputActivity : Activity {
        private readonly int attemptsCountLimit = 3;
        private ReturnCardActivity returnCardActivity;
        public PassInputActivity(MainForm mForm) : base(mForm) {
            returnCardActivity = new ReturnCardActivity(mForm);
        }

        public override void Start() {
            mForm.ContinueBTN.Visible = true;
            mForm.PasswordPanel.Visible = true;
            RegisterHandler(mForm.ContinueBTN, new EventHandler((obj1, obj2) => {
                Close();
                returnCardActivity.Start();
            }));
            BindPassword();
        }
        public override void Close() {
            base.Close();
            mForm.errorPasswordLabel.Visible = false;
            mForm.ContinueBTN.Visible = false;
            mForm.PasswordPanel.Visible = false;
            mForm.passwordTB.Clear();
        }
        private void BindPassword() {
            int attemptsCount = 0;
            int password = 0;
            string errorText = mForm.errorPasswordLabel.Text;
            SimpleKeyboard keyboard = new SimpleKeyboard(mForm, this);
            keyboard.SubSimpleBtns((button, inputStr) => {
                string text = mForm.passwordTB.Text;
                if (text.Length >= 4) return;
                text += inputStr;
                mForm.passwordTB.Text = text;
                password = int.Parse(text);
            });
            keyboard.SubEnterBtn((button) => {
                bool truePassword = listener.EnterPassword(MenuManager.currentCard, password);
                if (!truePassword) {
                    mForm.errorPasswordLabel.Visible = true;
                    attemptsCount++;
                    mForm.errorPasswordLabel.Text = "( " + attemptsCount + ") " + errorText;
                    mForm.passwordTB.Clear();
                    if (attemptsCount == attemptsCountLimit) {
                        Close();
                        new BanCardActivity(mForm).Start();
                        mForm.errorPasswordLabel.Text = errorText;
                    }
                    return;
                }
                Close();
                mForm.errorPasswordLabel.Text = errorText;
                new MenuActivity(mForm).Start();
            });
            keyboard.SubClearBtn((button) => {
                SimpleKeyboard.Backspace(mForm.passwordTB);
            });
            keyboard.SubCancelBtn((button) => {
                Close();
                returnCardActivity.Start();
            });

        }

    }
}
