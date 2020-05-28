//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    
    using HexLo = HexSymbolLo;

    partial class Symbolic    
    {        
        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(BinarySymbol c)
            => (BinaryDigit)(c - BinarySymbol.First); 

        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(Base2 @base, char c)
            => (BinaryDigit)((BinarySymbol)c - BinarySymbol.First);

        [MethodImpl(Inline), Op]
        public static OctalDigit digit(Base8 @base, char c)
            => (OctalDigit)((OctalSymbol)c - OctalSymbol.First);

        [MethodImpl(Inline), Op]   
        public static OctalDigit digit(OctalSymbol c)
            => (OctalDigit)(c - OctalSymbol.First); 

        [MethodImpl(Inline), Op]
        public static DecimalDigit digit(Base10 @base, char c)
            => (DecimalDigit)((DecimalSymbol)c - DecimalSymbol.First);

        [MethodImpl(Inline), Op]   
        public static DecimalDigit digit(DecimalSymbol c)
            => (DecimalDigit)(c - DecimalSymbol.First); 

        /// <summary>
        /// Computes the numeric value in in the range [0,..f] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, LowerCased @case, HexSymbolLo src)
            => numeral(src) 
            ? (HexDigit)(src - HexSymbolLo.NumeralOffset) 
            : (HexDigit)(src - HexSymbolLo.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..f] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, UpperCased @case, HexSymbolUp src)
            => numeral(src) 
            ? (HexDigit)(src - HexSymbolUp.NumeralOffset) 
            : (HexDigit)(src - HexSymbolUp.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, LowerCased @case, char c)
            => numeral(c) 
            ? (HexDigit)((HexLo)c - HexSymbolLo.NumeralOffset) 
            : (HexDigit)((HexLo)c - HexSymbolLo.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymbolLo src)
            => numeral(src) 
            ? (HexDigit)(src - HexSymbolLo.NumeralOffset) 
            : (HexDigit)(src - HexSymbolLo.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymbolUp src)
            => numeral(src) 
            ? (HexDigit)(src - HexSymbolUp.NumeralOffset) 
            : (HexDigit)(src - HexSymbolUp.LetterOffset);
    }
}