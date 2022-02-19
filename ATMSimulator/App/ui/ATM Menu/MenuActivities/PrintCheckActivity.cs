using System;

namespace ATMSimulator {
    public class PrintCheckActivity : Activity {
        public PrintCheckActivity(MainForm mForm) : base(mForm) {
        }
        public override void Close() {
            mForm.PrintReceiptPanel.Visible = false;
            base.Close();
        }
        public void ShowNotification() {
            new NotificationActivity(mForm)
                .ShowCancelBtn()
                .ShowMenuBtn()
                .SetText("Операция завершена!", "Спасибо за визит!")
                .Start();
            mForm.DropedMoney.Visible = false;
        }
        public void ShowCheck() {
            mForm.CheckPanel.Visible = true;
            Console.WriteLine("Печать чека");
            Console.WriteLine(listener.PrintCheck());
            mForm.CheckOut.Text = listener.PrintCheck();
        }

        public void BindBtns() {
            SimpleKeyboard keyboard = new SimpleKeyboard(mForm, this);
            keyboard.SubCancelBtn((button) => {
                ShowNotification();
                Close();
            });
            keyboard.SubEnterBtn((button) => {
                ShowCheck();
                ShowNotification();
                Close();

            });
            RegisterHandler(mForm.PositiveBtn, new EventHandler((obj1, obj2) => {
                ShowCheck();
                ShowNotification();
                Close();

            }));
            RegisterHandler(mForm.NegativeBtn, new EventHandler((obj1, obj2) => {
                ShowNotification();
                Close();
            }));
        }

        public override void Start() {
            base.Start();
            mForm.PrintReceiptPanel.Visible = true;
            BindBtns();
        }
    }
}
