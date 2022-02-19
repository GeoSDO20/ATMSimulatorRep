namespace ATMSimulator {
    using ATMSimulator.App.bin.cards;
    using System.Windows.Forms;

    public class MenuManager {
        public static Control currentCardRider;
        public static Control currentCardImage;
        public static Card currentCard;

        public MenuManager(MainForm mForm) {
            new PreviewActivity(mForm).Start();
        }

    }
}
