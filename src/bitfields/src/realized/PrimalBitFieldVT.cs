//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct PrimalBitField<V,T> : IPrimalBitField<V,T>
        where V : unmanaged, Enum
        where T : unmanaged
    {
        public V FieldValue {get;}

        [MethodImpl(Inline)]
        public PrimalBitField(V value)
            => FieldValue = value;            
        
        public T FieldData 
        {
            [MethodImpl(Inline)]
            get => Enums.numeric<V,T>(FieldValue);
        }
    }
}