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

    [ApiHost(ApiNames.SymbolicX, true)]
    public static partial class XSymbolic
    {

    }

    /// <summary>
    /// Defines an api surface for <see cref='ISymbol'/> manipulation
    /// </summary>
    [ApiHost(ApiNames.Symbolic, true)]
    public readonly partial struct Symbolic
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
    }
}