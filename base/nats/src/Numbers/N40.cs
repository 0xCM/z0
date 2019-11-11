//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N40 : INatSeq<N40>
    {
        public static N40 Rep => default;

        public static NatSeq<N4,N0> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N40 src)
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