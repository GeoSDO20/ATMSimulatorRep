using System;

namespace ATMSimulator {
    public class ReturnCardActivity : Activity {
        public ReturnCardActivity(MainForm mForm) : base(mForm) {
        }
        public override void Close() {
            base.Close();
            mForm.takeCardPanel.Visible = false;
        }
        private void BindBtns() {
            RegisterHandler(MenuManager.currentCardRider, new EventHandler((obj1, obj2) => {
                ReturnCard();
            }));
        }
        private void ReturnCard() {
            MenuManager.currentCardImage.Visible = true;
            MenuManager.currentCardRider.Visible = false;
            Close();
            new PreviewActivity(mForm).Start();
        }
        public override void Start() {
            mForm.takeCardPanel.Visible = true;
            BindBtns();
        }
    }
}
