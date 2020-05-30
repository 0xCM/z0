//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct PrimalBitField<F,I,E,S,M,T> : IPrimalBitField<F,I,E,S,M,T>
        where F : unmanaged, IPrimalBitField<F,I,E,S,M,T>
        where I : unmanaged, Enum
        where E : unmanaged, Enum
        where S : unmanaged, Enum
        where M : unmanaged, Enum
        where T : unmanaged 
    {
        public ReadOnlySpan<S> Segments  => default;

        public ReadOnlySpan<M> Masks  => default;

        public S Segment(I index) => default;

        public M Mask(I index) => default;

        public T this[I index]  => default;
    }    
}