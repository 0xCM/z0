//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N36 : INatSeq<N36>, INatEven<N36>, 
        INatDivisible<N36,N6>, INatDivisible<N36,N12>
    {
        public static N36 Rep => default;

        public static NatSeq<N4,N0> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N36 src)
            => (int)src.NatValue;


        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}