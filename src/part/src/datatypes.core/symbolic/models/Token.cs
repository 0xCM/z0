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
        public SymbolicLiteral Literal {get;}

        public Type TokenType {get;}

        [MethodImpl(Inline)]
        public Token(Type type, SymbolicLiteral src)
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

        public Identifier UniqueName
        {
            [MethodImpl(Inline)]
            get => Literal.UniqueName;
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

        const string FormatPattern = "{0,-24} | {1,-8} | {2,-12} | {3}";

        public static string HeaderFormat
            => string.Format(FormatPattern, nameof(LiteralType), nameof(Index), nameof(Identifier), nameof(SymbolText));

        public string Format()
            => Description.IsEmpty
            ? string.Format("{0,-24} | {1,-8} | {2,-12} | {3}",
                Literal.Type, Index, text.ifempty(Identifier, RP.EmptySymbol), text.ifempty(SymbolText, RP.EmptySymbol))
            : string.Format("{0,-24} | {1,-8} | {2,-12} | {3} | {4}",
                Literal.Type, Index, text.ifempty(Identifier, RP.EmptySymbol), text.ifempty(SymbolText, RP.EmptySymbol), Description);

        public override string ToString()
            => Format();

        public static Token Empty => default;
    }
}