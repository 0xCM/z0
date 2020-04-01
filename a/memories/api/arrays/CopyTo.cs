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
        /// Copies a source list to a target array
        /// </summary>
        /// <param name="src">The list containing the elements to copy</param>
        /// <param name="dst">The array that will receive the copied elements</param>
        /// <typeparam name="T">The element type</typeparam>
        public static void CopyTo<T>(this IReadOnlyList<T> src, T[] dst)
        {
            if(src.Count > dst.Length)
                throw new ArgumentException("The source list is bigger than the target array");

            for(var i=0; i< src.Count; i++)
                dst[i] = src[i];
        }
    }
}