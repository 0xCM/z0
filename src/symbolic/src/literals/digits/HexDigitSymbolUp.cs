//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines the symbols that represent the uppercase base-16 digits
    /// </summary>
    public enum HexDigitSymbolUp : ushort
    {
        /// <summary>
        /// Specifies 0 base 16, asci code 48
        /// </summary>
        x0 = '0',

        /// <summary>
        /// Specifies 1 base 16, asci code 49
        /// </summary>
        x1 = '1',
        
        /// <summary>
        /// Specifies 2 base 16, asci code 50
        /// </summary>
        x2 = '2',
        
        /// <summary>
        /// Specifies 3 base 16, asci code 51
        /// </summary>
        x3 = '3',

        /// <summary>
        /// Specifies 4 base 16, asci code 52
        /// </summary>
        x4 = '4',

        /// <summary>
        /// Specifies 5 base 16
        /// </summary>
        x5 = '5',

        /// <summary>
        /// Specifies 6 base 16
        /// </summary>
        x6 = '6',

        /// <summary>
        /// Specifies 7 base 16
        /// </summary>
        x7 = '7',
        
        /// <summary>
        /// Specifies 8 base 16
        /// </summary>
        x8 = '8',
        
        /// <summary>
        /// Specifies 9 base 16
        /// </summary>
        x9 = '9',

        /// <summary>
        /// Specifies 10 base 16, asci code 65
        /// </summary>
        A = 'A',

        /// <summary>
        /// Specifies 11 base 16, asci code 66
        /// </summary>
        B = 'B',

        /// <summary>
        /// Specifies 12 base 16, asci code 67
        /// </summary>
        C = 'C',

        /// <summary>
        /// Specifies 13 base 16, asci code 68
        /// </summary>
        D = 'D',

        /// <summary>
        /// Specifies 14 base 16, asci code 69
        /// </summary>
        E = 'E',

        /// <summary>
        /// Specifies 15 base 16, asci code 70
        /// </summary>
        F = 'F',

        /// <summary>
        /// The 'x0' code
        /// </summary>
        FirstNumeral = x0,

        /// <summary>
        /// The 'x9' code
        /// </summary>
        LastNumeral = x9,

        /// <summary>
        /// The 'A' code
        /// </summary>
        FirstLetter = A,

        /// <summary>
        /// The 'F' code
        /// </summary>
        LastLetter = F,       

        /// <summary>
        /// The value to subtract from a symbolic digit [A..F] to compute an index in the range [0..15]
        /// </summary>
        LetterOffset = FirstLetter - LastNumeral + FirstNumeral - 1,

        /// <summary>
        /// The value to subtract from a symbolic digit [0..9] to compute an index in the range [0..15]
        /// </summary>
        NumeralOffset = FirstNumeral,

        /// <summary>
        /// The numeral declaration count
        /// </summary>
        NumeralCount = LastNumeral - FirstNumeral + 1,

        /// <summary>
        /// The lettr declaration count
        /// </summary>
        LetterCount = LastLetter - FirstLetter + 1,

        /// <summary>
        /// The code declaration count
        /// </summary>
        Count = NumeralCount +  LetterCount,


    }    
}