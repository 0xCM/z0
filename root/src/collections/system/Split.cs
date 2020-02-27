// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    partial class SystemCollections
    {
        /// <summary>
        /// Splits the input into two parts according to a supplied predicate
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="items">The items to evaluate</param>
        /// <param name="predicate">The predicate used in the evaluation</param>
        /// <returns>A 2-tuple whose first member reflects the items that evaluated to false 
        /// and whose second member reflects the items that evaluated to true</returns>
        public static (IEnumerable<T> @false, IEnumerable<T> @true) Split<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            var f = new List<T>();
            var t = new List<T>();
            foreach (var item in items)
                if (predicate(item))
                    t.Add(item);
                else
                    f.Add(item);
            return (f, t);
        }
    }
}