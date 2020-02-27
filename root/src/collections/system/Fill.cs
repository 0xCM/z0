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
        {
            src?.Fill(default(T));
            return src;
        }

        /// <summary>
        /// Fills an array, in-place, with a specified value
        /// </summary>
        /// <param name="src">The input array</param>
        /// <param name="value">The fill value</param>
        /// <typeparam name="T">The element type</typeparam>
        public static T[] Fill<T>(this T[] src, T value)
        {
            for(var i=0; i<src.Length; i++)
                src[i] = value;
            return src;
        }
    }
}