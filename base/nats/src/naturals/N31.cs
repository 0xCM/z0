//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N31 : INatSeq<N31>
    {
        public static N31 Rep => default;

        public static NatSeq<N3,N1> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N31 src)
            => (int)src.NatValue;


        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}