//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;

    using HSU = HexSymUp;
    using HSL = HexSymLo;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static HSU hex(UpperCased casing, byte index)
            => skip(SymbolKonst.UpperHexSymbols, index);

        [MethodImpl(Inline), Op]
        public static HSL hex(LowerCased casing, byte index)
            => skip(SymbolKonst.LowerHexSymbols, index);

        [MethodImpl(Inline), Op]   
        public static HexSym hex(UpperCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSym)((byte)src + (byte)HexSym.FirstNumeral) 
                : (HexSym)((byte)src + (byte)HexSym.FirstLetterUp);

        [MethodImpl(Inline), Op]   
        public static HexSym hex(LowerCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSym)((byte)src + (byte)HexSym.FirstNumeral) 
                : (HexSym)((byte)src + (byte)HexSym.FirstLetterLo);                        

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte index)
            => (char)symbol(@case, (HexDigit)index);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte index)
            => (char)symbol(@case, (HexDigit)index);        
    }
}