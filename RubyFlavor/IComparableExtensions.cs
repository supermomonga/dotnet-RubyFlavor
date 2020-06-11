using System;
using System.Collections.Generic;

namespace RubyFlavor
{
    public static class IComparableExtensions
    {
        /// <summary>
        ///   https://docs.ruby-lang.org/ja/latest/method/Integer/i/upto.html
        /// </summary>
        public static IEnumerable<TElement> UpTo<TElement>(this TElement from, TElement to, Func<TElement, TElement> stepper) where TElement : IComparable
        {
            var cursor = from;
            while(cursor.CompareTo(to) <= 0 && cursor.CompareTo(from) >= 0)
            {
                yield return cursor;
                cursor = stepper.Invoke(cursor);
            }
        }

        /// <summary>
        ///   https://docs.ruby-lang.org/ja/latest/method/Integer/i/upto.html
        /// </summary>
        public static IEnumerable<TElement> UpTo<TElement>(this TElement from, TElement to, dynamic stepper) where TElement : IComparable
        {
            var cursor = from;
            while(cursor.CompareTo(to) <= 0 && cursor.CompareTo(from) >= 0)
            {
                yield return cursor;
                cursor = (dynamic)cursor + stepper;
            }
        }

        /// <summary>
        ///   https://docs.ruby-lang.org/ja/latest/method/Integer/i/upto.html
        /// </summary>
        public static IEnumerable<TElement> DownTo<TElement>(this TElement from, TElement to, Func<TElement, TElement> stepper) where TElement : IComparable
        {
            var cursor = from;
            while(cursor.CompareTo(to) >= 0 && cursor.CompareTo(from) <= 0)
            {
                yield return cursor;
                cursor = stepper.Invoke(cursor);
            }
        }

        /// <summary>
        ///   https://docs.ruby-lang.org/ja/latest/method/Integer/i/upto.html
        /// </summary>
        public static IEnumerable<TElement> DownTo<TElement>(this TElement from, TElement to, dynamic stepper) where TElement : IComparable
        {
            var cursor = from;
            while(cursor.CompareTo(to) >= 0 && cursor.CompareTo(from) <= 0)
            {
                yield return cursor;
                cursor = (dynamic)cursor - stepper;
            }
        }
    }
}
