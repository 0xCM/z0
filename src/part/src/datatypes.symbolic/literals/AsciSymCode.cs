//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using S = AsciSymSymbol;

    [CodeProvider(typeof(S))]
    public enum AsciSymCode : byte
    {
        /// <summary>
        /// The '&' character code 38
        /// </summary>
        Amp = (byte)S.Amp,

        /// <summary>
        /// The '.' character code 46
        /// </summary>
        Dot = (byte)S.Dot,

        /// <summary>
        /// The ' ' character code 32
        /// </summary>
        Space = (byte)S.Space,

        /// <summary>
        /// The '#' character code 35
        /// </summary>
        Hash = (byte)S.Hash,

        /// <summary>
        /// The '$' character code 36
        /// </summary>
        Dollar = (byte)S.Dollar,

        /// <summary>
        /// The '/' character code 47
        /// </summary>
        FS = (byte)S.FS,

        /// <summary>
        /// The '@' character code 64
        /// </summary>
        At = (byte)S.At,

        /// <summary>
        /// The '\\' character code 92
        /// </summary>
        BS = (byte)S.BS,

        /// <summary>
        /// The '_' character code 95
        /// </summary>
        US = (byte)S.US,

        /// <summary>
        /// The ',' character code 44
        /// </summary>
        Comma = (byte)S.Comma,

        /// <summary>
        /// The '|' character code 124
        /// </summary>
        Pipe = (byte)S.Pipe,

        /// <summary>
        /// The '?' character code 63
        /// </summary>
        Question = (byte)S.Question,

        /// <summary>
        /// The '"' character code 34
        /// </summary>
        DQuote = (byte)S.DQuote,

        /// <summary>
        /// The ''' character code 39
        /// </summary>
        SQuote = (byte)S.SQuote,

        /// <summary>
        /// The '(' character code 40
        /// </summary>
        LParen = (byte)S.LParen,

        /// <summary>
        /// The ')' character code 41
        /// </summary>
        RParen = (byte)S.RParen,

        /// <summary>
        /// The ':' character code 58
        /// </summary>
        Colon = (byte)S.Colon,

        /// <summary>
        /// The ';' character code 59
        /// </summary>
        Semicolon = (byte)S.Semicolon,

        /// <summary>
        /// The '[' character code 91
        /// </summary>
        LB = (byte)S.LB,

        /// <summary>
        /// The ']' character code 93
        /// </summary>
        RB = (byte)S.RB,

        /// <summary>
        /// The '{' character code 123
        /// </summary>
        LBrace = (byte)S.LBrace,

        /// <summary>
        /// The '}' character code 125
        /// </summary>
        RBrace = (byte)S.RBrace,
    }
}