//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
 
    /// <summary>
    /// Requires k prime
    /// </summary>
    /// <typeparam name="K">A prime nat type</typeparam>
    public interface INatPrime<K> : ITypeNat
        where K : unmanaged, ITypeNat
    {
        
    }
}