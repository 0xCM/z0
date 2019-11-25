//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N61 : INatSeq<N61,N6,N1>
    {
        public const ulong Value = 61;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N61 src) => 61;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}