//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    


    public readonly struct N24 : INatSeq<N24>, INatEven<N24>
    {
        public static N24 Rep => default;

        public static NatSeq<N2,N4> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N24 src)
            => (int)src.NatValue;


        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }


}