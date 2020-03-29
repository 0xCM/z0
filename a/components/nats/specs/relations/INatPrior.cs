//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Requires k1: K1 & k2:K2 => k1 - 1 = k2
    /// </summary>
    /// <typeparam name="K1"></typeparam>
    /// <typeparam name="K2"></typeparam>
    public interface INatPrior<K1,K2> : INatGt<K1,K2>, INatNonZero<K1>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {

    }       
}