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

    partial class BitPack
    {
        /// <summary>
        /// Unpacks 8 source bits over 8 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack8(byte src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack8(src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
        }

        /// <summary>
        /// Unpacks 16 source bits over 16 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack16(ushort src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);

            unpack8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
        }

        /// <summary>
        /// Unpacks 32 source bits over 32 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack32(uint src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref z.uint8(ref buffer);
            ref var lead = ref z.first(dst);

            unpack8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
            unpack8((byte)(src >> 16), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);
            unpack8((byte)(src >> 24), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);
        }

        /// <summary>
        /// Unpacks 64 source bits over 64 32-bit target segments
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="buffer">The intermediate buffer</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static void unpack64(ulong src, Span<uint> dst)
        {
            var buffer = z64;
            ref var tmp = ref uint8(ref buffer);
            ref var lead = ref first(dst);
            unpack8((byte)src, ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead);
            unpack8((byte)(src >> 8), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 8);
            unpack8((byte)(src >> 16), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 16);
            unpack8((byte)(src >> 24), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 24);
            unpack8((byte)(src >> 32), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 32);
            unpack8((byte)(src >> 40), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 40);
            unpack8((byte)(src >> 48), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 48);
            unpack8((byte)(src >> 56), ref tmp);
            vconvert(n64, in tmp, n256, n32).StoreTo(ref lead, 56);
        }
    }
}