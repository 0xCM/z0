//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Sym8 : ISym<W8,byte>
    {
        public SymKey<byte> Key {get;}

        public Identifier Name {get;}

        public byte Value {get;}

        public SymExpr Expression {get;}

        [MethodImpl(Inline)]
        public Sym8(SymKey<byte> key, Name name, byte value, SymExpr expr)
        {
            Key = key;
            Name = name;
            Value = value;
            Expression = expr;
        }

        public string Format()
            => Symbols.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym<byte>(Sym8 src)
            => new Sym<byte>(src.Key.Value, src.Name, src.Value, src.Expression);
    }

    public readonly struct Sym8<T> : ISym<W8,T>
        where T : unmanaged
    {
        public SymKey<byte> Key {get;}

        public Identifier Name {get;}

        public T Value {get;}

        public SymExpr Expression {get;}

        [MethodImpl(Inline)]
        public Sym8(SymKey<byte> key, Identifier name, T value, SymExpr expr)
        {
            Key = key;
            Name = name;
            Value = value;
            Expression = expr;
        }

        public string Format()
            => Symbols.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym8(Sym8<T> src)
            => new Sym8(src.Key, src.Name, memory.bw8(src.Value), src.Expression);

        [MethodImpl(Inline)]
        public static implicit operator Sym<T>(Sym8<T> src)
            => new Sym<T>(src.Key.Value, src.Name, src.Value, src.Expression);

    }
}