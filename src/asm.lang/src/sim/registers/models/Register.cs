//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = AsmRegs;

    [Datatype]
    public readonly struct Register : IDataTypeEquatable<Register>
    {
        public RegKind Kind {get;}

        [MethodImpl(Inline)]
        public Register(RegKind kind)
            => Kind = kind;

        [MethodImpl(Inline)]
        public Register(RegIndex c, RegClass k, RegWidth w)
            => Kind = AsmRegs.kind(c,k,w);

        public RegIndex Code
            => api.index(Kind);

        public RegClass Class
            => api.@class(Kind);

        public RegWidth Width
            => api.width(Kind);

        public Identifier Name
            => Kind.ToString();

        [MethodImpl(Inline)]
        public bool Equals(Register src)
            => src.Kind == Kind;

        public override int GetHashCode()
            => (int)Kind;

        public override bool Equals(object obj)
            => obj is Register x && Equals(x);

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Register(RegKind src)
            => new Register(src);

        [MethodImpl(Inline)]
        public static implicit operator RegKind(Register src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator @enum<RegKind,uint>(Register src)
            => @enum.e32u(src.Kind);

        [MethodImpl(Inline)]
        public static implicit operator Register(@enum<RegKind,uint> src)
            => new Register(src.Literal);

        public static Register Empty
            => RegKind.None;
    }
}