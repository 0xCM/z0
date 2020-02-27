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
        /// Applies a function to an input sequence to yield a transformed output sequence
        /// </summary>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="src">The source sequence</param>
        /// <param name="f">The mapping function</param>
        public static T[] Map<S, T>(this IEnumerable<S> src, Func<S, T> f)
            => src.Select(item => f(item)).ToArray();

        /// <summary>
        /// Transforms an array via an indexed mapping function
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="f">The mapping function</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static T[] Mapi<S, T>(this S[] src, Func<int,S, T> f)
        {
            var dst = new T[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(i,src[i]);
            return dst;
        }

        // public static T[] Mapi<S, T>(this S[] src, Func<int,S, T> f, bool pll)
        // {
        //     if(!pll)
        //         return src.Mapi(f);
            
        //     var dst = new T[src.Length];
        //     var pllQuery = from index in range(src.Length).AsParallel()
        //                     select (index, value: f(index, src[index]));
        //     var results = pllQuery.ToArray();
        //     foreach(var result in results)
        //         dst[result.index] = result.value;
        //     return dst;
        // }

        /// <summary>
        /// Creates a read-only list from a source sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        public static IReadOnlyList<T> ToReadOnlyList<T>(this IEnumerable<T> src)
            => src.ToList();
    }
}