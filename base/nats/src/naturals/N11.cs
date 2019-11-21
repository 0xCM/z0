//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N11 : INatSeq<N11>, INatPrime<N11>
    {
        public static N11 Rep => default;

        public static NatSeq<N1,N1> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N11 src)
            => (int)src.NatValue;
            
        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
     }



}