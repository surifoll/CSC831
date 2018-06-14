using System.Collections.Generic;

namespace UninformedSearch_CSC831.Util
{
    /// <summary>
    /// an extension to List to allow multiple additions on one line
    /// </summary>
    public static class ListExtensions
    {
        
        public static void AddMany<T>(this List<T> list, params T[] elements)
        {
            list.AddRange(elements);
        }
    }
}
