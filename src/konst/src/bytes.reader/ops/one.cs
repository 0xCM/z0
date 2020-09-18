//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Bytes
    {
        /// <summary>
        /// Reads/writes a byte from/to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="offset">The 0-based/byte-relative offset</param>
        /// <typeparam name="T">The data type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte one<T>(ref T src, int offset)
            where T : unmanaged
                => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), offset);
    }
}