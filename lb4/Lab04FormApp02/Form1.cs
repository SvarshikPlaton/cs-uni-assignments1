/******************************************************/
/*               Лабораторная работа № 4              */
/*                      Интерфейсы                    */
/*                      Задание 2                     */
/*       Выполнил студент гр. 515ст2 Немов Н.Р.       */
/******************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04FormApp2
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public Form1()
        {
            InitializeComponent();
            selectTypeAccount.SelectedIndex = 0;
        }

        /// <summary>
        /// Операция создания экземпляра банковского счёта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccont_Click(object sender, EventArgs e)
        {
            settingAccount.Enabled = false;
            settingDeposit.Enabled = false;
            settingBankOperations.Enabled = false;
            closeAccount.Enabled = false;

            double cost;
            string name;
            try
            {
                name = textName.Text;
                if (name == "")
                {
                    MessageBox.Show("Пустое значение для имени!");
                    return;
                }

                cost = double.Parse(textCount.Text);

                switch(selectTypeAccount.SelectedIndex)
                {
                    case 0:
                        bankAccounts.Add(new DepositAccount(name, cost));
                        settingDeposit.Enabled = true;
                        break;
                    case 1:
                        bankAccounts.Add(new CurrentAccount(name, cost));
                        settingBankOperations.Enabled = true;
                        break;
                    case 2:
                        bankAccounts.Add(new CreditCard(name, cost));
                        settingDeposit.Enabled = true;
                        settingBankOperations.Enabled = true;
                        break;
                }
                Hold(bankAccounts.Count-1);

                int i = 0;
                bankAccountChange.Items.Clear();
                foreach (var account in bankAccounts)
                {
                    i++;
                    bankAccountChange.Items.Add("Счёт #" + i.ToString());
                }
                settingAccount.Enabled = true;
                textName.Text = "";
                textCount.Text = "";
                selectTypeAccount.SelectedIndex = 0;
                bankAccountChange.SelectedIndex = bankAccounts.Count - 1;
            }
            catch(FormatException)
            {
                MessageBox.Show("Неправильный формат числа!");
            }
            catch(OverflowException)
            {
                MessageBox.Show("Число слишком большое!");
            }
            catch(ArgumentException)
            {
                MessageBox.Show("Число не введено!");
            }
        }

        /// <summary>
        /// При выбор экземпляра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bankAccountChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hold(bankAccountChange.SelectedIndex);
        }

        /// <summary>
        /// Настройки при выборе экземпляра.
        /// </summary>
        /// <param name="a"></param>
        void Hold(int a)
        {
            closeAccount.Enabled = true;
            costView.Text = $"{bankAccounts[a].GetCost():N2} $";
            nameView.Text = bankAccounts[a].GetName();

            settingDeposit.Text = "Депозит";

            if (bankAccounts[a] is DepositAccount bankAccount)
            {
                settingDeposit.Enabled = true;
                settingBankOperations.Enabled = false;

                settingDeposit.Text = $"Депозит {bankAccount.GetInterestRate()}%";
                rate.Text = bankAccount.GetInterestRate().ToString();
                cardPicture.Image = Properties.Resources._1;
            }

            if (bankAccounts[a] is CurrentAccount currentAccount)
            {
                settingDeposit.Enabled = false;
                settingBankOperations.Enabled = true;
                cardPicture.Image = Properties.Resources._2;
            }

            if (bankAccounts[a] is CreditCard creditCard)
            {
                settingDeposit.Enabled = true;
                settingBankOperations.Enabled = true;
                cardPicture.Image = Properties.Resources._3;
            }
        }

        /// <summary>
        /// Применить новую процентую ставку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptRate_Click(object sender, EventArgs e)
        {
            try
            {
                var index = bankAccountChange.SelectedIndex;
                var newRate = double.Parse(rate.Text);

                var account = bankAccounts[index] as IDeposit;
                account.SetRate(newRate);

                settingDeposit.Text = $"Депозит {newRate}%";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат числа!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Число слишком большое!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число не введено!");
            }
        }

        /// <summary>
        /// Процентное начисление депозита.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void makeDeposit_Click(object sender, EventArgs e)
        {
            var index = bankAccountChange.SelectedIndex;
            var account = bankAccounts[index] as IDeposit;

            account.MakeDeposit();

            costView.Text = $"{bankAccounts[index].GetCost():N2} $";
        }

        /// <summary>
        /// Применить пополнеие средств счёта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptPut_Click(object sender, EventArgs e)
        {
            try
            {
                var index = bankAccountChange.SelectedIndex;
                var account = bankAccounts[index] as IBankAccount;

                account.Put(double.Parse(put.Text));

                costView.Text = $"{bankAccounts[index].GetCost():N2} $";
                put.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат числа!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Число слишком большое!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число не введено!");
            }
        }

        /// <summary>
        /// Применить списание средств со счёта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                var index = bankAccountChange.SelectedIndex;
                var account = bankAccounts[index] as IBankAccount;

                account.Withdraw(double.Parse(withdraw.Text));

                costView.Text = $"{bankAccounts[index].GetCost():N2} $";
                withdraw.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат числа!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Число слишком большое!");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Число не введено!");
            }
        }

        /// <summary>
        /// Закрыть счёт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            var index = bankAccountChange.SelectedIndex;
            bankAccounts[index].Close();
            costView.Text = $"{bankAccounts[index].GetCost():N2} $";
        }
    }
}
