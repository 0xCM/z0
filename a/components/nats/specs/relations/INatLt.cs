//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Requires k1 < k2
    /// </summary>
    public interface INatLt<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }

    /// <summary>
    /// Requires k1 <= k2
    /// </summary>
    public interface INatLtEq<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        
    }
}