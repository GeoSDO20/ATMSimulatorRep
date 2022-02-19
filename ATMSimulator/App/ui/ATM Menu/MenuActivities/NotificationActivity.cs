namespace ATMSimulator {
    using System;

    public class NotificationActivity : Activity {
        private SimpleKeyboard keyboard;
        public NotificationActivity(MainForm mForm) : base(mForm) {
            keyboard = new SimpleKeyboard(mForm, this);
        }

        public override void Close() {
            base.Close();
            mForm.NotificationLabel.Visible = false;
            mForm.NotificationDescLabel.Visible = false;
            mForm.NotificationPanel.Visible = false;
            mForm.MenuBtnLabel.Visible = false;
            mForm.ContinueBTN.Visible = false;
        }

        public override void Start() {
            mForm.NotificationPanel.Visible = true;
            base.Start();
        }
        public NotificationActivity ShowMenuBtn() {
            mForm.MenuBtnLabel.Visible = true;
            RegisterHandler(mForm.MenuBtnLabel, new EventHandler((obj1, obj2) => {
                Close();
                new MenuActivity(mForm).Start();
            }));
            keyboard.SubEnterBtn(new SimpleKeyboard.SpecialInputHandler((button) => {
                Close();
                new MenuActivity(mForm).Start();

            }));
            return this;
        }
        public NotificationActivity ShowCancelBtn() {
            mForm.ContinueBTN.Visible = true;
            RegisterHandler(mForm.ContinueBTN, new EventHandler((obj1, obj2) => {
                Close();
                new ReturnCardActivity(mForm).Start();
            }));

            keyboard.SubCancelBtn(new SimpleKeyboard.SpecialInputHandler((button) => {
                Close();
                new ReturnCardActivity(mForm).Start();
            }));
            return this;
        }
        public NotificationActivity SetText(string label) {
            mForm.NotificationLabel.Visible = true;
            mForm.NotificationLabel.Text = label;
            return this;
        }
        public NotificationActivity SetText(string label, string description) {
            mForm.NotificationLabel.Visible = true;
            mForm.NotificationDescLabel.Visible = true;
            mForm.NotificationLabel.Text = label;
            mForm.NotificationDescLabel.Text = description;
            return this;
        }
    }
}
