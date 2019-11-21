//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    


    public readonly struct N14 : INatSeq<N14>, INatEven<N14>
    {
        public static N14 Rep => default;

        public static NatSeq<N1,N4> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N14 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }


}