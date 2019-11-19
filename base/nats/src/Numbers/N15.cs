//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N15 : INatSeq<N15>, INatDivisible<N15,N5>
    {
        public static N15 Rep => default;

        public static NatSeq<N1,N5> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N15 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }


}