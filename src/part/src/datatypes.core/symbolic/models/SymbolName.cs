//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines the name of a symbol
    /// </summary>
    public readonly struct SymbolName
    {
        readonly IToken Token;

        [MethodImpl(Inline)]
        internal SymbolName(IToken token)
            => Token = token;

        public Identifier Identifier
        {
            [MethodImpl(Inline)]
            get => Token.Identifier;
        }

        public TextBlock SymbolText
        {
            [MethodImpl(Inline)]
            get => Token.SymbolText;
        }

        [MethodImpl(Inline)]
        public string Format()
            => SymbolText;

        public override string ToString()
            => Format();
    }
}