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

    using static Collective;

    partial class CollectiveOps
    {
        /// <summary>
        /// Fills an array, in-place, with a specified value
        /// </summary>
        /// <param name="dst">The target array</param>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Fill<T>(this T[] dst, T src)
            => Arrays.fill(dst,src);

    }
}