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

    public class Sym8 : ISym<W8,byte>
    {
        public SymIdentity Identity {get;}

        public SymKey<byte> Index {get;}

        public Identifier Type {get;}

        public Identifier Name {get;}

        public byte Kind {get;}

        public SymExpr Expr {get;}

        public TextBlock Description {get;}

        public bool Hidden {get;}

        Sym8()
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
        public Sym8(SymIdentity id, SymKey<byte> key, Identifier kind, Identifier name, byte value, SymExpr expr, TextBlock? description = null, bool hidden = false)
        {
            Identity = id;
            Index = key;
            Type = kind;
            Name = name;
            Kind = value;
            Expr = expr;
            Description = description ?? TextBlock.Empty;
            Hidden = hidden;
        }

        public byte Value
        {
            [MethodImpl(Inline)]
            get => Kind;
        }

        public string Format()
            => string.Format(Sym.RenderPattern, Index, Type, Name, Expr, Kind, Description);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Sym<byte>(Sym8 src)
            => new Sym<byte>(src.Identity, src.Index, src.Name, src.Kind, src.Expr, src.Description, src.Hidden);
    }
}