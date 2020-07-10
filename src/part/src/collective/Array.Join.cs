//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    partial class XTend
    {
        /// <summary>
        /// Defines an array-sepecific join operator
        /// </summary>
        /// <param name="source"></param>
        /// <param name="selector"></param>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static T[] SelectMany<S,T>(this S[] source, Func<S, IEnumerable<T>> selector)
            => Enumerable.SelectMany(source,selector).ToArray();
                    
        /// <summary>
        /// Sequenteially condenses a sequence of arrays into a single array
        /// </summary>
        /// <param name="src">The many</param>
        /// <typeparam name="T">The array element type</typeparam>
        public static T[] Join<T>(this T[][] src)
            => Enumerable.SelectMany(src,x => x).ToArray();

        public static T[] Join<S,T>(this S[] src, Func<S,T[]> f)
            where S : IEnumerable<T>
                => Enumerable.SelectMany(src, f).ToArray();

        public static T[] Join<S,T>(this S[][] src, Func<S,T> f)
            => src.Join().Select(f);

        public static T[] SelectMany<S,T>(this S[][] src, Func<S,T> f)
            => src.Join().Select(f);
    }
}