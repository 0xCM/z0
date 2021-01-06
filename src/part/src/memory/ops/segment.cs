//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct memory
    {
        /// <summary>
        /// Defines a memory <see cref='MemorySegment'/> with a specified base and size
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="bytes">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static MemorySegment segment(MemoryAddress @base, ByteSize bytes)
            => new MemorySegment(@base,bytes);

        /// <summary>
        /// Defines a memory <see cref='MemorySegment'/> over source span content
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public unsafe static MemorySegment segment(ReadOnlySpan<byte> src)
            => segment((ulong)gptr(src), src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe MemorySegment segment(string src)
            => segment(address(src), src.Length*2);
    }
}