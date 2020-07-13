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

    using B = BinaryDigit;
    using O = OctalDigit;
    using D = DecimalDigit;
    using X = HexDigit;

    using BS = BinarySym;
    using OS = OctalSym;
    using DS = DecimalSym;

    using DF = DecimalSymFacet;
    using XF = HexSymFacet;
    using BF = BinarySymFacet;

    partial struct asci
    {
        [MethodImpl(Inline), Op]
        public static B digit(BS c)
            => (B)((BF)c - BF.First); 

        [MethodImpl(Inline), Op]   
        public static O digit(OS c)
            => (O)(c - OctalSym.First); 

        [MethodImpl(Inline), Op]   
        public static D digit(DS c)
            => (D)((DF)c - DF.First); 

        [MethodImpl(Inline), Op]
        public static BinaryDigit digit(Base2 @base, char c)
            => (BinaryDigit)((BF)c - BF.First);

        [MethodImpl(Inline), Op]
        public static O digit(Base8 @base, char c)
            => (O)((OctalSym)c - OctalSym.First);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static X digit(Base16 @base, LowerCased @case, char src)
            => AsciTest.digit(src)
            ? (X)((XF)src - XF.NumberOffset) 
            : (X)((XF)src - XF.LetterOffsetLo);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static X digit(Base16 @base, UpperCased @case, char src)
            => AsciTest.digit(src)
            ? (X)((XF)src - XF.NumberOffset) 
            : (X)((XF)src - XF.LetterOffsetUp);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by a lowercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymLo src)
            => AsciTest.number(src)
            ? (X)((XF)src - XF.NumberOffset) 
            : (X)((XF)src - XF.LetterOffsetLo);

        /// <summary>
        /// Computes the numeric value in in the range [0,..F] identified by an uppercase hex symbol
        /// </summary>
        /// <param name="src">The source symbol</param>
        [MethodImpl(Inline), Op]
        public static HexDigit digit(HexSymUp src)
            => AsciTest.number(src)
            ? (X)((XF)src - XF.NumberOffset) 
            : (X)((XF)src - XF.LetterOffsetUp);

        [MethodImpl(Inline), Op]
        public static D digit(Base10 @base, char c)
            => (D)((DF)c - DF.First);

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 1] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static D digit(Base10 @base, ushort src, byte index)
            => (D)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 3] that identifies the digit to extract</param>        
        [MethodImpl(Inline), Op]
        public static D digit(Base10 @base, uint src, byte index)
            => (D)(F & (src >> index*4));

        /// <summary>
        /// Extracts an index-identified encoded digit
        /// </summary>
        /// <param name="base">The base selector</param>
        /// <param name="src">The digit source</param>
        /// <param name="index">An integer in the inclusive range [0, 7] that identifies the digit to extract</param>
        [MethodImpl(Inline), Op]
        public static D digit(Base10 @base, ulong src, byte index)
            => (D)(F & (src >> index*4));
    }
}