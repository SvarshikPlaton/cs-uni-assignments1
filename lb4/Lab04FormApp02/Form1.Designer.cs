
namespace Lab04FormApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardPicture = new System.Windows.Forms.PictureBox();
            this.nameView = new System.Windows.Forms.Label();
            this.costView = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeAccount = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectTypeAccount = new System.Windows.Forms.ComboBox();
            this.createAccont = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.settingAccount = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bankAccountChange = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.acceptRate = new System.Windows.Forms.Button();
            this.makeDeposit = new System.Windows.Forms.Button();
            this.settingDeposit = new System.Windows.Forms.GroupBox();
            this.settingBankOperations = new System.Windows.Forms.GroupBox();
            this.acceptWithdraw = new System.Windows.Forms.Button();
            this.acceptPut = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.withdraw = new System.Windows.Forms.TextBox();
            this.put = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.closeAccount.SuspendLayout();
            this.settingAccount.SuspendLayout();
            this.settingDeposit.SuspendLayout();
            this.settingBankOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPicture
            // 
            this.cardPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardPicture.Image = global::Lab04FormApp2.Properties.Resources._0;
            this.cardPicture.Location = new System.Drawing.Point(0, 0);
            this.cardPicture.Name = "cardPicture";
            this.cardPicture.Size = new System.Drawing.Size(512, 324);
            this.cardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cardPicture.TabIndex = 0;
            this.cardPicture.TabStop = false;
            // 
            // nameView
            // 
            this.nameView.BackColor = System.Drawing.Color.White;
            this.nameView.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameView.Location = new System.Drawing.Point(62, 231);
            this.nameView.Name = "nameView";
            this.nameView.Size = new System.Drawing.Size(190, 15);
            this.nameView.TabIndex = 1;
            this.nameView.Text = " ";
            // 
            // costView
            // 
            this.costView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.costView.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.costView.ForeColor = System.Drawing.Color.White;
            this.costView.Location = new System.Drawing.Point(62, 81);
            this.costView.Name = "costView";
            this.costView.Size = new System.Drawing.Size(400, 32);
            this.costView.TabIndex = 2;
            this.costView.Text = " ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.closeAccount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.selectTypeAccount);
            this.groupBox1.Controls.Add(this.createAccont);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textCount);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 298);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание счёта";
            // 
            // closeAccount
            // 
            this.closeAccount.Controls.Add(this.closeButton);
            this.closeAccount.Enabled = false;
            this.closeAccount.Location = new System.Drawing.Point(0, 194);
            this.closeAccount.Name = "closeAccount";
            this.closeAccount.Size = new System.Drawing.Size(252, 104);
            this.closeAccount.TabIndex = 7;
            this.closeAccount.TabStop = false;
            this.closeAccount.Text = "Закрытие счёта";
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(12, 44);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(229, 30);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Закрыть выбранный счёт";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Тип счёта:";
            // 
            // selectTypeAccount
            // 
            this.selectTypeAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTypeAccount.FormattingEnabled = true;
            this.selectTypeAccount.Items.AddRange(new object[] {
            "Депозитный счет",
            "Текущий счет",
            "Карточный счет"});
            this.selectTypeAccount.Location = new System.Drawing.Point(115, 110);
            this.selectTypeAccount.Name = "selectTypeAccount";
            this.selectTypeAccount.Size = new System.Drawing.Size(131, 23);
            this.selectTypeAccount.TabIndex = 5;
            this.selectTypeAccount.Text = "Депозитный счет";
            // 
            // createAccont
            // 
            this.createAccont.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccont.Location = new System.Drawing.Point(115, 155);
            this.createAccont.Name = "createAccont";
            this.createAccont.Size = new System.Drawing.Size(131, 30);
            this.createAccont.TabIndex = 4;
            this.createAccont.Text = "Создать счёт";
            this.createAccont.UseVisualStyleBackColor = true;
            this.createAccont.Click += new System.EventHandler(this.createAccont_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Баланс:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Владелец:";
            // 
            // textCount
            // 
            this.textCount.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCount.Location = new System.Drawing.Point(115, 79);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(131, 22);
            this.textCount.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textName.Location = new System.Drawing.Point(115, 47);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(131, 22);
            this.textName.TabIndex = 0;
            // 
            // settingAccount
            // 
            this.settingAccount.BackColor = System.Drawing.Color.White;
            this.settingAccount.Controls.Add(this.label5);
            this.settingAccount.Controls.Add(this.bankAccountChange);
            this.settingAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingAccount.Enabled = false;
            this.settingAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingAccount.Location = new System.Drawing.Point(252, 324);
            this.settingAccount.Name = "settingAccount";
            this.settingAccount.Size = new System.Drawing.Size(260, 66);
            this.settingAccount.TabIndex = 4;
            this.settingAccount.TabStop = false;
            this.settingAccount.Text = "Выбрать";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Счёт:";
            // 
            // bankAccountChange
            // 
            this.bankAccountChange.FormattingEnabled = true;
            this.bankAccountChange.Location = new System.Drawing.Point(78, 21);
            this.bankAccountChange.Name = "bankAccountChange";
            this.bankAccountChange.Size = new System.Drawing.Size(176, 24);
            this.bankAccountChange.TabIndex = 0;
            this.bankAccountChange.Text = "Не выбрано";
            this.bankAccountChange.SelectedIndexChanged += new System.EventHandler(this.bankAccountChange_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Процентная ставка:";
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rate.Location = new System.Drawing.Point(164, 28);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(84, 22);
            this.rate.TabIndex = 3;
            // 
            // acceptRate
            // 
            this.acceptRate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptRate.Location = new System.Drawing.Point(19, 60);
            this.acceptRate.Name = "acceptRate";
            this.acceptRate.Size = new System.Drawing.Size(229, 30);
            this.acceptRate.TabIndex = 5;
            this.acceptRate.Text = "Применить";
            this.acceptRate.UseVisualStyleBackColor = true;
            this.acceptRate.Click += new System.EventHandler(this.acceptRate_Click);
            // 
            // makeDeposit
            // 
            this.makeDeposit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.makeDeposit.Location = new System.Drawing.Point(19, 89);
            this.makeDeposit.Name = "makeDeposit";
            this.makeDeposit.Size = new System.Drawing.Size(229, 30);
            this.makeDeposit.TabIndex = 6;
            this.makeDeposit.Text = "Начислить депозит";
            this.makeDeposit.UseVisualStyleBackColor = true;
            this.makeDeposit.Click += new System.EventHandler(this.makeDeposit_Click);
            // 
            // settingDeposit
            // 
            this.settingDeposit.BackColor = System.Drawing.Color.White;
            this.settingDeposit.Controls.Add(this.makeDeposit);
            this.settingDeposit.Controls.Add(this.rate);
            this.settingDeposit.Controls.Add(this.acceptRate);
            this.settingDeposit.Controls.Add(this.label6);
            this.settingDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingDeposit.Enabled = false;
            this.settingDeposit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingDeposit.Location = new System.Drawing.Point(252, 390);
            this.settingDeposit.Name = "settingDeposit";
            this.settingDeposit.Size = new System.Drawing.Size(260, 128);
            this.settingDeposit.TabIndex = 5;
            this.settingDeposit.TabStop = false;
            this.settingDeposit.Text = "Депозит";
            // 
            // settingBankOperations
            // 
            this.settingBankOperations.BackColor = System.Drawing.Color.White;
            this.settingBankOperations.Controls.Add(this.acceptWithdraw);
            this.settingBankOperations.Controls.Add(this.acceptPut);
            this.settingBankOperations.Controls.Add(this.label7);
            this.settingBankOperations.Controls.Add(this.label8);
            this.settingBankOperations.Controls.Add(this.withdraw);
            this.settingBankOperations.Controls.Add(this.put);
            this.settingBankOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingBankOperations.Enabled = false;
            this.settingBankOperations.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingBankOperations.Location = new System.Drawing.Point(252, 518);
            this.settingBankOperations.Name = "settingBankOperations";
            this.settingBankOperations.Size = new System.Drawing.Size(260, 98);
            this.settingBankOperations.TabIndex = 6;
            this.settingBankOperations.TabStop = false;
            this.settingBankOperations.Text = "Банковские операции";
            // 
            // acceptWithdraw
            // 
            this.acceptWithdraw.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptWithdraw.Location = new System.Drawing.Point(172, 64);
            this.acceptWithdraw.Name = "acceptWithdraw";
            this.acceptWithdraw.Size = new System.Drawing.Size(82, 23);
            this.acceptWithdraw.TabIndex = 9;
            this.acceptWithdraw.Text = "Подтвердить";
            this.acceptWithdraw.UseVisualStyleBackColor = true;
            this.acceptWithdraw.Click += new System.EventHandler(this.acceptWithdraw_Click);
            // 
            // acceptPut
            // 
            this.acceptPut.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptPut.Location = new System.Drawing.Point(172, 31);
            this.acceptPut.Name = "acceptPut";
            this.acceptPut.Size = new System.Drawing.Size(82, 23);
            this.acceptPut.TabIndex = 8;
            this.acceptPut.Text = "Подтвердить";
            this.acceptPut.UseVisualStyleBackColor = true;
            this.acceptPut.Click += new System.EventHandler(this.acceptPut_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Снять:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Положить:";
            // 
            // withdraw
            // 
            this.withdraw.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw.Location = new System.Drawing.Point(90, 64);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(76, 22);
            this.withdraw.TabIndex = 5;
            // 
            // put
            // 
            this.put.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.put.Location = new System.Drawing.Point(90, 32);
            this.put.Name = "put";
            this.put.Size = new System.Drawing.Size(76, 22);
            this.put.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 622);
            this.Controls.Add(this.settingBankOperations);
            this.Controls.Add(this.settingDeposit);
            this.Controls.Add(this.settingAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.costView);
            this.Controls.Add(this.nameView);
            this.Controls.Add(this.cardPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account";
            ((System.ComponentModel.ISupportInitialize)(this.cardPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.closeAccount.ResumeLayout(false);
            this.settingAccount.ResumeLayout(false);
            this.settingAccount.PerformLayout();
            this.settingDeposit.ResumeLayout(false);
            this.settingDeposit.PerformLayout();
            this.settingBankOperations.ResumeLayout(false);
            this.settingBankOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardPicture;
        private System.Windows.Forms.Label nameView;
        private System.Windows.Forms.Label costView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createAccont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.GroupBox settingAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox bankAccountChange;
        private System.Windows.Forms.Button acceptRate;
        private System.Windows.Forms.Button makeDeposit;
        private System.Windows.Forms.GroupBox settingDeposit;
        private System.Windows.Forms.GroupBox settingBankOperations;
        private System.Windows.Forms.Button acceptWithdraw;
        private System.Windows.Forms.Button acceptPut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox withdraw;
        private System.Windows.Forms.TextBox put;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectTypeAccount;
        private System.Windows.Forms.GroupBox closeAccount;
        private System.Windows.Forms.Button closeButton;
    }
}

