//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    using api = PrimalKindBits;

    [ApiDataType]
    public readonly struct PrimalKindInfo
    {
        readonly byte Data;

        [MethodImpl(Inline)]
        public PrimalKindInfo(PrimalKind src)
            => Data = (byte)src;

        [MethodImpl(Inline)]
        public PrimalKindInfo(LiteralKind src)
            => Data = (byte)src;

        [MethodImpl(Inline)]
        public PrimalKindInfo(byte src)
            => Data = src;

        [MethodImpl(Inline)]
        public bool Equals(PrimalKindInfo src)
            => Data == src.Data;

        public PrimalKind Kind
        {
            [MethodImpl(Inline)]
            get => (PrimalKind)Data;
        }

        public byte Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public TypeWidth Width
        {
            [MethodImpl(Inline)]
            get => api.width(this);
        }

        public SignKind Sign
        {
            [MethodImpl(Inline)]
            get => api.sign(this);
        }

        public TypeCode TypeCode
        {
            [MethodImpl(Inline)]
            get => api.code(this);
        }

        public PrimalKindId KindId
        {
            [MethodImpl(Inline)]
            get => api.id(this);
        }
    }
}