//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct memory
    {
        /// <summary>
        /// Creates a bytespan from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static Span<byte> span8u<T>(in T src)
            where T : struct
                => AsBytes(CreateSpan(ref edit(src), 1));
    }
}