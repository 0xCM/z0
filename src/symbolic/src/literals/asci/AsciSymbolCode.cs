//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using S = AsciSymbol;

    public enum AsciSymbolCode : byte
    {
        /// <summary>
        /// The tab character code 9
        /// </summary>
        Tab = (byte)S.Tab,

        /// <summary>
        /// The new-line character code 10
        /// </summary>
        NewLine = (byte)S.NewLine,

        /// <summary>
        /// The line-feed character code 13
        /// </summary>
        LineFeed = (byte)S.LineFeed,

        /// <summary>
        /// The ' ' character code 32
        /// </summary>
        Space = (byte)S.Space,

        /// <summary>
        /// The '!' character code 33
        /// </summary>
        Bang = (byte)S.Bang,

        /// <summary>
        /// The '"' character code 34
        /// </summary>
        Quote = (byte)S.Quote,

        /// <summary>
        /// The '#' character code 35
        /// </summary>
        Hash = (byte)S.Hash,

        /// <summary>
        /// The '$' character code 36
        /// </summary>
        Dollar = (byte)S.Dollar,

        /// <summary>
        /// The '%' character code 37
        /// </summary>
        Percent = (byte)S.Percent,

        /// <summary>
        /// The '&' character code 38
        /// </summary>
        Amp = (byte)S.Amp,

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
        /// The '}' character code 41
        /// </summary>
        RBrace = (byte)S.RParen,

        /// <summary>
        /// The '*' character code 42
        /// </summary>
        Star = (byte)S.Star,

        /// <summary>
        /// The '+' character code 43
        /// </summary>
        Plus = (byte)S.Plus,

        /// <summary>
        /// The ,' character code 44
        /// </summary>
        Comma = (byte)S.Comma,

        /// <summary>
        /// The '-' character code 45
        /// </summary>
        Dash = (byte)S.Dash,

        /// <summary>
        /// The '.' character code 46
        /// </summary>
        Dot = (byte)S.Dot,

        /// <summary>
        /// The '/' character code 47
        /// </summary>
        FSlash = (byte)S.FSlash,

        /// <summary>
        /// The ':' character code 58
        /// </summary>
        Colon = (byte)S.Colon,

        /// <summary>
        /// The ,' character code 59
        /// </summary>
        Semicolon = (byte)S.Semicolon,

        /// <summary>
        /// The '@' character code 64
        /// </summary>
        At = (byte)S.At,

        /// <summary>
        /// The backslash character code 92
        /// </summary>
        BSlash = (byte)S.BSlash,

        /// <summary>
        /// The '^' character code 94
        /// </summary>
        Caret = (byte)S.Caret,

        /// <summary>
        /// The '=' character code 61
        /// </summary>
        Eq = (byte)S.Eq,

        /// <summary>
        /// The '>' character code 62
        /// </summary>
        Gt = (byte)S.Gt,

        /// <summary>
        /// The '{' character code 128
        /// </summary>
        LBrace = (byte)S.LBrace,

        /// <summary>
        /// The '[' character code 91
        /// </summary>
        LBracket = (byte)S.LBracket,

        /// <summary>
        /// The '<' character code 60
        /// </summary>
        Lt = (byte)S.Lt,

        /// <summary>
        /// The '|' character code 124
        /// </summary>
        Pipe = (byte)S.Pipe,

        /// <summary>
        /// The '?' character code 63
        /// </summary>
        Question = (byte)S.Question,
      
        /// <summary>
        /// The ']' character code 93
        /// </summary>
        RBracket = (byte)S.RBracket,

        /// <summary>
        /// The '~' character code 126
        /// </summary>
        Tilde = (byte)S.Tilde, 

        /// <summary>
        /// The '~' character code 95
        /// </summary>
        Underscore = (byte)S.Underscore, 
    }
}