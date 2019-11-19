//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N256 : INatSeq<N256>, INatPow<N256, N2,N8>, INatPow2<N8>, 
        INatDivisible<N256,N4>, INatDivisible<N256,N8>, INatDivisible<N256,N16>, 
        INatDivisible<N256,N32>, INatDivisible<N256,N64>, INatDivisible<N256,N128>         

    {
        public static N256 Rep => default;

        public static NatSeq<N2,N5,N6> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N256 src)
            => (int)src.NatValue;


        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        ITypeNat INatPow2.Exponent 
            => N8.Rep;

        public override string ToString() 
            => Seq.format();
    }


}