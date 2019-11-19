//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    


    public readonly struct N12 : INatSeq<N12>, INatEven<N12>
    {
        public static N12 Rep => default;

        public static NatSeq<N1,N2> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N12 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}