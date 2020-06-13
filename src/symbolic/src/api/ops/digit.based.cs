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
        public static BinaryDigit digit(Base2 @base, char c)
            => (BinaryDigit)((BinarySym)c - BinarySym.First);

        [MethodImpl(Inline), Op]
        public static OctalDigit digit(Base8 @base, char c)
            => (OctalDigit)((OctalSym)c - OctalSym.First);

        [MethodImpl(Inline), Op]
        public static DeciDigit digit(Base10 @base, char c)
            => (DeciDigit)((DeciSym)c - DeciSym.First);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, LowerCased @case, char src)
            => SymTest.IsNumeral(src)
            ? (HexDigit)((HexSymLo)src - (HexSymLo)HexSymLoFacet.NumeralOffset) 
            : (HexDigit)((HexSymLo)src - (HexSymLo)HexSymLoFacet.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, UpperCased @case, char src)
            => SymTest.IsNumeral(src)
            ? (HexDigit)((HexSymUp)src - (HexSymUp)HexSymLoFacet.NumeralOffset) 
            : (HexDigit)((HexSymUp)src - (HexSymUp)HexSymLoFacet.LetterOffset);
    }
}