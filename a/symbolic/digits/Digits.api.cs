//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    [ApiHost]
    public static class Digits
    {
        [MethodImpl(Inline), Op]   
        public static BinaryDigitSymbol symbol(BinaryDigit src)
            => (BinaryDigitSymbol)((uint)src + (uint)BinaryDigitSymbol.Zed);

        [MethodImpl(Inline), Op]   
        public static DeciDigitSymbol symbol(DeciDigit src)
            => (DeciDigitSymbol)((uint)src + (uint)DeciDigitSymbol.D0);

        [MethodImpl(Inline), Op]   
        public static HexDigitSymbol symbol(HexDigit src)
            => (uint)src <= (uint)HexDigit.D9 
                ? (HexDigitSymbol)((uint)src + (uint)HexDigit.D0) 
                : (HexDigitSymbol)((uint)src + (uint)HexDigit.A);
    }
}