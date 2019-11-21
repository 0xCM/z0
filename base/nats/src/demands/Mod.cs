//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static nfunc;
    
    /// <summary>
    /// Captures evidence that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public readonly struct NatMod<K1,K2,K3> : INatMod<K1,K2,K3>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
        where K3: unmanaged, ITypeNat
    {
        static readonly K1 k1 = default;
        static readonly K2 k2 = default;
        static readonly K3 k3 = default;
        
        static readonly string description = $"{k1} % {k2} = {k3}";

        public NatMod(K1 k1, K2 k2, K3 k3)
            => valid = demand(k1.NatValue % k2.NatValue == k3.NatValue);
        
        public bool valid {get;}

        public string format()
            => valid ? description: $"INVALID({description})";    
        
        public override string ToString()
            => format();

    }

    

}
