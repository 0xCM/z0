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

    public readonly struct Sym16 : ISym<W16,ushort>
    {
        public SymIdentity Identity {get;}

        public SymKey<ushort> Index {get;}

        public Identifier Kind {get;}

        public Identifier Name {get;}

        public ushort Value {get;}

        public SymExpr Expression {get;}

        [MethodImpl(Inline)]
        public Sym16(SymIdentity id, SymKey<ushort> index, Identifier kind, Identifier name, ushort value, SymExpr expr)
        {
            Identity = id;
            Index = index;
            Kind = kind;
            Name = name;
            Value = value;
            Expression = expr;
        }
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym<ushort>(Sym16 src)
            => new Sym<ushort>(src.Index.Value, src.Name, src.Value, src.Expression);
    }

    public readonly struct Sym16<T> : ISym<W16,T>
        where T : unmanaged
    {
        public SymIdentity Identity {get;}

        public SymKey<ushort> Index {get;}

        public Identifier Kind
            => typeof(T).Name;
        public Identifier Name {get;}

        public T Value {get;}

        public SymExpr Expression {get;}

        [MethodImpl(Inline)]
        public Sym16(SymKey<ushort> index, Identifier name, T value, SymExpr expr)
        {
            Identity = default;
            Index = index;
            Name = name;
            Value = value;
            Expression = expr;
        }

        [MethodImpl(Inline)]
        public Sym16(SymIdentity id, SymKey<ushort> index, Identifier name, T value, SymExpr expr)
        {
            Identity = id;
            Index = index;
            Name = name;
            Value = value;
            Expression = expr;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym16(Sym16<T> src)
            => new Sym16(src.Identity, src.Index, src.Kind, src.Name, memory.bw16(src.Value), src.Expression);

        [MethodImpl(Inline)]
        public static implicit operator Sym<T>(Sym16<T> src)
            => new Sym<T>(src.Identity, src.Index.Value, src.Name, src.Value, src.Expression);
    }
}