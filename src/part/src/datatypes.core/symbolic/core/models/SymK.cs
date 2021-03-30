//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Symbols;

    public readonly struct Sym<K> : ISym<K>
        where K : unmanaged
    {
        public SymKey Key {get;}

        public Identifier Name {get;}

        public K Value {get;}

        public SymExpr Expression {get;}

        [MethodImpl(Inline)]
        internal Sym(uint index, SymbolicLiteral<K> literal)
        {
            Key = index;
            Value = literal.DirectValue;
            Name = literal.Name;
            Expression = literal.Symbol;
        }

        [MethodImpl(Inline)]
        internal Sym(uint index, string name, K value, SymExpr symbol)
        {
            Key = index;
            Name = name;
            Value = value;
            Expression = symbol;
        }

        public Identifier Kind
            => typeof(K).Name;

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static Sym<K> Empty
        {
            [MethodImpl(Inline)]
            get => new Sym<K>(default, EmptyString, default, SymExpr.Empty);
        }
    }
}