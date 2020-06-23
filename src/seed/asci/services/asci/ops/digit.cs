//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static HexConst;

    partial struct asci
    {

        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(BinarySym c)
            => (BinaryDigit)(c - BinarySym.First); 

        [MethodImpl(Inline), Op]   
        public static OctalDigit digit(OctalSym c)
            => (OctalDigit)(c - OctalSym.First); 

        [MethodImpl(Inline), Op]   
        public static DeciDigit digit(DeciSym c)
            => (DeciDigit)(c - DeciSym.First); 

        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(Base2 @base, char c)
            => (BinaryDigit)((BinarySym)c - BinarySym.First);

        [MethodImpl(Inline), Op]
        public static OctalDigit digit(Base8 @base, char c)
            => (OctalDigit)((OctalSym)c - OctalSym.First);


        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, LowerCased @case, char src)
            => AsciTest.digit(src)
            ? (HexDigit)((HexSymLo)src - (HexSymLo)HexSymLoFacet.NumeralOffset) 
            : (HexDigit)((HexSymLo)src - (HexSymLo)HexSymLoFacet.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(Base16 @base, UpperCased @case, char src)
            => AsciTest.digit(src)
            ? (HexDigit)((HexSymUp)src - (HexSymUp)HexSymLoFacet.NumeralOffset) 
            : (HexDigit)((HexSymUp)src - (HexSymUp)HexSymLoFacet.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymLo src)
            => AsciTest.IsNumeral(src)
            ? (HexDigit)(src - (HexSymLo)HexSymLoFacet.NumeralOffset) 
            : (HexDigit)(src - (HexSymLo)HexSymLoFacet.LetterOffset);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymUp src)
            => AsciTest.IsNumeral(src)
            ? (HexDigit)(src - HexSymUp.NumeralOffset) 
            : (HexDigit)(src - HexSymUp.LetterOffset);

        [MethodImpl(Inline), Op]
        public static DeciDigit digit(Base10 @base, char c)
            => (DeciDigit)((DeciSym)c - DeciSym.First);

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 1] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DeciDigit digit(Base10 @base, ushort src, int index)
            => (DeciDigit)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 3] that identifies the digit to extract</param>        
        [MethodImpl(Inline), Op]
        public static DeciDigit digit(Base10 @base, uint src, int index)
            => (DeciDigit)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 7] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static DeciDigit digit(Base10 @base, ulong src, int index)
            => (DeciDigit)(F & (src >> index*4));
    }
}