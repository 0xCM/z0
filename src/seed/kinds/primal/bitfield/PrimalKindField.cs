//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public readonly struct PrimalKindField
    {
        public static PrimalKindField Empty => default(PrimalKindField);
        
        public PrimalKind FieldValue {get;}

        public byte FieldData
        {
            [MethodImpl(Inline)]
            get => (byte)FieldValue;
        }
        
        [MethodImpl(Inline)]
        public PrimalKindField(PrimalKind src)
            => FieldValue = src;

        [MethodImpl(Inline)]
        public PrimalKindField(byte src)
            => FieldValue = (PrimalKind)src;
    
        [MethodImpl(Inline)]
        public bool Equals(PrimalKindField src)
            => src.FieldData == src.FieldData;
    }
}