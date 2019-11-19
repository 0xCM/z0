//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N22 : INatSeq<N22>, INatEven<N22>
    {
        public static NatSeq<N2,N2> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N22 src)
            => (int)src.NatValue;

        public NatSeq Sequence 
            => Seq;

        public ulong NatValue 
            => Seq.NatValue;

        public override string ToString() 
            => Seq.format();
    }
}