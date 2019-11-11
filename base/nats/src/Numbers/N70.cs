//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N70 : INatSeq<N70>
    {
        public static N70 Rep => default;

        public static NatSeq<N7,N0> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N70 src)
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