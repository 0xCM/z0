//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N128 : 
        INativeNatural,
        INatSeq<N128>,  
        INatPow<N128,N2,N7>, 
        INatPow2<N7>, 
        INatDivisible<N128,N4>, 
        INatDivisible<N128,N8>, 
        INatDivisible<N128,N16>,  
        INatDivisible<N128,N32>, 
        INatDivisible<N128,N64>        
    {
        public const ulong Value = 1ul << 7;      
                  
        public static NatSeq<N1,N2,N8> Seq => default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N128 src) => 128;
        
        [MethodImpl(Inline)]
        public static implicit operator W128(N128 src) => default(W128);

        [MethodImpl(Inline)]
        public static implicit operator N128(W128 src) => default(N128);

        public ulong NatValue => Value;
               
        public override string ToString() 
            => Seq.format();
    }
}