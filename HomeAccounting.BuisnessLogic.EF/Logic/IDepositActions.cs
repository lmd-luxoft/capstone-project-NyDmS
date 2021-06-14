using System;
using System.Collections.Generic;
using System.Text;

namespace Ef
{
    /// <summary>
    /// Действия с депозитом
    /// </summary>
    public interface IDepositActions
    {
        /// <summary>
        ///  Добавим
        /// </summary>
        /// <param name="Name">Аккаунт - Наименование</param>
        /// <param name="Balance">Аккаунт - Баланс</param>
        /// <param name="Number">Аккаунт - Номер</param>
        /// <param name="Procent">Депозит - Процент</param>
        /// <param name="ProcentType">Депозит - Тип процента</param>
        public void AddDeposit(string name, int balance, int number, int procent, string procentType);
        /// <summary>
        /// Редактируем
        /// </summary>
        /// <param name="Name">Аккаунт - Наименование</param>
        /// <param name="Balance">Аккаунт - Баланс</param>
        /// <param name="Number">Аккаунт - Номер</param>
        /// <param name="Procent">Депозит - Процент</param>
        /// <param name="ProcentType">Депозит - Тип процента</param>
        public void EditDeposit(int id, string name, int balance, int number, int procent, string procentType);
        /// <summary>
        /// Удаляем 
        /// </summary>
        public void RemoveDeposit(int Id);
    }
}
