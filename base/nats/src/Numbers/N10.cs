//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N10 : INatSeq<N10>, INatEven<N10>, INatDivisible<N10,N5>
    {
        public static N10 Rep=> default;

        public static NatSeq<N1,N0> Seq=> default;

        [MethodImpl(Inline)]
        public static implicit operator int(N10 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}