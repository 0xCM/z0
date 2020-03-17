// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;

    using static Root;

    partial class SystemCollections
    {
        /// <summary>
        /// Fills an array with the element type's default value
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The array element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Clear<T>(this T[] src)
            => Arrays.clear(src);

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