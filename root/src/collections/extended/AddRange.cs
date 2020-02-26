// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;
    
    partial class RootCollections
    {
        /// <summary>
        /// Adds a stream of items to a set
        /// </summary>
        /// <typeparam name="T">The item type</typeparam>
        /// <param name="set">The set to which items will be added</param>
        /// <param name="items">The items to add</param>
        [MethodImpl(Inline)]
        public static ISet<T> AddRange<T>(this ISet<T> set, IEnumerable<T> items)
        {
            items.Iterate(item => set.Add(item));
            return set;
        }
    }
}