//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using static HexSymLo;

    public enum HexSymLoFacet : ushort   
    {
        /// <summary>
        /// The 'x0' code
        /// </summary>
        FirstNumeral = x0,

        /// <summary>
        /// The 'x9' code
        /// </summary>
        LastNumeral = x9,

        /// <summary>
        /// The 'a' code
        /// </summary>
        FirstLetter = a,

        /// <summary>
        /// The 'f' code
        /// </summary>
        LastLetter = f,       

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