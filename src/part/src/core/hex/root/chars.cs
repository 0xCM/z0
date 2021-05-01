//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static HexFormatSpecs;

    partial struct Hex
    {
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

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, sbyte src, Span<char> dst, int offset)
            => chars(@case, (byte)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, sbyte src, Span<char> dst, int offset)
            => chars(@case, (byte)src, dst, offset);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static void chars(Base16 @base, UpperCased @case, byte value, out char d0, out char d1)
            => chars(first(UpperHexDigits), value, out d0, out d1);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static void chars(Base16 @base, LowerCased @case, byte value, out char d0, out char d1)
            => chars(first(LowerHexDigits), value, out d0, out d1);

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

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, byte src, Span<char> dst, int offset)
            => chars(first(UpperHexDigits), src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(LowerCased @case, byte src, Span<char> dst, int offset)
            => chars(first(LowerHexDigits), src, dst, offset);

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
            => chars(Hex.hexstring(n1), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex2Seq src)
            => chars(Hex.hexstring(n2), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex3Seq src)
            => chars(Hex.hexstring(n3), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex4Seq src)
            => chars(Hex.hexstring(n4), src);

    }
}