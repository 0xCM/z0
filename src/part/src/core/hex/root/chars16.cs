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