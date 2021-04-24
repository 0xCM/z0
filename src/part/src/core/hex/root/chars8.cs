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
    }
}