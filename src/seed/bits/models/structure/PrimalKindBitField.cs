//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PrimalKindField;

    public readonly struct PrimalKindBitField : IBitField<PrimalKind,byte>
    {
        public const byte TotalFieldWidth = (byte)SegWidth.KindId + (byte)SegWidth.Width + (byte)SegWidth.Sign;

        public PrimalKind FieldValue {get;}

        public byte Data
        {
            [MethodImpl(Inline)]
            get => (byte)FieldValue;
        }

        [MethodImpl(Inline)]
        public PrimalKindBitField(PrimalKind src)
            => FieldValue = src;

        [MethodImpl(Inline)]
        public PrimalKindBitField(byte src)
            => FieldValue = (PrimalKind)src;

        [MethodImpl(Inline)]
        public bool Equals(PrimalKindBitField src)
            => FieldValue == src.FieldValue;

        public Pow2Width FieldWidth
        {
            [MethodImpl(Inline)]
            get => PrimalKindBitFields.Width(this);
        }        
    }
}