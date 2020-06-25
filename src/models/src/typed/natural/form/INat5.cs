//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INat5<F> : INatNumber<N5>,         
        INatPrimitive<N5>, 
        INatPrior<N5,N4>, 
        INatSeq<N5>,
        INatPrime<N5>, 
        INatOdd<N5>
            where F : unmanaged, INat5<F>
    {
        
    }
}