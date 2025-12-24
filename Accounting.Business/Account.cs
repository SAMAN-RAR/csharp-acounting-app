using System;
using System.Linq;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;

namespace Accounting.Business
{
    public class Account
    {
        public static AccountingViewModel MonthlyReport()
        {
            AccountingViewModel rp = new AccountingViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);


                var recieve = db.AccountingRepository.Get(a => a.TypeID == 1 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount).ToList();
                var payed = db.AccountingRepository.Get(a => a.TypeID == 2 && a.DateTime >= startDate && a.DateTime <= endDate).Select(a => a.Amount).ToList();

                rp.Recieve = recieve.Sum();
                rp.Pay = payed.Sum();
                rp.AccountBalance = (recieve.Sum() - payed.Sum());

            }

            return rp;
        }

        public static AccountingViewModel TotalReport()
        {
            AccountingViewModel rp = new AccountingViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);


                var recieve = db.AccountingRepository.Get(a => a.TypeID == 1).Select(a => a.Amount).ToList();
                var payed = db.AccountingRepository.Get(a => a.TypeID == 2).Select(a => a.Amount).ToList();

                rp.Recieve = recieve.Sum();
                rp.Pay = payed.Sum();
                rp.AccountBalance = (recieve.Sum() - payed.Sum());

            }

            return rp;
        }
    }
}
