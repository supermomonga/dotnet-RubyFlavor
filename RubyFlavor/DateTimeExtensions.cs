using System;
using System.Collections.Generic;
using System.Text;

namespace RubyFlavor
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Date/i/upto.html
        /// Default step is 1 day.
        /// </summary>
        public static IEnumerable<DateTime> UpTo(this DateTime from, DateTime to, TimeSpan? step = null)
        {
            var _step = step ?? TimeSpan.FromDays(1);
            var cursor = from;
            while(cursor.CompareTo(to) <= 0 && cursor.CompareTo(from) >= 0)
            {
                yield return cursor;
                cursor += _step;
            }
        }

        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Integer/i/downto.html
        /// Default step is 1 day.
        /// </summary>
        public static IEnumerable<DateTime> DownTo(this DateTime from, DateTime to, TimeSpan? step = null)
        {
            var _step = step ?? TimeSpan.FromDays(1);
            var cursor = from;
            while(cursor.CompareTo(to) >= 0 && cursor.CompareTo(from) <= 0)
            {
                yield return cursor;
                cursor -= _step;
            }
        }
    }
}
