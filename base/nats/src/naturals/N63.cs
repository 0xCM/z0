//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N63 : INatSeq<N63>, 
        INatPrior<N63,N64>
    {
        public static N63 Rep => default;

        public static NatSeq<N6,N3> Seq => default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N63 src)
            => (int)src.NatValue;

        
        public NatSeq Sequence 
            => Seq;
        
        public ulong NatValue 
            => Seq.NatValue;                
        
        public override string ToString() 
            => Seq.format();        
    }
}