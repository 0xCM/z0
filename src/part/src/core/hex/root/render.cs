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

    partial struct Hex
    {
        [Op]
        public static uint render(ReadOnlySpan<byte> src, Span<char> dst, bool lower = true)
            => lower ? render(LowerCase,src,dst) : render(UpperCase, src,dst);

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

        [MethodImpl(Inline)]
        public static uint render<C>(C @case, ReadOnlySpan<byte> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var j=0u;
            var count = src.Length;
            for(var i=0u; i<count; i++, j+=3)
            {
                ref readonly var code = ref skip(src, i);
                seek(dst, j) = hexchar(@case, (byte)(code >> 4));
                seek(dst, j + 1) = hexchar(@case, (byte)(0xF & code));
                seek(dst, j + 2) = Chars.Space;
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<HexCode> src, Span<char> dst)
        {
            var j=0u;
            var count = src.Length;
            for(var i=0u; i<count; i+=2, j+=3)
            {
                seek(dst, j) = (char)skip(src, i);
                seek(dst, j + 1) = (char)skip(src, i + 1);
                seek(dst, j + 2) = Chars.Space;
            }

            return j;
        }

        /// <summary>
        /// Renders a sequence of primal numeric T-cells as a sequence of hex-formatted values
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="config">The format configuration</param>
        /// <param name="dst">The rendered data receiver</param>
        /// <typeparam name="T">The primal numeric type</typeparam>
        [Op, Closures(Closure)]
        public static void render<T>(ReadOnlySpan<T> src, in HexFormatOptions config, ITextBuffer dst)
            where T : unmanaged
        {
            var count = src.Length;
            ref readonly var cell = ref first(src);
            var last = count - 1;
            for(var i=0u; i<count; i++)
            {
                ref readonly var current = ref skip(cell,i);
                dst.Append(HexFormat.format(current, config.ZeroPad, config.Specifier, config.Uppercase, config.PreSpec));

                if(i != last)
                    dst.Append(config.SegDelimiter);
            }
        }
    }
}