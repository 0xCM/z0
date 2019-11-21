//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N17 : INatSeq<N17>, INatPrime<N11>
    {
        public static NatSeq<N1,N7> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N17 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }


}