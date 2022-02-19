namespace ATMSimulator.App.ui {

    partial class StartSettingsDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button10 = new System.Windows.Forms.Button();
            this.RemuveBtnSecondCard = new System.Windows.Forms.Button();
            this.CreateBtnSecondCard = new System.Windows.Forms.Button();
            this.RemuveBtnFirstCard = new System.Windows.Forms.Button();
            this.CreateBtnFirstCard = new System.Windows.Forms.Button();
            this.secondCardPanel = new System.Windows.Forms.Panel();
            this.secondCardLimit = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.typeSecondCard = new System.Windows.Forms.ComboBox();
            this.secondCardBalance = new System.Windows.Forms.NumericUpDown();
            this.secondCardPassword = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.secondCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.firstCardPanel = new System.Windows.Forms.Panel();
            this.firstCardLimit = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.firstCardPassword = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.typeFirstCard = new System.Windows.Forms.ComboBox();
            this.firstCardBalance = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.firstCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.errorlabelCardFirst = new System.Windows.Forms.Label();
            this.errorLabelCardSecond = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.secondCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardBalance)).BeginInit();
            this.firstCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(275, 12);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(247, 89);
            this.button10.TabIndex = 62;
            this.button10.Text = "Начать";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // RemuveBtnSecondCard
            // 
            this.RemuveBtnSecondCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RemuveBtnSecondCard.Enabled = false;
            this.RemuveBtnSecondCard.Location = new System.Drawing.Point(397, 453);
            this.RemuveBtnSecondCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemuveBtnSecondCard.Name = "RemuveBtnSecondCard";
            this.RemuveBtnSecondCard.Size = new System.Drawing.Size(125, 39);
            this.RemuveBtnSecondCard.TabIndex = 61;
            this.RemuveBtnSecondCard.Text = "Уничтожить";
            this.RemuveBtnSecondCard.UseVisualStyleBackColor = false;
            this.RemuveBtnSecondCard.Click += new System.EventHandler(this.RemuveBtnSecondCard_Click);
            // 
            // CreateBtnSecondCard
            // 
            this.CreateBtnSecondCard.BackColor = System.Drawing.SystemColors.Control;
            this.CreateBtnSecondCard.Location = new System.Drawing.Point(275, 453);
            this.CreateBtnSecondCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBtnSecondCard.Name = "CreateBtnSecondCard";
            this.CreateBtnSecondCard.Size = new System.Drawing.Size(117, 39);
            this.CreateBtnSecondCard.TabIndex = 60;
            this.CreateBtnSecondCard.Text = "Выпустить";
            this.CreateBtnSecondCard.UseVisualStyleBackColor = false;
            this.CreateBtnSecondCard.Click += new System.EventHandler(this.CreateBtnSecondCard_Click);
            // 
            // RemuveBtnFirstCard
            // 
            this.RemuveBtnFirstCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RemuveBtnFirstCard.Enabled = false;
            this.RemuveBtnFirstCard.Location = new System.Drawing.Point(144, 452);
            this.RemuveBtnFirstCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemuveBtnFirstCard.Name = "RemuveBtnFirstCard";
            this.RemuveBtnFirstCard.Size = new System.Drawing.Size(125, 39);
            this.RemuveBtnFirstCard.TabIndex = 59;
            this.RemuveBtnFirstCard.Text = "Уничтожить";
            this.RemuveBtnFirstCard.UseVisualStyleBackColor = false;
            this.RemuveBtnFirstCard.Click += new System.EventHandler(this.RemuveBtnFirstCard_Click);
            // 
            // CreateBtnFirstCard
            // 
            this.CreateBtnFirstCard.BackColor = System.Drawing.SystemColors.Control;
            this.CreateBtnFirstCard.Location = new System.Drawing.Point(21, 453);
            this.CreateBtnFirstCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBtnFirstCard.Name = "CreateBtnFirstCard";
            this.CreateBtnFirstCard.Size = new System.Drawing.Size(117, 39);
            this.CreateBtnFirstCard.TabIndex = 58;
            this.CreateBtnFirstCard.Text = "Выпустить";
            this.CreateBtnFirstCard.UseVisualStyleBackColor = false;
            this.CreateBtnFirstCard.Click += new System.EventHandler(this.CreateBtnFirstCard_Click);
            // 
            // secondCardPanel
            // 
            this.secondCardPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.secondCardPanel.Controls.Add(this.secondCardLimit);
            this.secondCardPanel.Controls.Add(this.label30);
            this.secondCardPanel.Controls.Add(this.label10);
            this.secondCardPanel.Controls.Add(this.typeSecondCard);
            this.secondCardPanel.Controls.Add(this.secondCardBalance);
            this.secondCardPanel.Controls.Add(this.secondCardPassword);
            this.secondCardPanel.Controls.Add(this.label11);
            this.secondCardPanel.Controls.Add(this.label22);
            this.secondCardPanel.Controls.Add(this.label15);
            this.secondCardPanel.Controls.Add(this.secondCardNumber);
            this.secondCardPanel.Controls.Add(this.label21);
            this.secondCardPanel.Location = new System.Drawing.Point(275, 110);
            this.secondCardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondCardPanel.Name = "secondCardPanel";
            this.secondCardPanel.Size = new System.Drawing.Size(248, 306);
            this.secondCardPanel.TabIndex = 57;
            // 
            // secondCardLimit
            // 
            this.secondCardLimit.Location = new System.Drawing.Point(17, 276);
            this.secondCardLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondCardLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.secondCardLimit.Name = "secondCardLimit";
            this.secondCardLimit.Size = new System.Drawing.Size(205, 22);
            this.secondCardLimit.TabIndex = 49;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(13, 251);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 17);
            this.label30.TabIndex = 50;
            this.label30.Text = "Лимит:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Карта 2";
            // 
            // typeSecondCard
            // 
            this.typeSecondCard.Items.AddRange(new object[] {
            "Обычная карта",
            "Кредитная кредитная"});
            this.typeSecondCard.Location = new System.Drawing.Point(17, 68);
            this.typeSecondCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeSecondCard.Name = "typeSecondCard";
            this.typeSecondCard.Size = new System.Drawing.Size(207, 24);
            this.typeSecondCard.TabIndex = 25;
            this.typeSecondCard.SelectedIndexChanged += new System.EventHandler(this.typeSecondCard_SelectedIndexChanged);
            // 
            // secondCardBalance
            // 
            this.secondCardBalance.Location = new System.Drawing.Point(19, 174);
            this.secondCardBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondCardBalance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.secondCardBalance.Name = "secondCardBalance";
            this.secondCardBalance.Size = new System.Drawing.Size(205, 22);
            this.secondCardBalance.TabIndex = 26;
            // 
            // secondCardPassword
            // 
            this.secondCardPassword.Location = new System.Drawing.Point(19, 223);
            this.secondCardPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondCardPassword.Mask = "0000";
            this.secondCardPassword.Name = "secondCardPassword";
            this.secondCardPassword.Size = new System.Drawing.Size(204, 22);
            this.secondCardPassword.TabIndex = 47;
            this.secondCardPassword.ValidatingType = typeof(int);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Баланс:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 102);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 17);
            this.label22.TabIndex = 39;
            this.label22.Text = "Номер";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Тип:";
            // 
            // secondCardNumber
            // 
            this.secondCardNumber.Location = new System.Drawing.Point(15, 122);
            this.secondCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondCardNumber.Name = "secondCardNumber";
            this.secondCardNumber.Size = new System.Drawing.Size(207, 22);
            this.secondCardNumber.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(16, 203);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 17);
            this.label21.TabIndex = 36;
            this.label21.Text = "Пароль:";
            this.label21.UseWaitCursor = true;
            // 
            // firstCardPanel
            // 
            this.firstCardPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstCardPanel.Controls.Add(this.firstCardLimit);
            this.firstCardPanel.Controls.Add(this.label29);
            this.firstCardPanel.Controls.Add(this.firstCardPassword);
            this.firstCardPanel.Controls.Add(this.label9);
            this.firstCardPanel.Controls.Add(this.typeFirstCard);
            this.firstCardPanel.Controls.Add(this.firstCardBalance);
            this.firstCardPanel.Controls.Add(this.label24);
            this.firstCardPanel.Controls.Add(this.label19);
            this.firstCardPanel.Controls.Add(this.label17);
            this.firstCardPanel.Controls.Add(this.label20);
            this.firstCardPanel.Controls.Add(this.firstCardNumber);
            this.firstCardPanel.Location = new System.Drawing.Point(21, 110);
            this.firstCardPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstCardPanel.Name = "firstCardPanel";
            this.firstCardPanel.Size = new System.Drawing.Size(248, 306);
            this.firstCardPanel.TabIndex = 56;
            // 
            // firstCardLimit
            // 
            this.firstCardLimit.Location = new System.Drawing.Point(21, 276);
            this.firstCardLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstCardLimit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.firstCardLimit.Name = "firstCardLimit";
            this.firstCardLimit.Size = new System.Drawing.Size(205, 22);
            this.firstCardLimit.TabIndex = 47;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 251);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(54, 17);
            this.label29.TabIndex = 48;
            this.label29.Text = "Лимит:";
            // 
            // firstCardPassword
            // 
            this.firstCardPassword.Location = new System.Drawing.Point(20, 220);
            this.firstCardPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstCardPassword.Mask = "0000";
            this.firstCardPassword.Name = "firstCardPassword";
            this.firstCardPassword.Size = new System.Drawing.Size(204, 22);
            this.firstCardPassword.TabIndex = 46;
            this.firstCardPassword.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Карта 1";
            // 
            // typeFirstCard
            // 
            this.typeFirstCard.Items.AddRange(new object[] {
            "Обычная карта",
            "Кредитная кредитная"});
            this.typeFirstCard.Location = new System.Drawing.Point(19, 64);
            this.typeFirstCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeFirstCard.Name = "typeFirstCard";
            this.typeFirstCard.Size = new System.Drawing.Size(207, 24);
            this.typeFirstCard.TabIndex = 29;
            this.typeFirstCard.SelectedIndexChanged += new System.EventHandler(this.typeFirstCard_SelectedIndexChanged);
            // 
            // firstCardBalance
            // 
            this.firstCardBalance.Location = new System.Drawing.Point(19, 169);
            this.firstCardBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstCardBalance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.firstCardBalance.Name = "firstCardBalance";
            this.firstCardBalance.Size = new System.Drawing.Size(205, 22);
            this.firstCardBalance.TabIndex = 30;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(19, 98);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 17);
            this.label24.TabIndex = 40;
            this.label24.Text = "Номер";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Баланс:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 32;
            this.label17.Text = "Тип:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 199);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Пароль:";
            this.label20.UseWaitCursor = true;
            // 
            // firstCardNumber
            // 
            this.firstCardNumber.Location = new System.Drawing.Point(19, 119);
            this.firstCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstCardNumber.Name = "firstCardNumber";
            this.firstCardNumber.Size = new System.Drawing.Size(207, 22);
            this.firstCardNumber.TabIndex = 37;
            // 
            // errorlabelCardFirst
            // 
            this.errorlabelCardFirst.AutoSize = true;
            this.errorlabelCardFirst.ForeColor = System.Drawing.Color.Red;
            this.errorlabelCardFirst.Location = new System.Drawing.Point(25, 426);
            this.errorlabelCardFirst.Name = "errorlabelCardFirst";
            this.errorlabelCardFirst.Size = new System.Drawing.Size(0, 17);
            this.errorlabelCardFirst.TabIndex = 63;
            // 
            // errorLabelCardSecond
            // 
            this.errorLabelCardSecond.AutoSize = true;
            this.errorLabelCardSecond.ForeColor = System.Drawing.Color.Red;
            this.errorLabelCardSecond.Location = new System.Drawing.Point(280, 426);
            this.errorLabelCardSecond.Name = "errorLabelCardSecond";
            this.errorLabelCardSecond.Size = new System.Drawing.Size(0, 17);
            this.errorLabelCardSecond.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 85);
            this.label1.TabIndex = 49;
            this.label1.Text = "Заполните формы \r\nдля карты1 и карты2, \r\nзатем нажмите кнопку начать.\r\nЧтобы восп" +
    "ользоваться\r\nбанкоматом нажмите на карту. \r\n";
            // 
            // StartSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabelCardSecond);
            this.Controls.Add(this.errorlabelCardFirst);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.RemuveBtnSecondCard);
            this.Controls.Add(this.CreateBtnSecondCard);
            this.Controls.Add(this.RemuveBtnFirstCard);
            this.Controls.Add(this.CreateBtnFirstCard);
            this.Controls.Add(this.secondCardPanel);
            this.Controls.Add(this.firstCardPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StartSettingsDialog";
            this.Text = "ATM Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartSettingsDialog_FormClosed);
            this.secondCardPanel.ResumeLayout(false);
            this.secondCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCardBalance)).EndInit();
            this.firstCardPanel.ResumeLayout(false);
            this.firstCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstCardBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button RemuveBtnSecondCard;
        private System.Windows.Forms.Button CreateBtnSecondCard;
        private System.Windows.Forms.Button RemuveBtnFirstCard;
        private System.Windows.Forms.Button CreateBtnFirstCard;
        private System.Windows.Forms.Panel secondCardPanel;
        private System.Windows.Forms.NumericUpDown secondCardLimit;
        private System.Windows.Forms.Label label30;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox typeSecondCard;
        private System.Windows.Forms.NumericUpDown secondCardBalance;
        private System.Windows.Forms.MaskedTextBox secondCardPassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox secondCardNumber;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel firstCardPanel;
        private System.Windows.Forms.NumericUpDown firstCardLimit;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.MaskedTextBox firstCardPassword;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox typeFirstCard;
        private System.Windows.Forms.NumericUpDown firstCardBalance;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox firstCardNumber;
        private System.Windows.Forms.Label errorlabelCardFirst;
        private System.Windows.Forms.Label errorLabelCardSecond;
        private System.Windows.Forms.Label label1;
    }
}