//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N86 : INatSeq<N86,N8,N6>
    {
        public const ulong Value = 86;

        public static N86 Rep => default;

        public static NatSeq<N8,N6> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N86 src) => 86;

        

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}