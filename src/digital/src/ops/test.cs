//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using D = DecimalDigitFacets;
    using O = OctalDigitFacets;
    using B = BinaryDigitFacets;
    using X = HexDigitFacets;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
        /// <summary>
        /// Determines whether a character can be interpreted as a <see cref='OctalCode'/> or <see cref='OctalSym'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base2 @base, char c)
            => (BinaryDigitCode)c >= B.MinCode && (BinaryDigitCode)c <= B.MaxCode;

        /// <summary>
        /// Determines whether a byte can be interpreted as a <see cref='OctalDigit'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base2 @base, byte c)
            => (BinaryDigit)c >= B.MinDigit && (BinaryDigit)c <= B.MaxDigit;

        /// <summary>
        /// Determines whether a character can be interpreted as a <see cref='OctalCode'/> or <see cref='OctalSym'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base8 @base, char c)
            => (OctalCode)c >= O.MinCode && (OctalCode)c <= O.MaxCode;

        /// <summary>
        /// Determines whether a byte can be interpreted as a <see cref='OctalDigit'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base8 @base, byte c)
            => (OctalDigit)c >= O.MinDigit && (OctalDigit)c <= O.MaxDigit;

        /// <summary>
        /// Determines whether a character can be interpreted as a <see cref='DecimalCode'/> or <see cref='DecimalSym'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base10 @base, char c)
            => (DecimalCode)c >= D.MinCode && (DecimalCode)c <= D.MaxCode;

        /// <summary>
        /// Determines whether a character can be interpreted as a <see cref='DecimalDigit'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base10 @base, byte c)
            => (DecimalDigit)c >= D.MinDigit && (DecimalDigit)c <= D.MaxDigit;

        /// <summary>
        /// Determines whether a character can be interpreted as a <see cref='HexDigit'/>
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool test(Base16 @base, char c)
            => scalar(@base, c) || upper(@base, c) || lower(@base,c);

        /// <summary>
        /// Determines whether a character corresponds to one of the lower hex codes
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool scalar(Base16 @base, char c)
            => (HexCode)c >= X.MinScalarCode && (HexCode)c <= X.MaxScalarCode;

        /// <summary>
        /// Determines whether a character corresponds to one of the uppercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool upper(Base16 @base, char c)
            => (HexCode)c >= X.MinLetterCodeU && (HexCode)c <= X.MaxLetterCodeU;

        /// <summary>
        /// Determines whether a character corresponds to one of the lowercase hex code characters
        /// </summary>
        /// <param name="c">The character to test</param>
        [MethodImpl(Inline), Op]
        public static bool lower(Base16 @base, char c)
            => (HexCode)c >= X.MinLetterCodeL && (HexCode)c <= X.MaxLetterCodeL;
    }
}