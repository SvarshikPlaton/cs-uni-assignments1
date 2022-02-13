using System;

namespace Lab04FormApp2
{
    /// <summary>
    /// Интерфейс для счёта депозита.
    /// </summary>
    interface IDeposit
    {
        /// <summary>
        /// Процентное начисление депозита.
        /// </summary>
        void MakeDeposit();

        /// <summary>
        /// Установить процентную ставку.
        /// </summary>
        /// <param name="rate">Процентная ставка.</param>
        void SetRate(double rate);
    }

    /// <summary>
    /// Интерфейс для текущего счёта.
    /// </summary>
    interface IBankAccount
    {
        /// <summary>
        /// Пополнение счёта.
        /// </summary>
        /// <param name="amount"> Сумма пополнения.</param>
        void Put(double amount);
        /// <summary>
        /// Снятие с счёта.
        /// </summary>
        /// <param name="amount">Сумма снятия.</param>
        void Withdraw(double amount);
    }

    /// <summary>
    /// Банковский счёт.
    /// </summary>
    abstract class BankAccount
    {
        /// <summary>
        /// Владелец счёта.
        /// </summary>
        protected string name;
        /// <summary>
        /// Сумма счёта.
        /// </summary>
        protected double cost;
        
        /// <summary>
        /// Инициализация экземпляра банковского счёта без аргументов.
        /// </summary>
        public BankAccount()
        {
            name = "UNKNOWN";
            cost = 0;
        }

        /// <summary>
        /// Инициализация экземпляра банковского счёта.
        /// </summary>
        /// <param name="name">Владелец счёта.</param>
        /// <param name="cost">Сумма счёта.</param>
        public BankAccount(string name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }

        /// <summary>
        /// Получить имя владельца счёта.
        /// </summary>
        /// <returns>Имя владельца счёта.</returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Получить текущий баланс.
        /// </summary>
        /// <returns>Текущий баланс.</returns>
        public double GetCost()
        {
            return cost;
        }

        /// <summary>
        /// Заморозить счёт.
        /// </summary>
        /// <returns>Возврат текущего баланса.</returns>
        public double Close()
        {
            double cash = cost;
            cost = 0;
            return cash;
        }
    }

    /// <summary>
    /// Депозитный счёт.
    /// </summary>
    class DepositAccount : BankAccount, IDeposit
    {
        /// <summary>
        /// Процентная ставка.
        /// </summary>
        private double interestRate = 5;

        /// <summary>
        /// Инициализация депозитного счёта без аргументов.
        /// </summary>
        public DepositAccount():base() { }

        /// <summary>
        /// Инициализация депозитного счёта.
        /// </summary>
        /// <param name="name">Владелец счёта.</param>
        /// <param name="cost">Сумма счёта.</param>
        public DepositAccount(string name, double cost) : base(name, cost) { }

        /// <summary>
        /// Процентное начисление депозита.
        /// </summary>
        public void MakeDeposit()
        {
            cost += interestRate/100 * cost;
        }

        /// <summary>
        /// Процентное начисление депозита.
        /// </summary>
        public void SetRate(double rate)
        {
            interestRate = rate;
        }

        /// <summary>
        /// Получить значение процентной ставки.
        /// </summary>
        /// <returns>Процентная ставка.</returns>
        public double GetInterestRate()
        {
            return interestRate;
        }
    }

    /// <summary>
    /// Текущий счёт.
    /// </summary>
    class CurrentAccount : BankAccount, IBankAccount
    {
        /// <summary>
        /// Инициализация экземпляра текущего счёта без параметров.
        /// </summary>
        public CurrentAccount() : base() { }

        /// <summary>
        /// Инициализация экземпляра текущего счёта.
        /// </summary>
        /// <param name="name">Владелец счёта.</param>
        /// <param name="cost">Сумма счёта.</param>
        public CurrentAccount(string name, double cost) : base(name, cost) { }

        /// <summary>
        /// Пополнение счёта.
        /// </summary>
        /// <param name="amount"> Сумма пополнения.</param>
        public void Put(double amount)
        {
            cost += amount;
        }

        /// <summary>
        /// Снятие с счёта.
        /// </summary>
        /// <param name="amount">Сумма снятия.</param>
        public void Withdraw(double amount)
        {
            cost -= amount;
        }

    }

    /// <summary>
    /// Карточный счёт
    /// </summary>
    class CreditCard : BankAccount, IDeposit, IBankAccount
    {
        /// <summary>
        /// Процентная ставка.
        /// </summary>
        private double interestRate = 5;

        /// <summary>
        /// Инициализация экзмепляра карточного счёта без аргументов.
        /// </summary>
        public CreditCard() : base() { }

        /// <summary>
        /// Инициализация экземпляра карточного счёта.
        /// </summary>
        /// <param name="name">Владелец счёта.</param>
        /// <param name="cost">Сумма счёта.</param>
        public CreditCard(string name, double cost) : base(name, cost) { }

        /// <summary>
        /// Процентное начисление депозита.
        /// </summary>
        public void MakeDeposit()
        {
            cost += interestRate / 100 * cost;
        }

        /// <summary>
        /// Процентное начисление депозита.
        /// </summary>
        public void SetRate(double rate)
        {
            interestRate = rate;
        }

        /// <summary>
        /// Пополнение счёта.
        /// </summary>
        /// <param name="amount"> Сумма пополнения.</param>
        public void Put(double amount)
        {
            cost += amount;
        }

        /// <summary>
        /// Снятие с счёта.
        /// </summary>
        /// <param name="amount">Сумма снятия.</param>
        public void Withdraw(double amount)
        {
            cost -= amount;
        }

        /// <summary>
        /// Получить значение процентной ставки.
        /// </summary>
        /// <returns>Процентная ставка.</returns>
        public double GetInterestRate()
        {
            return interestRate;
        }
    }
}
