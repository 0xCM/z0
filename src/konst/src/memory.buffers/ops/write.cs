//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        /// <summary>
        /// Reads a byte
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte read8(in byte src)
            => *(byte*)z.gptr(in src);

        /// <summary>
        /// Projects a source byte onto a byte reference
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte store8(byte src, ref byte dst)
        {
            *(z.gptr(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(ulong src, ref byte dst)
        {
             *(z.gptr<ulong>(dst)) = src;
             return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static void write(BinaryCode src, ByteSize size, MemoryAddress dst)
            => src.Data.CopyTo(z.edit<byte>(dst, size));
    }
}