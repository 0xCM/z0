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

    public readonly struct Sym : ISym
    {
        public SymIdentity Identity {get;}

        public SymKey Index {get;}

        public Identifier Type {get;}

        public ulong Kind {get;}

        public Identifier Name {get;}

        public SymExpr Expr {get;}

        public TextBlock Description {get;}

        public bool Hidden {get;}

       [MethodImpl(Inline)]
        public Sym(SymIdentity id, SymKey index, Identifier type, ulong kind, Identifier name, SymExpr symbol, TextBlock? description = null, bool hidden = false)
        {
            Identity = id;
            Index = index;
            Type = type;
            Kind = kind;
            Name = name;
            Expr = symbol;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        public ulong Value
        {
            [MethodImpl(Inline)]
            get => Kind;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static Sym Empty
        {
            [MethodImpl(Inline)]
            get => new Sym(SymIdentity.Empty, default, Identifier.Empty, 0ul, Identifier.Empty, SymExpr.Empty);
        }
    }
}