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

    public class Sym16<T> : ISym<W16,T>
        where T : unmanaged
    {
        public SymIdentity Identity {get;}

        public SymKey<ushort> Index {get;}

        public Identifier Name {get;}

        public T Kind {get;}

        public SymExpr Expr {get;}

        public TextBlock Description {get;}

        public bool Hidden {get;}

        Sym16()
        {
            Identity = SymIdentity.Empty;
            Index = default;
            Name = Identifier.Empty;
            Kind = default;
            Expr = SymExpr.Empty;
            Description = TextBlock.Empty;
            Hidden = true;
        }

        [MethodImpl(Inline)]
        public Sym16(SymKey<ushort> index, Identifier name, T kind, SymExpr expr, TextBlock? description = null, bool hidden = false)
        {
            Identity = default;
            Index = index;
            Name = name;
            Kind = kind;
            Expr = expr;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        [MethodImpl(Inline)]
        public Sym16(SymIdentity id, SymKey<ushort> index, Identifier name, T kind, SymExpr expr, TextBlock? description = null, bool hidden = false)
        {
            Identity = id;
            Index = index;
            Name = name;
            Kind = kind;
            Expr = expr;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        public ushort Value
        {
            [MethodImpl(Inline)]
            get => bw16(Kind);
        }

        public Identifier Type
            => typeof(T).Name;

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym16(Sym16<T> src)
            => new Sym16(src.Identity, src.Index, src.Type, src.Name, bw16(src.Kind), src.Expr, src.Description, src.Hidden);

        [MethodImpl(Inline)]
        public static implicit operator Sym<T>(Sym16<T> src)
            => new Sym<T>(src.Identity, src.Index.Value, src.Name, src.Kind, src.Expr, src.Description, src.Hidden);
    }
}