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

    partial class Hex
    {
        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, sbyte src)
            => chars(@case, (byte)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, short src)
            => chars(@case, (ushort)src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, int src)
            => chars(@case, (uint)src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, long src)
            => chars(@case, (ulong)src);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, sbyte src, Span<char> dst, int offset)
            => chars(@case, (byte)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, short src, Span<char> dst, int offset)
            => chars(@case, (ushort)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, int src, Span<char> dst, int offset)
            => chars(@case, (uint)src, dst, offset);

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, long src, Span<char> dst, int offset)
            => chars(@case, (ulong)src, dst,offset);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static void chars(Base16 @base, UpperCased @case, byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            d0 = (char)skip(codes, (byte)(0xF & value));
            d1 = (char)skip(codes, (byte)((value >> 4) & 0xF));
        }

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, byte src)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = CharStacks.alloc(n2);
            ref var dst = ref storage.C0;
            seek(dst,0) = (char)skip(codes, (byte)(0xF & src));
            seek(dst,1) = (char)skip(codes, (byte)((src >> 4) & 0xF));
            return CharStacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, ushort src)
        {
            const int count = 4;
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = CharStacks.alloc(n4);
            ref var dst = ref storage.C0;
            for(var i=0; i < count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(codes, (uint)((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, uint src)
        {
            const byte count = 8;
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = CharStacks.alloc(n8);
            ref var dst = ref storage.C0;
            for(byte i=0; i < count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(UpperCased @case, ulong src)
        {
            const byte count = 16;
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = CharStacks.alloc(n16);
            ref var dst = ref storage.C0;
            for(byte i=0; i<count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, byte src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (byte)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (byte)((src >> 4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, ushort src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (ushort)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (ushort)((src >> 1*4) & 0xF));
            seek(target, offset + 2) = (char)skip(in codes, (ushort)((src >> 2*4) & 0xF));
            seek(target, offset + 3) = (char)skip(in codes, (ushort)((src >> 3*4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, uint src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
        }

        [MethodImpl(Inline), Op]
        public static void chars(UpperCased @case, ulong src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
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