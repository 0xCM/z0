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
    /// Defines a kinded token
    /// </summary>
    public readonly struct Token<K> : IToken<K>
        where K : unmanaged
    {
        public SymbolicLiteral<K> Literal {get;}

        [MethodImpl(Inline)]
        public Token(SymbolicLiteral<K> src)
        {
            Literal = src;
        }

        public uint Index
        {
            [MethodImpl(Inline)]
            get => Literal.Position;
        }

        public Identifier Identifier
        {
            [MethodImpl(Inline)]
            get => Literal.Name;
        }

        public ClrPrimalKind LiteralType
        {
            [MethodImpl(Inline)]
            get => Literal.DataType;
        }

        public SymIdentity Identity
        {
            [MethodImpl(Inline)]
            get => Literal.Identity;
        }

        public SymbolName<K> SymbolName
        {
            [MethodImpl(Inline)]
            get => new SymbolName<K>(this);
        }

        public Type TokenType
        {
            [MethodImpl(Inline)]
            get => typeof(K);
        }

        public K Kind
        {
            [MethodImpl(Inline)]
            get => Literal.DirectValue;
        }

        public TextBlock SymbolText
        {
            [MethodImpl(Inline)]
            get => Literal.Symbol;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Index != 0;
        }

        public string Format()
            => string.Format("{0,-24} | {1,-8} | {2,-12} | {3}", typeof(K).Name, Index, text.ifempty(Identifier, RP.EmptySymbol), text.ifempty(SymbolText, RP.EmptySymbol));

        public override string ToString()
            => Format();

        public static Token<K> Empty => default;
    }
}