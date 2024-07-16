using System;
using System.Collections.Generic;
using System.Linq;

namespace RubyFlavor;
internal class ChunkedList<TKey, TElement> : List<TElement>, IGrouping<TKey, TElement>
{
    public TKey Key { get; set; }
}

public static class IEnumerableExtensions
{
    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/chunk.html
    /// </summary>
    public static IEnumerable<IGrouping<TKey, TElement>> Chunk<TElement, TKey>(this IEnumerable<TElement> xs, Func<TElement, TKey> keySelector)
    {
        ChunkedList<TKey, TElement> chunkedListState = null;
        foreach (var x in xs)
        {
            var key = keySelector.Invoke(x);
            if (chunkedListState == null)
            {
                chunkedListState = new ChunkedList<TKey, TElement>() { Key = key };
            }
            else if (!key.Equals(chunkedListState.Key))
            {
                yield return chunkedListState;
                chunkedListState = new ChunkedList<TKey, TElement>() { Key = key };
            }
            chunkedListState.Add(x);
        }
        if (chunkedListState != null)
        {
            yield return chunkedListState;
        }
    }

    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/collect.html
    /// </summary>
    public static IEnumerable<TResult> Collect<TSource, TResult>(this IEnumerable<TSource> xs, Func<TSource, TResult> selector)
        => xs.Select(selector);

    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_cons.html
    /// </summary>
    public static IEnumerable<IEnumerable<T>> EachConsecutive<T>(this IEnumerable<T> xs, int length)
    {
        var count = xs.Count();
        for (var i = 0; i < count - length + 1; i++)
        {
            yield return xs.Skip(i).Take(length);
        }
    }

    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/each_slice.html
    /// </summary>
    public static IEnumerable<IEnumerable<T>> EachSlice<T>(this IEnumerable<T> xs, int length)
    {
        var count = xs.Count();
        for (var i = 0; i < count; i += length)
        {
            yield return xs.Skip(i).Take(length);
        }
    }

    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Enumerator/i/with_index.html
    /// </summary>
    public static IEnumerable<(T, int)> WithIndex<T>(this IEnumerable<T> xs, int offset = 0)
    {
        foreach (var x in xs)
        {
            yield return (x, offset++);
        }
    }

    /// <summary>
    /// https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/one=3f.html
    /// </summary>
    public static bool One<T>(this IEnumerable<T> xs)
        => xs.Count() == 1;

    /// <summary>
    /// https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/one=3f.html
    /// </summary>
    public static bool One<T>(this IEnumerable<T> xs, Func<T, bool> predicate)
        => xs.Count(predicate) == 1;

    /// <summary>
    /// https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/none=3f.html
    /// </summary>
    public static bool None<T>(this IEnumerable<T> xs)
        => !xs.Any();

    /// <summary>
    /// https://docs.ruby-lang.org/ja/latest/method/Enumerable/i/none=3f.html
    /// </summary>
    public static bool None<T>(this IEnumerable<T> xs, Func<T, bool> predicate)
        => !xs.Any(predicate);

}
