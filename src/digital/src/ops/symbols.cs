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
    using static HexCharData;

    partial struct Digital
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void symbols<T>(in T src, Span<HexSymLo> dst)
            where T : unmanaged
        {
            ref readonly var b = ref @as<T,byte>(src);
            var cellsize = size<T>();
            var hexsym = symbols(base16, LowerCase);
            for(var i=0u; i<cellsize; i++)
            {
                for(var j=0u; j<cellsize; j++)
                    seek(dst,j) = skip(hexsym, j);
            }
        }

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymUp> symbols(Base16 @base, UpperCased @case)
            => recover<byte,HexSymUp>(UpperHexDigits);

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymLo> symbols(Base16 @base, LowerCased @case)
            => recover<byte,HexSymLo>(LowerHexDigits);

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<BinaryDigit> src, Span<BinarySym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<OctalDigit> src, Span<OctalSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void symbols(ReadOnlySpan<DecimalDigit> src, Span<DecimalSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void symbols(UpperCased @case, ReadOnlySpan<HexDigit> src, Span<HexSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(@case, skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void symbols(LowerCased @case, ReadOnlySpan<HexDigit> src, Span<HexSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(@case, skip(src,i));
        }
    }
}