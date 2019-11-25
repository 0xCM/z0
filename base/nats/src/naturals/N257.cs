//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N257 : INatSeq<N257,N2,N5,N7>
    {
        public const ulong Value = 257;

        public static N257 Rep => default;
        

        [MethodImpl(Inline)]
        public static implicit operator int(N257 src) => 257;

        public NatSeq Sequence => this;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}