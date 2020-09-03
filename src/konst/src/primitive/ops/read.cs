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
        /// Copies a byte
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte read(W8 w, in byte src)
            => *(byte*)gptr(in src);

        /// <summary>
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort read(W16 w, in byte src)
            => *(ushort*)gptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read(W32 w, in byte src)
            => *(uint*)gptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read(W32 w, in ushort src)
            => *(uint*)gptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W64 w, in byte src)
            => *(ulong*)gptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W16 w, in ushort src)
            => *gptr<ulong>(src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W32 w, in uint src)
            => *gptr<ulong>(src);

        /// <summary>
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort read(in byte src, out ushort dst)
        {
            dst = *(ushort*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint read(W32 w, in byte src, out uint dst)
        {
            dst = *(uint*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint read(in ushort src, out uint dst)
        {
            dst = *(uint*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>

        [MethodImpl(Inline), Op]
        public static unsafe ref ulong read(in byte src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ulong read(in ushort src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
         /// <param name="dst">The target</param>
       [MethodImpl(Inline), Op]
        public static unsafe ref ulong read(in uint src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }
    }
}