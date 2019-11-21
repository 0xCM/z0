//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N13 : INatSeq<N13>, INatPrime<N11>
    {
        public static N13 Rep => default;

        public static NatSeq<N1,N3> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N13 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}