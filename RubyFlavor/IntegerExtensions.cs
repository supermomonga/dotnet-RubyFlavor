using System;
using System.Collections.Generic;
using System.Text;

namespace RubyFlavor
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Integer/i/upto.html
        /// </summary>
        public static IEnumerable<int> UpTo(this int from, int to, int step = 1)
        {
            var cursor = from;
            while(cursor.CompareTo(to) <= 0 && cursor.CompareTo(from) >= 0)
            {
                yield return cursor;
                cursor += step;
            }
        }

        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Integer/i/downto.html
        /// </summary>
        public static IEnumerable<int> DownTo(this int from, int to, int step = 1)
        {
            var cursor = from;
            while(cursor.CompareTo(to) >= 0 && cursor.CompareTo(from) <= 0)
            {
                yield return cursor;
                cursor -= step;
            }
        }

        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Integer/i/times.html
        /// </summary>
        public static IEnumerable<int> Times(this int receiver)
        {
            for (int i = 0; i < receiver; i++)
                yield return i;
        }
    }
}
