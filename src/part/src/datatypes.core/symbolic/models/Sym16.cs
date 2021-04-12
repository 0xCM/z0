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

        public Identifier Type {get;}

        public Identifier Name {get;}

        public ushort Kind {get;}

        public SymExpr Expr {get;}

        [MethodImpl(Inline)]
        public Sym16(SymIdentity id, SymKey<ushort> index, Identifier type, Identifier name, ushort kind, SymExpr expr)
        {
            Identity = id;
            Index = index;
            Type = type;
            Name = name;
            Kind = kind;
            Expr = expr;
        }
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym<ushort>(Sym16 src)
            => new Sym<ushort>(src.Index.Value, src.Name, src.Kind, src.Expr);
    }

    public readonly struct Sym16<T> : ISym<W16,T>
        where T : unmanaged
    {
        public SymIdentity Identity {get;}

        public SymKey<ushort> Index {get;}

        public Identifier Type
            => typeof(T).Name;
        public Identifier Name {get;}

        public T Kind {get;}

        public SymExpr Expr {get;}

        [MethodImpl(Inline)]
        public Sym16(SymKey<ushort> index, Identifier name, T kind, SymExpr expr)
        {
            Identity = default;
            Index = index;
            Name = name;
            Kind = kind;
            Expr = expr;
        }

        [MethodImpl(Inline)]
        public Sym16(SymIdentity id, SymKey<ushort> index, Identifier name, T kind, SymExpr expr)
        {
            Identity = id;
            Index = index;
            Name = name;
            Kind = kind;
            Expr = expr;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym16(Sym16<T> src)
            => new Sym16(src.Identity, src.Index, src.Type, src.Name, memory.bw16(src.Kind), src.Expr);

        [MethodImpl(Inline)]
        public static implicit operator Sym<T>(Sym16<T> src)
            => new Sym<T>(src.Identity, src.Index.Value, src.Name, src.Kind, src.Expr);
    }
}