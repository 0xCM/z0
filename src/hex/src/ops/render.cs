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

    partial struct Hex
    {
        [MethodImpl(Inline)]
        public static uint render<C>(C @case, ReadOnlySpan<byte> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var size = src.Length;
            var j=0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst, j++) = hexchar(@case, b, 0);
                seek(dst, j++) = hexchar(@case, b, 1);
            }
            return j;
        }

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]
        public static uint render<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = (char)symbol(@case, skip(src,i));
            return count;
        }
    }
}