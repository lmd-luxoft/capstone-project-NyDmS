using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccounting.BuisnessLogic.EF
{
    /// <summary>
    /// Действия с депозитом
    /// </summary>
    public class DepositActions: IDepositActions
    {
        private void sendMsg(string msg)
        {

            MailAddress from = new MailAddress("mail@mail.ru", "Some");

            MailAddress to = new MailAddress("mail@mail.ru");

            MailMessage m = new MailMessage(from, to);

            m.Subject = "Тест";

            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";

            SmtpClient smtp = new SmtpClient("mail@mail.ru", 587);

            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("mail@mail.ru", "password");

            smtp.Send(m);
        }

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

            Task sendMsgTask = new Task(() => sendMsg("Текст сообщения"));
            sendMsgTask.Start();
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
