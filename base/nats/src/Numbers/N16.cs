//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N16 : INatSeq<N16>, INatPow<N16,N2,N4>, INatPow2<N4>, 
        INatDivisible<N16,N8>, INatDivisible<N16,N4> 
    {
        public static NatSeq<N1,N6> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N16 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        ITypeNat INatPow2.Exponent 
            => N4.Rep;

        public override string ToString() 
            => Seq.format();
    }

}