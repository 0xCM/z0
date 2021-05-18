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
    using static HexCharData;

    partial struct Hex
    {
        [MethodImpl(Inline)]
        public static void symbols<T,C>(in T src, C @case, Span<HexSym> dst)
            where T : unmanaged
            where C : unmanaged, ILetterCase
        {
            ref readonly var b = ref @as<T,byte>(src);
            var cellsize = size<T>();
            for(var i=0; i<cellsize*2; i+=2)
            {
                var lo = (HexDigit)(0x0F & skip(b,i));
                var hi = (HexDigit)(skip(b,i) >> 4);
                seek(dst,i) = symbol(@case, lo);
                seek(dst,i+1) = symbol(@case, hi);
            }
        }

        [MethodImpl(Inline)]
        public static void symbols<C>(C @case, ReadOnlySpan<HexDigit> src, Span<HexSym> dst)
            where C : unmanaged, ILetterCase
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(@case, skip(src,i));
        }

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymUp> symbols(UpperCased @case)
            => recover<byte,HexSymUp>(UpperHexDigits);

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymLo> symbols(LowerCased @case)
            => recover<byte,HexSymLo>(LowerHexDigits);
    }
}