//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    


    public readonly struct N32768 : INatSeq<N32768>, INatPow<N32768, N2, N15>, INatPow2<N15>,
        INatDivisible<N32768,N16384>, INatDivisible<N32768,N8192>, INatDivisible<N32768,N4096>, 
        INatDivisible<N32768,N2048>, INatDivisible<N32768,N1024>, INatDivisible<N32768,N512>, 
        INatDivisible<N32768,N256>, INatDivisible<N32768,N128>, INatDivisible<N32768,N64>, 
        INatDivisible<N32768,N32>, INatDivisible<N32768,N16>, INatDivisible<N32768,N8>, 
        INatDivisible<N32768,N4>    

    {
        public const ulong Value = 1ul << 15;
        
        public static NatSeq<N3,N2,N7,N6,N8> Seq => default; 

        [MethodImpl(Inline)]
        public static implicit operator int(N32768 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Value;

        ITypeNat INatPow2.Exponent 
            => N15.Rep;
 
        public override string ToString() 
            => Seq.format();
   }
}