//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = Symbols;

    public readonly struct Sym8<T> : ISym<W8,T>
        where T : unmanaged
    {
        public SymIdentity Identity {get;}

        public SymKey<byte> Index {get;}

        public Identifier Name {get;}

        public T Kind {get;}

        public SymExpr Expr {get;}

        public TextBlock Description {get;}

        public bool Hidden {get;}

        [MethodImpl(Inline)]
        public Sym8(SymIdentity id, SymKey<byte> key, Identifier name, T value, SymExpr expr, TextBlock? description = null, bool hidden = false)
        {
            Identity = id;
            Index = key;
            Name = name;
            Kind = value;
            Expr = expr;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        public Identifier Type
            => typeof(T).Name;

        public byte Value
        {
            [MethodImpl(Inline)]
            get => bw8(Kind);
        }
        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym8(Sym8<T> src)
            => new Sym8(src.Identity, src.Index, src.Type, src.Name, bw8(src.Kind), src.Expr, src.Description, src.Hidden);

        [MethodImpl(Inline)]
        public static implicit operator Sym<T>(Sym8<T> src)
            => new Sym<T>(src.Identity, src.Index.Value, src.Name, src.Kind, src.Expr, src.Description, src.Hidden);
    }
}