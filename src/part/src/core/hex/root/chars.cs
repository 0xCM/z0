//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;
    using static HexFormatSpecs;

    partial struct Hex
    {
        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, byte src)
            => chars(first(UpperHexDigits),src);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, byte src)
            => chars(first(LowerHexDigits),src);

        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, sbyte src)
            => chars(@case, (byte)src);

        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, sbyte src)
            => chars(@case, (byte)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, short src)
            => chars(@case, (ushort)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, short src)
            => chars(@case, (ushort)src);

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, ushort src)
            => chars(first(UpperHexDigits),src);

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, ushort src)
            => chars(first(LowerHexDigits),src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, int src)
            => chars(@case, (uint)src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, int src)
            => chars(@case, (uint)src);

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, uint src)
            => chars(first(UpperHexDigits), src);

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, uint src)
            => chars(first(LowerHexDigits), src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, long src)
            => chars(@case, (ulong)src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, long src)
            => chars(@case, (ulong)src);

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, ulong src)
            => chars(first(UpperHexDigits), src);

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(LowerCased @case, ulong src)
            => chars(first(LowerHexDigits), src);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, byte src, Span<char> dst, int offset)
            => chars(first(UpperHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, byte src, Span<char> dst, int offset)
            => chars(first(LowerHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, sbyte src, Span<char> dst, int offset)
            => chars(@case, (byte)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, sbyte src, Span<char> dst, int offset)
            => chars(@case, (byte)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, short src, Span<char> dst, int offset)
            => chars(@case, (ushort)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, short src, Span<char> dst, int offset)
            => chars(@case, (ushort)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, ushort src, Span<char> dst, int offset)
            => chars(first(UpperHexDigits), src, dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, ushort src, Span<char> dst, int offset)
            => chars(first(LowerHexDigits), src, dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, int src, Span<char> dst, int offset)
            => chars(@case, (uint)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, int src, Span<char> dst, int offset)
            => chars(@case, (uint)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, uint src, Span<char> dst, int offset)
            => chars(first(UpperHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, uint src, Span<char> dst, int offset)
            => chars(first(LowerHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, long src, Span<char> dst, int offset)
            => chars(@case, (ulong)src, dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, long src, Span<char> dst, int offset)
            => chars(@case, (ulong)src, dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, ulong src, Span<char> dst, int offset)
            => chars(first(UpperHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, ulong src, Span<char> dst, int offset)
            => chars(first(LowerHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static uint chars<C>(C @case, ReadOnlySpan<byte> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var size = src.Length;
            var j=0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst,j++) = hexchar(@case, b, 0);
                seek(dst,j++) = hexchar(@case, b, 1);
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex1Seq> src, Hex1Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex2Seq> src, Hex2Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex3Seq> src, Hex3Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex4Seq> src, Hex4Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex1Seq src)
            => chars(hexstring(n1), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex2Seq src)
            => chars(hexstring(n2), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex3Seq src)
            => chars(hexstring(n3), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex4Seq src)
            => chars(hexstring(n4), src);

        [MethodImpl(Inline)]
        static void chars(in byte codes, byte value, out char d0, out char d1)
        {
            d0 = (char)skip(codes, (byte)(0xF & value));
            d1 = (char)skip(codes, (byte)((value >> 4) & 0xF));
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars(in byte codes, byte src)
        {
            var storage = CharStacks.alloc(n2);
            ref var dst = ref storage.C0;
            seek(dst,0) = (char)skip(codes, (byte)(0xF & src));
            seek(dst,1) = (char)skip(codes, (byte)((src >> 4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars(in byte codes, ulong src)
        {
            const byte count = 16;
            var storage = CharStacks.alloc(n16);
            ref var dst = ref storage.C0;
            for(byte i=0; i<count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline)]
        static void chars(in byte codes, byte src, Span<char> dst, int offset)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (byte)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (byte)((src >> 4) & 0xF));
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars(in byte codes, ushort src)
        {
            const int count = 4;
            var storage = CharStacks.alloc(n4);
            ref var dst = ref storage.C0;
            for(var i=0; i<count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(codes, (uint)((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline)]
        static void chars(in byte codes, ushort src, Span<char> dst, int offset)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (ushort)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (ushort)((src >> 1*4) & 0xF));
            seek(target, offset + 2) = (char)skip(in codes, (ushort)((src >> 2*4) & 0xF));
            seek(target, offset + 3) = (char)skip(in codes, (ushort)((src >> 3*4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(in byte codes, uint src)
        {
            const byte count = 8;
            var storage = CharStacks.alloc(n8);
            ref var dst = ref storage.C0;
            for(byte i=0; i < count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline)]
        static void chars(in byte codes, uint src, Span<char> dst, int offset)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
        }

        [MethodImpl(Inline)]
        static void chars(in byte codes, ulong src, Span<char> dst, int offset)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
            seek(target, offset + 4) = (char)skip(in codes, (src >> 4*4) & 0xF);
            seek(target, offset + 5) = (char)skip(in codes, (src >> 5*4) & 0xF);
            seek(target, offset + 6) = (char)skip(in codes, (src >> 6*4) & 0xF);
            seek(target, offset + 7) = (char)skip(in codes, (src >> 7*4) & 0xF);
        }
    }
}