//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes binary relationship between two type naturals
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface INatRelation<K1,K2>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Characterizes ternary relationship among three type naturals
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface INatRelation<K1,K2,K3>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
        where K3 : unmanaged, ITypeNat
    {
        
    }
}