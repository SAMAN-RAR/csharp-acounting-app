using System;
using System.Globalization;

namespace Accounting.Utilities.Conventor
{
    public static class DateConventor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value).ToString("00");
        }
        public static DateTime ToMiladi(DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, new PersianCalendar());
        }
    }
}
