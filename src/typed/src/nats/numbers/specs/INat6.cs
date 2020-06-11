//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INat6<F> : INatNumber<N6>,         
        INatPrimitive<N6>, 
        INatSeq<N6>, 
        INatEven<N6>, 
        INatDivisible<N6,N3>,
        INatPrior<N6,N5> 
            where F : unmanaged, INat6<F>
    {
        
    }
}