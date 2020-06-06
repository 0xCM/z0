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

    using static Seed;
    
    partial class XTend
    {
        /// <summary>
        /// Sequenteially condenses a sequence of arrays into a single array
        /// </summary>
        /// <param name="src">The many</param>
        /// <typeparam name="T">The array element type</typeparam>
        public static T[] Join<T>(this T[][] src)
            => System.Linq.Enumerable.SelectMany(src,x => x).ToArray();

        public static T[] Join<S,T>(this S[] src, Func<S,T[]> f)
            where S : IEnumerable<T>
                => Enumerable.SelectMany(src, f).ToArray();

        public static T[] Join<S,T>(this S[][] src, Func<S,T> f)
            => src.Join().Select(f);

        public static T[] SelectMany<S,T>(this S[][] src, Func<S,T> f)
            => src.Join().Select(f);



    }
}