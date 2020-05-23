//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]   
        public static BinaryDigitSymbol symbol(BinaryDigit src)
            => (BinaryDigitSymbol)((uint)src + (uint)BinaryDigitSymbol.b0);

        [MethodImpl(Inline), Op]   
        public static DecimalDigitSymbol symbol(DecimalDigit src)
            => (DecimalDigitSymbol)((uint)src + (uint)DecimalDigitSymbol.d0);

        [MethodImpl(Inline), Op]   
        public static HexDigitSymbolUp symbol(HexDigit src, UpperCased c)
            => (uint)src <= (uint)HexDigit.x9 
                ? (HexDigitSymbolUp)((uint)src + (uint)HexDigit.x0) 
                : (HexDigitSymbolUp)((uint)src + (uint)HexDigit.A);

        [MethodImpl(Inline), Op]   
        public static HexDigitSymbolLo symbol(HexDigit src, LowerCased c)
            => (uint)src <= (uint)HexDigit.x9 
                ? (HexDigitSymbolLo)((uint)src + (uint)HexDigit.x0) 
                : (HexDigitSymbolLo)((uint)src + (uint)HexDigit.A);



    }

}