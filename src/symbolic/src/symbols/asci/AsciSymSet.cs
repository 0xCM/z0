//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using static Chars;

    public sealed class AsciSymSet : SymbolSet<AsciSymSet, AsciAlphabet>
    {
        static AsciSymSet()
        {
            _Symbols = new Symbol<AsciAlphabet>[]
            {
                Amp, At, Bang, BSlash, Caret, Colon, Comma,Dollar, Dot, Eq,
                FSlash, Gt, Hash, LBrace, LBracket, LParen, Lt, Dash, Pipe, Plus,
                Percent, Quote, RParen, RBrace, RBracket, Semicolon, Space,
                SQuote, Star, Tilde,
            };            
        }
    }
}