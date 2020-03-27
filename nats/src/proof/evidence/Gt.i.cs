//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// Requires k1 > k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public interface INatGt<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 >= k2
    /// </summary>
    /// <typeparam name="K1">The larger nat type</typeparam>
    /// <typeparam name="K2">The smaller nat type</typeparam>
    public interface INatGtEq<K1,K2> : INatDemand<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }
}