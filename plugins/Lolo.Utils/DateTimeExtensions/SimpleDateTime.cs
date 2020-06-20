using System;
using System.Collections.Generic;
using System.Text;

namespace Lolo.Utils.DateTimeExtensions
{
    /// <summary>
    /// 获取本日 昨日 本周 上周 本月 上月
    /// </summary>
    public class SimpleDateTime
    {
        public DateTime Now { get { return DateTime.Now; } }
        /// <summary>
        /// 本日
        /// </summary>
        public DateTime ToDay { get { return DateTime.Today; } }
        /// <summary>
        /// 昨日
        /// </summary>
        public DateTime YesterDay { get { return DateTime.Today.AddDays(-1); } }
        /// <summary>
        /// 本周
        /// </summary>
        public DateTime ThisWeek { get { return DateTime.Today.AddDays(-(int)DateTime.Now.DayOfWeek); } }
        /// <summary>
        /// 上周
        /// </summary>
        public DateTime LastWeek { get { return ThisWeek.AddDays(-7); } }
        /// <summary>
        /// 本月
        /// </summary>
        public DateTime CurrentMonth { get { return new DateTime(ToDay.Year, ToDay.Month, 1); } }
        /// <summary>
        /// 上月
        /// </summary>
        public DateTime LastMonth { get { return CurrentMonth.AddMonths(-1); } }
    }
}
