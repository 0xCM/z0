//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static Root;

   /// <summary>
   // Captures evidence that k:K => k is prime
   // </summary>
   public readonly struct NatPrime<K> : INatPrime<K>
        where K : unmanaged, ITypeNat
    {
        static readonly K k = default;

        public NatPrime(K n)
            => valid = demand(prime(n.NatValue));

        public bool valid {get;}

        public ulong NatValue 
            => k.NatValue;

        public string format()
            => valid ? $"{k} is prime" : $"INVALID({k} is prime)";    
        
        public override string ToString()
            => format();

    }
}