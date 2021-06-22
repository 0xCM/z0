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

    public class Sym<K> : ISym<K>
        where K : unmanaged
    {
        public SymIdentity Identity {get;}

        public SymKey Key {get;}

        public Identifier Name {get;}

        public K Kind {get;}

        public SymExpr Expr {get;}

        public TextBlock Description {get;}

        public bool Hidden {get;}

        Sym()
        {
            Identity = SymIdentity.Empty;
            Key = default;
            Name = Identifier.Empty;
            Kind = default;
            Expr = SymExpr.Empty;
            Description = TextBlock.Empty;
            Hidden = true;
        }

        [MethodImpl(Inline)]
        internal Sym(uint index, SymLiteral<K> src)
        {
            Identity = src.Identity;
            Key = index;
            Kind = src.Symbol.Kind;
            Name = src.Name;
            Expr = src.Symbol;
            Description = src.Description;
            Hidden = src.Hidden;
        }

        [MethodImpl(Inline)]
        internal Sym(SymIdentity id, SymKey index, Identifier name, K kind, SymExpr symbol, TextBlock? description = null, bool hidden = false)
        {
            Identity = id;
            Key = index;
            Name = name;
            Kind = kind;
            Expr = symbol;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        public ulong Value
        {
            [MethodImpl(Inline)]
            get => bw64(Kind);
        }

        public Identifier Type
            => typeof(K).Name;

        public string Format()
            => string.Format(Sym.RenderPattern, Key, Type, Name, Expr, Kind, Description);

        public override string ToString()
            => Format();

        // [MethodImpl(Inline)]
        // public static implicit operator Sym(Sym<K> src)
        //     => api.untyped(src);

        [MethodImpl(Inline)]
        public static implicit operator K(Sym<K> src)
            => src.Kind;

        public static Sym<K> Empty
        {
            [MethodImpl(Inline)]
            get => new Sym<K>();
        }
    }
}