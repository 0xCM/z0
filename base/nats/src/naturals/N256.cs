//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N256 : INatSeq<N256,N2,N5,N6>, INatPow<N256, N2,N8>, INatPow2<N8>, 
        INatDivisible<N256,N4>, INatDivisible<N256,N8>, INatDivisible<N256,N16>, 
        INatDivisible<N256,N32>, INatDivisible<N256,N64>, INatDivisible<N256,N128>
    {
        public const ulong Value = 1ul << 8;

        public static N256 Rep => default;


        [MethodImpl(Inline)]
        public static implicit operator int(N256 src) => 256;

        public ulong NatValue => Value;
        

        public override string ToString() 
            => Value.ToString();
    }


}