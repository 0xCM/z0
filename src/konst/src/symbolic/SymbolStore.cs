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

    using BF = BinarySymFacet;

    [ApiHost("symbols.store")]
    public readonly struct SymbolStore
    {
        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(BinaryDigit src)
            => Symbolic.symbol<BinarySym,byte,N1>((BinarySym)(src + (byte)BF.First));

        [MethodImpl(Inline), Op]
        public static Symbol<OctalSym,byte,N3> symbol(OctalDigit src)
            => Symbolic.symbol<OctalSym,byte,N3>((OctalSym)((byte)src + (byte)OctalSym.First));

        [MethodImpl(Inline), Op]
        public static Symbol<BinarySym,byte,N1> symbol(Base2 @base, byte src)
            => Symbolic.symbol<BinarySym,byte,N1>((BinarySym)(src + (byte)BF.First));

        [MethodImpl(Inline), Op]
        public static Symbol<DecimalSym,byte,N4> symbol(DecimalDigit src)
            => Symbolic.symbol<DecimalSym,byte,N4>((DecimalSym)((byte)src + DecimalSymFacet.First));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(UpperCased @case, HexDigit src)
            => Symbolic.symbol<HexSym,byte,N4>(((HexSym)asci.code(@case, src)));

        [MethodImpl(Inline), Op]
        public static Symbol<HexSym,byte,N4> symbol(LowerCased @case, HexDigit src)
            => Symbolic.symbol<HexSym,byte,N4>(((HexSym)asci.code(@case, src)));

        [MethodImpl(Inline), Op]
        public static Symbols<Hex2Seq,byte,N2> hex(N2 n)
            => Symbolic.symbols<Hex2Seq,byte,N2>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex3Seq,byte,N3> hex(N3 n)
            => Symbolic.symbols<Hex3Seq,byte,N3>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex4Seq,byte,N4> hex(N4 n)
            => Symbolic.symbols<Hex4Seq,byte,N4>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex5Seq,byte,N5> hex(N5 n)
            => Symbolic.symbols<Hex5Seq,byte,N5>();

        [MethodImpl(Inline), Op]
        public static Symbols<Hex8Seq,byte,N8> hex(N8 n)
            => Symbolic.symbols<Hex8Seq,byte,N8>();

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymUp> hex(byte src, UpperCased @case)
            => recover<byte,HexSymUp>(Hex.UpperDigits);

        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<HexSymLo> hex(byte src, LowerCased @case)
            => recover<byte,HexSymLo>(Hex.LowerDigits);

        [MethodImpl(Inline), Op]
        public static void convert(ReadOnlySpan<BinaryDigit> src, Span<BinarySym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void convert(ReadOnlySpan<DecimalDigit> src, Span<DecimalSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void convert(UpperCased @case, ReadOnlySpan<HexDigit> src, Span<HexSym> dst)
        {
            var len = src.Length;
            for(var i = 0u; i<len; i++)
                seek(dst,i) = symbol(@case, skip(src,i));
        }

    }


    public readonly struct SymbolStore<S>
    {


    }

}