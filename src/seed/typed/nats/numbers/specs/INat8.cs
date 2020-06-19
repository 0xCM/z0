//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface INat8<F> : INatNumber<N8>,         
        INatPrimitive<N8>, 
        INatSeq<N8>,
        INatPow<N8,N2,N3>, 
        INatEven<N8>,
        INatPow2<N3>,
        INatDivisible<N8,N4>,
        INatPrior<N8,N7> 
            where F : unmanaged, INat8<F>
    {        
    
    }
}