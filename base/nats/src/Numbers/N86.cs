//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N86 : INatSeq<N86>
    {
        public static N86 Rep => default;

        public static NatSeq<N8,N6> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N86 src)
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