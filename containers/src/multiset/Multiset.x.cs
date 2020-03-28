// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Core;
    
    public static class MultisetX
    {
        /// <summary>
        /// Creates a multiset from a source sequence
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The data type</typeparam>
        public static Multiset<T> ToMultiSet<T>(this IEnumerable<T> src)
            => new Multiset<T>(src);
    }
}