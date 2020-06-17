//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct N256 : 
        INativeNatural,
        INatSeq<N256,N2,N5,N6>, 
        INatPow<N256,N2,N8>, 
        INatPow2<N8>, 
        INatDivisible<N256,N4>, 
        INatDivisible<N256,N8>, 
        INatDivisible<N256,N16>, 
        INatDivisible<N256,N32>, 
        INatDivisible<N256,N64>, 
        INatDivisible<N256,N128>
    {
        public const ulong Value = 1ul << 8;

        [MethodImpl(Inline)]
        public static implicit operator int(N256 src) => 256;

        [MethodImpl(Inline)]
        public static implicit operator W256(N256 src) => default(W256);

        [MethodImpl(Inline)]
        public static implicit operator N256(W256 src) => default(N256);

        public ulong NatValue => Value;
        
        public override string ToString() 
            => Value.ToString();
    }
}