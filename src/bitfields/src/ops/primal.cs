//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {
        [MethodImpl(Inline)]
        public static PrimalBitField<V,T> primal<V,T>(V value, T rep = default)
            where V : unmanaged, Enum
            where T : unmanaged
                => new PrimalBitField<V,T>(value);
        
        [MethodImpl(Inline)]
        public static PrimalBitField<V,T,I,W,S,M> primal<V,T,I,W,S,M>(V value)
            where V : unmanaged, Enum
            where T : unmanaged 
            where I : unmanaged, Enum
            where W : unmanaged, Enum
            where S : unmanaged, Enum
            where M : unmanaged, Enum
                => new PrimalBitField<V,T,I,W,S,M>(value);
    }
}