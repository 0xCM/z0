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

    partial struct Digital
    {
        /// <summary>
        /// Projects a bytespan into a codespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The hexcode target</param>
        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, UpperCased @case, Span<HexCode> dst)
        {
            var j=0u;
            var casing = UpperCased.Case;
            for(var i=0u; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);
                seek(dst, j) = code(casing, (HexDigit)(data >> 4));
                seek(dst, j + 1) = code(casing, (HexDigit)(0xF & data));
            }
            return (int)j;
        }

        /// <summary>
        /// Projects a bytespan into a codespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The hexcode target</param>
        [MethodImpl(Inline), Op]
        public static int codes(ReadOnlySpan<byte> src, Span<HexCode> dst)
        {
            var j=0u;
            var casing = LowerCased.Case;
            for(var i=0u; i<src.Length; i++, j+=2)
            {
                ref readonly var data = ref skip(src, i);
                seek(dst, j) = code(casing, (HexDigit)(data >> 4));
                seek(dst, j + 1) = code(casing, (HexDigit)(0xF & data));
            }
            return (int)j;
        }
    }
}