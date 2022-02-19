using System;
using System.Windows.Forms;

namespace ATMSimulator {
    public class SimpleKeyboard {
        public delegate void TextInputHandler(Button sender, string value);
        public delegate void SpecialInputHandler(Button sender);

        private MainForm mForm;
        private Activity activity;

        public SimpleKeyboard(MainForm mForm, Activity activity) {
            this.activity = activity;
            this.mForm = mForm;
        }
        public void SubSimpleBtns(TextInputHandler handler) {
            Button[] buttonsArray = {
                mForm.button0,mForm.button1,
                mForm.button2,mForm.button3,
                mForm.button4,mForm.button5,
                mForm.button6,mForm.button7,
                mForm.button8,mForm.button9,
            };
            foreach (var button in buttonsArray) {
                BindSimpleBtn(button, handler);
            }
        }
        public void SubPintBtn(TextInputHandler handler) {
            BindSimpleBtn(mForm.buttonPoint, handler);
        }
        public void SubDoubleZeroBtn(TextInputHandler handler) {
            BindSimpleBtn(mForm.button00, handler);
        }
        public void SubCancelBtn(SpecialInputHandler handler) {
            BindSpecialBtn(mForm.buttonCancel, handler);
        }
        public void SubClearBtn(SpecialInputHandler handler) {
            BindSpecialBtn(mForm.buttonClear, handler);
        }

        public void SubEnterBtn(SpecialInputHandler handler) {
            BindSpecialBtn(mForm.buttonEnter, handler);
        }

        private void BindSimpleBtn(Button btn, TextInputHandler handler) {
            EventHandler eventHandler = new EventHandler((obj1, obj2) => {
                handler(btn, btn.Text);
            });
            activity.RegisterHandler(btn, eventHandler);
        }
        private void BindSpecialBtn(Button btn, SpecialInputHandler handler) {
            EventHandler eventHandler = new EventHandler((obj1, obj2) => {
                handler(btn);
            });
            activity.RegisterHandler(btn, eventHandler);
        }
        public static void Backspace(TextBox textBox) {
            string text = textBox.Text;
            if (text == "") return;
            string newStr = text.Remove(text.Length - 1, 1);
            textBox.Text = newStr;
        }
    }
}
