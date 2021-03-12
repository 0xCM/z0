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

        public Identifier Name
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

        public K Kind
        {
            [MethodImpl(Inline)]
            get => Literal.DirectValue;
        }

        public TextBlock Symbol
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

        const string TypeKind = "{0}:{1}";

        const string FormatPattern = "{0,-32} {1,-8} | {2,-12} | {2}";

        public string FormatHeader
            => string.Format(FormatPattern, "Type:Kind", nameof(Index), nameof(Name), nameof(Symbol));
        public string Format()
            => string.Format(FormatPattern, string.Format(TypeKind, typeof(K).Name, Kind), Index, text.ifempty(Name, "!!<empty>!!"), text.ifempty(Symbol, "!!<empty>!!"));

        public override string ToString()
            => Format();

        public static Token<K> Empty => default;
    }
}