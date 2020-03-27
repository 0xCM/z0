//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;    

    public readonly struct N258 : INatSeq<N258,N2,N5,N8>
    {
        public const ulong Value = 258;

        public static N258 Rep => default;
        

        [MethodImpl(Inline)]
        public static implicit operator int(N258 src) => 258;

        public NatSeq Sequence => this;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}