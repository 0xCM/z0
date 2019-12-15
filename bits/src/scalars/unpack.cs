//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    using static As;
    partial class Bits
    {
        /// <summary>
        /// Sends each source bit to to last bit of each 8-bit segment in the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack8x1(byte src, ref ulong dst)
            => dst = dinx.scatter(src, (ulong)BitMasks.Lsb64x8);

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack8x1(byte src, Span<byte> dst)
            => unpack8x1(src, ref head64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack16x1(ushort src, Span<byte> dst)
            => unpack16x1(src, ref head64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, Span<byte> dst)
            => unpack32x1(src, ref head64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack64x1(ulong src, Span<byte> dst)
            => unpack64x1(src, ref head64(dst));

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack16x1(ushort src, in Block128<byte> dst)
            => unpack16x1(src, dst.Data);

        /// <summary>
        /// Sends each source bit to a corresponding target cell
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, in Block256<byte> dst)
            => unpack32x1(src, dst.Data);

        [MethodImpl(Inline)]
        static void unpack16x1(ushort src, ref ulong dst)
        {
            const ulong M = (ulong)BitMasks.Lsb64x8;

            seek(ref dst, 0) = dinx.scatter(src, M);
            seek(ref dst, 1) = dinx.scatter(uint16(src >> 8), M);
        }

        [MethodImpl(Inline)]
        static void unpack32x1(uint src, ref ulong dst)
        {
            unpack16x1((ushort)src, ref dst);
            unpack16x1((ushort)(src >> 16), ref seekb(ref dst, 16));
        }

        [MethodImpl(Inline)]
        static void unpack64x1(ulong src, ref ulong dst)
        {
            unpack32x1((uint)src, ref dst);
            unpack32x1((uint)(src >> 32), ref seekb(ref dst, 32));
        }
    }
}