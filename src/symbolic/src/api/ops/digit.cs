//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    
    using HexLo = HexDigitSymbolLo;
    using HexUp = HexDigitSymbolUp;

    partial class Symbolic    
    {        
        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexLo src)
            => numeral(src) 
            ? (HexDigit)(src - HexLo.NumeralOffset) 
            : (HexDigit)(src - HexLo.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexUp src)
            => numeral(src) 
            ? (HexDigit)(src - HexUp.NumeralOffset) 
            : (HexDigit)(src - HexUp.LetterOffset);

        /// <summary>
        /// Returns the digit corresponding to a specified binary symbol
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(BinaryDigitSymbol c)
            => c == BinaryDigitSymbol.b1 ? BinaryDigit.b1 : BinaryDigit.b0;


        [MethodImpl(Inline), Op]   
        public static DecimalDigit digit(DecimalDigitSymbol c)
            => (DecimalDigit)((uint)c - (uint)DecimalDigitSymbol.d0);

 
    }
}