// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static As;

    partial class Root
    {
        /// <summary>
        /// Defines a memory reference
        /// </summary>
        /// <param name="address">The address</param>
        /// <param name="bytes">The number of reference bytes</param>
        [MethodImpl(Inline), Op]
        public static SegRef memref(MemoryAddress address, ByteSize bytes)
            => z.memref(address,bytes);

        [MethodImpl(Inline), Op]
        public static SegRef memref(Vector128<ulong> src)
            => z.memref(src);

        [MethodImpl(Inline), Op]
        public unsafe static SegRef memref(ReadOnlySpan<byte> src)
            => z.memref(src);
        
        [MethodImpl(Inline), Op]
        public static unsafe SegRef memref(string src)
            => z.memref(src);
    }
}