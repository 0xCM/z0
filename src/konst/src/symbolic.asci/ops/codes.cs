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

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<AsciCharCode> codes(sbyte offset, sbyte count)
            => AsciSymbols.Service.codes(offset, (sbyte)(count));

        [MethodImpl(Inline), Op]
        public static void codes(in char src, int count, ref AsciCharCode dst)
        {
            for(var i=0u; i<count; i++)
                seek(dst,i) = (AsciCharCode)skip(src,i);
        }

        [MethodImpl(Inline), Op]
        public static void codes(ReadOnlySpan<char> src, Span<AsciCharCode> dst)
        {
            var count = Math.Min(src.Length, dst.Length);
            codes(z.first(src), count, ref z.first(dst));
        }

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