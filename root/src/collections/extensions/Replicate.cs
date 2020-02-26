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
    
    partial class RootCollections
    {
        /// <summary>
        /// Allocates an populates a new array that is identical to the source array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static T[] Replicate<T>(this T[] src)
        {
            var dst = new T[src.Length];
            Array.Copy(src, dst, src.Length);
            return dst;
        }

    }
}