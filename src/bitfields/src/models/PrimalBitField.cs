//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    public class PrimalBitField
    {    
        [MethodImpl(Inline)]
        public static PrimalBitField<V,T> init<V,T>(V value, T rep = default)
            where V : unmanaged, Enum
            where T : unmanaged
                => new PrimalBitField<V,T>(value);
        
        [MethodImpl(Inline)]
        public static PrimalBitField<V,T,I,W,S,M> init<V,T,I,W,S,M>(V value)
            where V : unmanaged, Enum
            where T : unmanaged 
            where I : unmanaged, Enum
            where W : unmanaged, Enum
            where S : unmanaged, Enum
            where M : unmanaged, Enum
                => new PrimalBitField<V,T,I,W,S,M>(value);

        [MethodImpl(Inline)]
        public static T data<F,T>(F f, byte i0, byte i1)
            where T : unmanaged 
            where F : IPrimalBitField<T>
                => gbits.extract(f.FieldData,i0,i1);

        [MethodImpl(Inline)]
        public static T data<F,I,T>(F f, I i0, I i1)
            where T : unmanaged 
            where F : IPrimalBitField<T>
            where I : unmanaged, Enum
                => data<F,T>(f, Enums.u8(i0), Enums.u8(i1));
    }
}