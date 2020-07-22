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

    using HSU = HexSymUp;
    using HSL = HexSymLo;
    using H = HexSymData;
    using XF = HexSymFacet;        

    partial struct asci
    {

        [MethodImpl(Inline), Op]
        public static HSL hex(LowerCased casing, byte index)
            => skip(H.LowerSymbols, index);

        [MethodImpl(Inline), Op]
        public static HSU hex(UpperCased casing, byte index)
            => skip(H.UpperSymbols, index);

        [MethodImpl(Inline), Op]   
        public static HexSym hex(LowerCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSym)((byte)src + (byte)HexSymFacet.FirstNumber) 
                : (HexSym)((byte)src + (byte)HexSymFacet.FirstLetterLo);

        [MethodImpl(Inline), Op]   
        public static HexSym hex(UpperCased @case, HexDigit src)
            => src <= HexDigit.x9 
                ? (HexSym)((byte)src + (byte)HexSymFacet.FirstNumber) 
                : (HexSym)((byte)src + (byte)HexSymFacet.FirstLetterUp);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte index)
            => (char)symbol(@case, (HexDigit)index);        
        
        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte index)
            => (char)symbol(@case, (HexDigit)index);
    }
}