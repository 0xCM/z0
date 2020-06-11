//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INat7<F> : INatNumber<N7>,         
        INatPrimitive<N7>, 
        INatSeq<N7>,
        INatPrime<N7>, 
        INatOdd<N7>,
        INatPrior<N7,N6>
            where F : unmanaged, INat7<F>
    {
        
    }
}