//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    
    partial struct z
    {
        /// <summary>
        /// Constructs an array from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HashSet<T> hashset<T>(params T[] src)
            => new HashSet<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static HashSet<T> hashset<T>(IEnumerable<T> members)
            => new HashSet<T>(members);
    }
}