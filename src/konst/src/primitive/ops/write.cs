//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Primal
    {
        /// <summary>
        /// Projects a source byte onto a byte reference
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(byte src, ref byte dst)
        {
            *(gptr(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 16 source bits onto a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(ushort src, ref byte dst)
        {
            *(gptr<ushort>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(uint src, ref byte dst)
        {
             *(gptr<uint>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort write(uint src, ref ushort dst)
        {
            *(gptr<uint>(dst)) = src;
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
             *(gptr<ulong>(dst)) = src;
             return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort write(ulong src, ref ushort dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint write(ulong src, ref uint dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }
    }
}