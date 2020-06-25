//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INat3<F> : INatNumber<N3>,
        INatPrimitive<N3>, 
        INatPrior<N3,N2>, 
        INatSeq<N3>,
        INatPrime<N3>, 
        INatOdd<N3>
            where F : unmanaged, INat3<F>
    {
        
    }
}