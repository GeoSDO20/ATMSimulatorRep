namespace ATMSimulator {
    using ATMSimulator.App.ui;
    using System;
    using System.Windows.Forms;

    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartSettingsDialog sDialog = new StartSettingsDialog();
            Application.Run(sDialog);
        }
    }
}
