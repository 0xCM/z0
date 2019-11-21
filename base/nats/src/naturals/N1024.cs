//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N1024 : INatSeq<N1024>, INatPow<N1024, N2,N10>,INatPow2<N10>,
        INatDivisible<N1024,N4>, INatDivisible<N1024,N8>, INatDivisible<N1024,N16>, 
        INatDivisible<N1024,N32>, INatDivisible<N1024,N64>, INatDivisible<N1024,N128>,
        INatDivisible<N1024,N512>, INatDivisible<N1024,N256>                     
    {
        public static NatSeq<N1,N0,N2,N4> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N1024 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        ITypeNat INatPow2.Exponent 
            => N10.Rep;

        public override string ToString() 
            => Seq.format();       
    }

}