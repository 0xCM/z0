//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    public interface INatDigit<N,S,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
        where S : INatDigit<N,S,T>
    {

    }
}