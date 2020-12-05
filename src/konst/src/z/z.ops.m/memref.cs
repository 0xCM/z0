//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Defines a memory reference
        /// </summary>
        /// <param name="address">The address</param>
        /// <param name="bytes">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static MemorySegment memref(MemoryAddress address, ByteSize bytes)
            => new MemorySegment(address,bytes);

        [MethodImpl(Inline), Op]
        public static MemorySegment memref(Vector128<ulong> src)
            => new MemorySegment(src);

        [MethodImpl(Inline), Op]
        public unsafe static MemorySegment memref(ReadOnlySpan<byte> src)
            => memref((ulong)gptr(src), src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe MemorySegment memref(string src)
            => memref(address(src), src.Length*2);
    }
}