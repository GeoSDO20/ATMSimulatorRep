using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATMSimulator {
    public abstract class Activity {
        protected MainForm mForm;
        protected Dictionary<Control, EventHandler> mainBtnsDic;
        protected IMenuListener listener;
        public Activity(MainForm mForm) {
            mainBtnsDic = new Dictionary<Control, EventHandler>();
            this.mForm = mForm;
            this.listener = mForm.cashMachine.GetListener();
        }
        public virtual void Start() {
        }
        public virtual void Close() {
            Dispose();
        }
        public void RegisterHandler(Control button, EventHandler eventHandler) {
            if (mainBtnsDic.ContainsKey(button)) return;
            mainBtnsDic.Add(button, eventHandler);
            button.Click += eventHandler;
        }
        private void Dispose() {
            foreach (var value in mainBtnsDic) {
                value.Key.Click -= value.Value;
            }
        }
    }
}
