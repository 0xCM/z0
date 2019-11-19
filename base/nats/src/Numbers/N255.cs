//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N255 : INatSeq<N255>, INatPrior<N255,N256>
    {
        public static N255 Rep => default;

        public static NatSeq<N2,N5,N5> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N255 src)
            => (int)src.NatValue;
        

        public NatSeq Sequence 
            => Seq.Sequence;

        public ulong NatValue 
            => Seq.NatValue;

        public string format() => Seq.format();

        public override string ToString() 
            => Seq.format();
        
    }

}