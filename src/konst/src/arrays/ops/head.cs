//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    

    using static Konst;
    using static z;

    partial struct Arrays
    {
        /// <summary>
        /// Returns a reference to the location of the first element
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ref T head<T>(T[] src)
            => ref MemoryMarshal.GetReference<T>(src);
    }
}