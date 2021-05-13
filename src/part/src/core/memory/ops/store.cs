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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void store<T>(ReadOnlySpan<SegRef> src, Span<T> dst)
            where T : struct
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = first(recover<T>(skip(src,i).Edit));
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte store(ulong src, ref byte dst)
        {
             *(gptr<ulong>(dst)) = src;
             return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void store(BinaryCode src, ByteSize size, MemoryAddress dst)
            => src.View.CopyTo(edit(dst, size));
    }
}