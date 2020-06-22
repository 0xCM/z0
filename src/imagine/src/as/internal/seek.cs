//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsInternal
    {
        /// <summary>
        /// Adds a T-counted offset to a T-reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(ref T src, int count)
            => ref Add(ref src, count);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(ref T src, IntPtr offset)
            => ref Add(ref src, offset);
    }
}