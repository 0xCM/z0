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
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<ushort> span16u<T>(in T src)
            where T : struct
                => recover<ushort>(AsBytes(CreateSpan(ref edit(src), 1)));

        /// <summary>
        /// Creates a u16 span from a T-cell reference
        /// </summary>
        /// <param name="src">The reference cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ushort> span16u(ReadOnlySpan<byte> src)
            => recover<ushort>(src);
    }
}