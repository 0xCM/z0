//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Adds a specified byte count to a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T add8<T>(in T src, uint count)
            => ref AddByteOffset(ref edit(src), (IntPtr)count);
    }
}