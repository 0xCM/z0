//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface INat4<F> : INatNumber<N4>,         
        INatPrimitive<N4>, 
        INatPrior<N4,N3>, 
        INatSeq<N4>, 
        INatPow<N4,N2,N2>, 
        INatEven<N4>,
        INatPow2<N2>
            where F : unmanaged, INat4<F>
    {
        
    }
}