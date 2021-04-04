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
    public readonly struct Token : IToken
    {
        public SymLiteral Literal {get;}

        public Type TokenType {get;}

        [MethodImpl(Inline)]
        public Token(Type type, SymLiteral src)
        {
            TokenType = type;
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

        public SymbolName SymbolName
        {
            [MethodImpl(Inline)]
            get => new SymbolName(this);
        }

        public ulong Value
        {
            [MethodImpl(Inline)]
            get => Literal.EncodedValue;
        }

        public TextBlock SymbolText
        {
            [MethodImpl(Inline)]
            get => Literal.Symbol;
        }

        public TextBlock Description
        {
            [MethodImpl(Inline)]
            get => Literal.Description;
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
            => Symbols.format(this);

        public override string ToString()
            => Format();

        public static Token Empty => default;
    }
}