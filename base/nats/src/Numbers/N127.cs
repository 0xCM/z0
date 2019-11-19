//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N127 : INatSeq<N127>, INatPrior<N127,N128>
    {
        public static N127 Rep => default;
        
        public static NatSeq<N1,N2,N7> Seq => default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N127 src)
            => (int)src.NatValue;
        
        public NatSeq Sequence 
            => Seq;
        
        public ulong NatValue 
            => Seq.NatValue;
                
        public override string ToString() 
            => Seq.format();
    }


}