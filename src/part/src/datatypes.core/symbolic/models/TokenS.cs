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

        public static Token<K> Empty => default;
    }
}