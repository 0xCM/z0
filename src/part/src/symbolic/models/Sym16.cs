//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = Symbols;

    public class Sym16 : ISym<W16,ushort>
    {
        public SymIdentity Identity {get;}

        public SymKey<ushort> Index {get;}

        public Identifier Type {get;}

        public Identifier Name {get;}

        public ushort Kind {get;}

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
        public Sym16(SymIdentity id, SymKey<ushort> index, Identifier type, Identifier name, ushort kind, SymExpr expr, TextBlock? description = null, bool hidden = false)
        {
            Identity = id;
            Index = index;
            Type = type;
            Name = name;
            Kind = kind;
            Expr = expr;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        public ushort Value
        {
            [MethodImpl(Inline)]
            get => Kind;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym<ushort>(Sym16 src)
            => api.symbol(src.Identity, src.Index, src.Name, src.Kind, src.Expr, src.Description, src.Hidden);
    }
}