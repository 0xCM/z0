//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PrimalKindBitField : IRefinedBitField<PrimalKind,byte>
    {        
        public PrimalKind FieldValue {get;}

        public PrimalKind Kind
        {
            [MethodImpl(Inline)]
            get => FieldValue;
        }

        public TypeCode TypeCode
        {
            [MethodImpl(Inline)]
            get => PrimalKindBitFields.code(this);
        }

        public SignKind Sign
        {
            [MethodImpl(Inline)]
            get => PrimalKindBitFields.sign(this);
        }

        public BitSize Width
        {
            [MethodImpl(Inline)]
            get => PrimalKindBitFields.width(this);
        }        

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => (uint)Width/8;
        }        

        [MethodImpl(Inline)]
        public PrimalKindBitField(PrimalKind src)
            => FieldValue = src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(PrimalLiteralKind src)
            => FieldValue = (PrimalKind)src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(byte src)
            => FieldValue = (PrimalKind)src;

        [MethodImpl(Inline)]
        public bool Equals(PrimalKindBitField src)
            => FieldValue == src.FieldValue;
    }
}