//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;

    
    /// <summary>
    /// Captures evidence that n:K & n1:K1 & n2:K2 => n1 <= n <= n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public readonly struct NatBetween<K,K1,K2> : INatBetween<K,K1,K2>
        where K: unmanaged, ITypeNat
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {        
        static readonly K k = default;

        static readonly K1 k1 = default;

        static readonly K2 k2 = default;

        static readonly string description = $"{k1} <= {k} <= {k2}";

        public NatBetween(K k, K1 k1, K2 k2)
            => valid = demand(k.NatValue >= k1.NatValue && k.NatValue <= k2.NatValue);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();
    }
 }