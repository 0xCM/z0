//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    
    using static nfunc;

    public readonly struct N2048 : INatSeq<N2048>, INatPow<N2048, N2, N11>, INatPow2<N11>,
        INatDivisible<N2048,N1024>, INatDivisible<N2048,N512>, INatDivisible<N2048,N256>, INatDivisible<N2048,N128>, 
        INatDivisible<N2048,N64>, INatDivisible<N2048,N32>, INatDivisible<N2048,N16>, INatDivisible<N2048,N8>, 
        INatDivisible<N2048,N4>        
    {
        public static NatSeq<N2,N0,N4,N8> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N2048 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        ITypeNat INatPow2.Exponent 
            => N11.Rep;

        public override string ToString() 
            => Seq.format();
    }
}