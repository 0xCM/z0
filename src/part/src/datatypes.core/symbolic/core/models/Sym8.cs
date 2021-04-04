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

    public readonly struct Sym8 : ISym<W8,byte>
    {
        public SymIdentity Identity {get;}

        public SymKey<byte> Index {get;}

        public Identifier Type {get;}

        public Identifier Name {get;}

        public byte Kind {get;}

        public SymExpr Expr {get;}

        [MethodImpl(Inline)]
        public Sym8(SymIdentity id, SymKey<byte> key, Identifier kind, Identifier name, byte value, SymExpr expr)
        {
            Identity = id;
            Index = key;
            Type = kind;
            Name = name;
            Kind = value;
            Expr = expr;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym<byte>(Sym8 src)
            => new Sym<byte>(src.Index.Value, src.Name, src.Kind, src.Expr);
    }

    public readonly struct Sym8<T> : ISym<W8,T>
        where T : unmanaged
    {
        public SymIdentity Identity {get;}

        public SymKey<byte> Index {get;}

        public Identifier Name {get;}

        public T Kind {get;}

        public SymExpr Expr {get;}

        public Identifier Type
            => typeof(T).Name;

        [MethodImpl(Inline)]
        public Sym8(SymIdentity id, SymKey<byte> key, Identifier name, T value, SymExpr expr)
        {
            Identity = id;
            Index = key;
            Name = name;
            Kind = value;
            Expr = expr;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym8(Sym8<T> src)
            => new Sym8(src.Identity, src.Index, src.Type, src.Name, memory.bw8(src.Kind), src.Expr);

        [MethodImpl(Inline)]
        public static implicit operator Sym<T>(Sym8<T> src)
            => new Sym<T>(src.Identity, src.Index.Value, src.Name, src.Kind, src.Expr);
    }
}