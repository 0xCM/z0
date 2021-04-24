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

        [MethodImpl(Inline)]
        static void chars(in byte codes, ushort src, Span<char> dst, int offset)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (ushort)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (ushort)((src >> 1*4) & 0xF));
            seek(target, offset + 2) = (char)skip(in codes, (ushort)((src >> 2*4) & 0xF));
            seek(target, offset + 3) = (char)skip(in codes, (ushort)((src >> 3*4) & 0xF));
        }
    }
}