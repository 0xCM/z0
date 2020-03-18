// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class SystemCollections
    {

            
        /// <summary>
        /// Constructs an integrally-indexed stream from a source stream
        /// </summary>
        /// <param name="index">The 0-based element index</param>
        /// <param name="value">The indexed value</param>
        /// <typeparam name="T">The value type</typeparam>
        public static IEnumerable<(int index, T value)> Index<T>(this IEnumerable<T> src)
        {
            var i = 0;
            var it = src.GetEnumerator();            
            while(it.MoveNext())
                yield return (i++, it.Current);
        }
            

        /// <summary>
        /// Forces enumerable evaluation
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Force<T>(this IEnumerable<T> src)
            => src.ToArray();
 
        public static (IEnumerable<T> left, IEnumerable<T> right) Fork<T>(this IEnumerable<T> src)
            => (src, src);
        
        public static IEnumerable<T> Transform<S,T>(this IEnumerable<S> src, params Func<S,T>[] transformers)
            => src.Select(item => transformers.Select(t => t(item))).SelectMany(x => x);        
    }
}