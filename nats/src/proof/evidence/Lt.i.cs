//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static Components;


    /// <summary>
    /// Requires k1 < k2
    /// </summary>
    public interface INatLt<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 <= k2
    /// </summary>
    public interface INatLtEq<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }


}