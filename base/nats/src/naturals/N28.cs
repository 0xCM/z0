//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N28 : INatSeq<N28>
    {
        public static N28 Rep => default;

        public static NatSeq<N2,N8> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N28 src)
            => (int)src.NatValue;


        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}