//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = Registers;

    [Datatype]
    public readonly struct Register : IDataTypeEquatable<Register>
    {
        public RegisterKind Kind {get;}

        [MethodImpl(Inline)]
        public Register(RegisterKind kind)
            => Kind = kind;

        [MethodImpl(Inline)]
        public Register(RegisterIndex c, RegisterClass k, RegisterWidth w)
            => Kind = Registers.join(c,k,w);

        public RegisterIndex Code
            => api.code(Kind);

        public RegisterClass Class
            => api.@class(Kind);

        public RegisterWidth Width
            => api.width(Kind);

        public bit Hi
            => api.hi(Kind);

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
        public static implicit operator Register(RegisterKind src)
            => new Register(src);

        [MethodImpl(Inline)]
        public static implicit operator RegisterKind(Register src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static implicit operator @enum<RegisterKind,uint>(Register src)
            => @enum.e32u(src.Kind);

        [MethodImpl(Inline)]
        public static implicit operator Register(@enum<RegisterKind,uint> src)
            => new Register(src.Literal);
    }
}