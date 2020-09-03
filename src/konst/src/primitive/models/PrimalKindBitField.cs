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

    using api = Primal;

    [ApiDataType]
    public readonly struct PrimalKindBitField : IRefinedBitField<PrimalKind,byte>
    {
        readonly byte Data;

        [MethodImpl(Inline)]
        public PrimalKindBitField(PrimalKind src)
            => Data = (byte)src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(LiteralKind src)
            => Data = (byte)src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(byte src)
            => Data = src;

        [MethodImpl(Inline)]
        public bool Equals(PrimalKindBitField src)
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