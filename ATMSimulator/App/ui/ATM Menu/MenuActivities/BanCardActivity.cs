namespace ATMSimulator {
    public class BanCardActivity : Activity {
        public BanCardActivity(MainForm mForm) : base(mForm) {
        }

        public override void Close() {
            base.Close();
            mForm.ContinueBTN.Visible = false;
            mForm.CardBlockPanel.Visible = false;
        }

        public override void Start() {
            RegisterHandler(mForm.ContinueBTN, new System.EventHandler((obj1, obj2) => {
                new PreviewActivity(mForm).Start();
                Close();
            }));
            BanCard();
        }
        private void BanCard() {
            mForm.ContinueBTN.Visible = true;
            MenuManager.currentCardRider.Visible = false;
            listener.CardWasBan(MenuManager.currentCard);
            mForm.CardBlockPanel.Visible = true;
        }
    }
}
