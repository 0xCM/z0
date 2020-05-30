//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IPrimalBitField<F,I,E,S,M,T>
        where F : unmanaged, IPrimalBitField<F,I,E,S,M,T>
        where I : unmanaged, Enum
        where E : unmanaged, Enum
        where S : unmanaged, Enum
        where M : unmanaged, Enum
        where T : unmanaged 
    {
        ReadOnlySpan<S> Segments {get;}     

        ReadOnlySpan<M> Masks {get;}   

        S Segment(I index);

        M Mask(I index);

        T this[I index] {get;}
    }
}