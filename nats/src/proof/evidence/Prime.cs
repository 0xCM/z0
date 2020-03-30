//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static nfunc;

   /// <summary>
   // Captures evidence that k:K => k is prime
   // </summary>
   public readonly struct NatPrime<K> : INatPrime<K>
        where K : unmanaged, ITypeNat
    {
        static readonly K k = default;

        public NatPrime(K n)
            => valid = demand(NatPrime.test(n.NatValue));

        public bool valid {get;}

        public ulong NatValue 
            => k.NatValue;

        public string format()
            => valid ? $"{k} is prime" : $"INVALID({k} is prime)";    
        
        public override string ToString()
            => format();
    }

    static class NatPrime
    {
        /// <summary>
        /// Determines whether an integer is prime, very inefficiently
        /// </summary>
        /// <param name="x">The integer to examine</param>
        /// <typeparam name="T">The underlying integer type</typeparam>
        public static bool test(ulong x)
        {
            static IEnumerable<ulong> range(ulong first, ulong last)
            {
                var current = first;
                if(first < last)
                    while(current<= last)
                        yield return current++;
                else
                    while(current >= last)
                        yield return current--;
            }

            static IEnumerable<ulong> divisors(ulong src)
            {        
                if(src != 0 && src != 1)
                {
                    var upper = src/2 + 1;
                    var candidates = range(2ul, upper);
                    foreach(var c in candidates)
                        if(src % c == 0 )
                            yield return c;
                }    
            }

            return divisors(x).Count() == 0;
        }                
    }
}