using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace RubyFlavor
{
    public static class IEnumerableExtension
    {
        /// <summary>
        /// https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/chunk.html
        /// </summary>
        public static IEnumerable<(TKey, IEnumerable<T1>)> Chunk<T1, TKey>(this IEnumerable<T1> xs, Func<T1, TKey> predicate)
        {
            if (xs.Count() > 0)
            {
                var keyState = predicate.Invoke(xs.First());
                var elementState = new List<T1>();
                foreach (var x in xs)
                {
                    var key = predicate.Invoke(x);
                    if (key.Equals(keyState))
                    {
                        elementState.Add(x);
                    }
                    else
                    {
                        yield return (keyState, elementState);
                        keyState = key;
                        elementState = new List<T1>();
                    }
                }
            }
        }
        public static IEnumerable<(T, int)> WithIndex<T>(this IEnumerable<T> xs, int offset = 0)
        => xs.Select((x, i) => (x, i + offset));

    }
}
