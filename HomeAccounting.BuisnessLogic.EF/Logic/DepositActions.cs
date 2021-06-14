using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAccounting.BuisnessLogic.EF
{
    /// <summary>
    /// Действия с депозитом
    /// </summary>
    public class DepositActions: IDepositActions
    {
        /// <summary>
        ///  Добавим
        /// </summary>
        /// <param name="Name">Аккаунт - Наименование</param>
        /// <param name="Balance">Аккаунт - Баланс</param>
        /// <param name="Number">Аккаунт - Номер</param>
        /// <param name="Procent">Депозит - Процент</param>
        /// <param name="ProcentType">Депозит - Тип процента</param>
        public void AddDeposit(string name, int balance, int number, int procent, string procentType)
        {
            using (EF db = new EF())
            {
                Deposit dep = new Deposit { CreateDate = DateTime.Now, Name = name, Balance = balance, Number = number, Procent = procent, ProcentType = procentType };

                db.Deposits.Add(dep);

                db.SaveChanges();
            }
        }
        /// <summary>
        /// Редактируем
        /// </summary>
        /// <param name="Name">Аккаунт - Наименование</param>
        /// <param name="Balance">Аккаунт - Баланс</param>
        /// <param name="Number">Аккаунт - Номер</param>
        /// <param name="Procent">Депозит - Процент</param>
        /// <param name="ProcentType">Депозит - Тип процента</param>
        public void EditDeposit(int id, string name, int balance, int number, int procent, string procentType)
        {
            using (EF db = new EF())
            {
                Deposit deposit = db.Deposits.Where(x=>x.Id == id).FirstOrDefault();

                if (deposit != null)
                {
                    deposit.Name = name;
                    deposit.Balance = balance;
                    deposit.Number = number;
                    deposit.Procent = procent;
                    deposit.ProcentType = procentType;

                    db.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Удаляем 
        /// </summary>
        public void RemoveDeposit(int id)
        {
            using (EF db = new EF())
            {
                Deposit deposit = db.Deposits.Where(x => x.Id == id).FirstOrDefault();
                if (deposit != null)
                {
                    db.Deposits.Remove(deposit);
                    db.SaveChanges();
                }
            }
        }
    }
}
