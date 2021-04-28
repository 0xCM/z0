//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Defines a memory <see cref='MemSeg'/> with a specified base and size
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="bytes">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static MemSeg memseg(MemoryAddress @base, ByteSize bytes)
            => new MemSeg(@base,bytes);

        /// <summary>
        /// Defines a memory <see cref='MemSeg'/> over source span content
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public unsafe static MemSeg memseg(ReadOnlySpan<byte> src)
            => memseg((ulong)gptr(src), src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe MemSeg memseg(string src)
            => memseg(pchar(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe MemSeg memseg(char* src, uint count)
            => new MemSeg(address(src), count*2);
    }
}