using ATMSimulator.App.bin.cards;
using System;
using System.Windows.Forms;

namespace ATMSimulator {
    public class PreviewActivity : Activity {
        private bool isCardPut = false;
        private PassInputActivity passInputActivity;
        public PreviewActivity(MainForm mForm) : base(mForm) {
            this.passInputActivity = new PassInputActivity(mForm);
        }
        public override void Start() {
            mForm.PreviewPanel.Visible = true;
            mForm.BlueCard.Click += new EventHandler((obj1, obj2) => {
                PutCard(mForm.BlueCardInCardRider, mForm.BlueCard, mForm.currentFirstCard);
            });
            mForm.RedCard.Click += new EventHandler((obj1, obj2) => {
                PutCard(mForm.RedCardInCardRider, mForm.RedCard, mForm.currentSecondCard);
            });
        }
        public override void Close() {
            mForm.PreviewPanel.Visible = false;
            base.Close();
        }
        private void PutCard(Control cardRider, Control imageCard, Card card) {
            if (isCardPut) return;
            isCardPut = true;
            imageCard.Visible = false;
            cardRider.Visible = true;
            listener.PutCard(card);
            MenuManager.currentCardImage = imageCard;
            MenuManager.currentCardRider = cardRider;
            MenuManager.currentCard = card;
            Close();
            passInputActivity.Start();
        }
    }
}
