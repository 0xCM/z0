//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Requires k1 = n*k2 for some n>= 1
    /// </summary>
    /// <typeparam name="K1">The divisible type</typeparam>
    /// <typeparam name="K2">The divisor type</typeparam>
    public interface INatDivisible<K1,K2> : INatRelation<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {

    }
}