//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N512 : INatSeq<N512>, INatPow<N512, N2,N9>,INatPow2<N9>, 
        INatDivisible<N512,N256>, INatDivisible<N512,N128>, INatDivisible<N512,N64>, 
        INatDivisible<N512,N32>, INatDivisible<N512,N16>, INatDivisible<N512,N8>, 
        INatDivisible<N512,N4>
    {
        public static N512 Rep => default;

        public static NatSeq<N5,N1,N2> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N512 src)
            => (int)src.NatValue;


        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        ITypeNat INatPow2.Exponent 
            => N9.Rep;


        public override string ToString() 
            => Seq.format();

    }


}