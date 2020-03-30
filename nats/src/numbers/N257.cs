//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;    

    public readonly struct N257 : INatSeq<N257,N2,N5,N7>
    {
        public const ulong Value = 257;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N257 src) => 257;

        public NatSeq Sequence => this;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}