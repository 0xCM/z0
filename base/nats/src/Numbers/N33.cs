//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N33 : INatSeq<N33>, INatPrime<N11> 
    {
        public static N33 Rep => default;

        public static NatSeq<N3,N3> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N33 src)
            => (int)src.value;

        public ITypeNat rep 
            => Rep;

        public NatSeq seq 
            => Seq;

        public ulong value 
            => Seq.value;

        public override string ToString() 
            => Seq.format();
    }
}