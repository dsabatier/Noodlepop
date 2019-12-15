using System.Collections.Generic;

public static class Extensions
{
    /// <summary>
    /// Selects first from a list, or the default provided
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="alternate"></param>
    /// <returns></returns>
    public static T FirstOr<T>(this IEnumerable<T> source, T alternate)
    {
        foreach (T t in source)
            return t;
        return alternate;
    }
}
