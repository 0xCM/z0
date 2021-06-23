//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using api = AsmRegs;

    [DataType]
    public readonly struct Register : IDataTypeEquatable<Register>
    {
        public RegKind Kind {get;}

        [MethodImpl(Inline)]
        public Register(RegKind kind)
            => Kind = kind;

        [MethodImpl(Inline)]
        public Register(RegIndex c, RegClass k, RegWidth w)
            => Kind = api.kind(c, k, w);

        public RegIndex Code
        {
            [MethodImpl(Inline)]
            get => api.index(Kind);
        }

        public RegClass Class
        {
            [MethodImpl(Inline)]
            get => api.@class(Kind);
        }

        public RegWidth Width
        {
            [MethodImpl(Inline)]
            get => api.width(Kind);
        }

        public Identifier Name
            => Kind.ToString();

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Kind == RegKind.None;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Kind != RegKind.None;
        }

        [MethodImpl(Inline)]
        public bool Equals(Register src)
            => src.Kind == Kind;

        public override int GetHashCode()
            => (int)Kind;

        public override bool Equals(object obj)
            => obj is Register x && Equals(x);

        public string Format()
            => Kind.ToString();


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
            => emath.e32u(src.Kind);

        [MethodImpl(Inline)]
        public static implicit operator Register(@enum<RegKind,uint> src)
            => new Register(src.Literal);

        public static Register Empty
            => RegKind.None;
    }
}