namespace RubyFlavor;

public static class ICollectionExtensions
{
    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Array/i/sample.html
    /// </summary>
    public static T Sample<T>(this ICollection<T> collection, Random? random = null)
    {
        if (collection.Count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        var index = (random ?? new()).Next(collection.Count);
        return collection.ElementAt(index);
    }


    /// <summary>
    ///   https://docs.ruby-lang.org/ja/latest/method/Array/i/sample.html
    /// </summary>
    public static IEnumerable<T> Sample<T>(this ICollection<T> collection, int count, Random? random = null)
    {
        if (collection.Count == 0)
        {
            throw new InvalidOperationException("The collection is empty.");
        }

        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count), "Count cannot be negative.");
        }

        var r = random ?? new();
        return collection.OrderBy(x => r.Next()).Take(count);
    }
}
