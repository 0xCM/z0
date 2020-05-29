//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using PSym = AsciPair;

    public enum AsciPairCode : byte
    {
        Null = 0,
        
        /// <summary>
        /// The '"' character code 34
        /// </summary>
        QuoteD = (byte)PSym.QuoteD,

        /// <summary>
        /// The ''' character code 39
        /// </summary>
        QuoteS = (byte)PSym.QuoteS,

        /// <summary>
        /// The '(' character code 40
        /// </summary>
        LParen = (byte)PSym.ParenL,        

        /// <summary>
        /// The ')' character code 41
        /// </summary>
        RParen = (byte)PSym.ParenR,        

        /// <summary>
        /// The ':' character code 58
        /// </summary>
        Colon = (byte)PSym.Colon,

        /// <summary>
        /// The ';' character code 59
        /// </summary>
        ColonS = (byte)PSym.ColonS,

        /// <summary>
        /// The '[' character code 91
        /// </summary>
        BrackL = (byte)PSym.BrackL,

        /// <summary>
        /// The ']' character code 93
        /// </summary>
        BrackR = (byte)PSym.BrackR,

        /// <summary>
        /// The '{' character code 123
        /// </summary>
        BraceL = (byte)PSym.BraceL,

        /// <summary>
        /// The '}' character code 125
        /// </summary>
        BraceR = (byte)PSym.BraceR,
    }
}