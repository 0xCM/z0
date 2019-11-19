//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N8192: INatSeq<N8192>, INatPow<N8192, N2, N13>,INatPow2<N13>,
        INatDivisible<N8192,N4096>, INatDivisible<N8192,N2048>, INatDivisible<N8192,N1024>, 
        INatDivisible<N8192,N512>, INatDivisible<N8192,N256>, INatDivisible<N8192,N128>, 
        INatDivisible<N8192,N64>, INatDivisible<N8192,N32>, INatDivisible<N8192,N16>, 
        INatDivisible<N8192,N8>, INatDivisible<N8192,N4>    

    {
        public const ulong Value = 1ul << 13;        

        public static NatSeq<N8,N1,N9,N2> Seq => default; 

        [MethodImpl(Inline)]
        public static implicit operator int(N8192 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        ITypeNat INatPow2.Exponent 
            => N13.Rep;
 
        public override string ToString() 
            => Seq.format();
   }


}