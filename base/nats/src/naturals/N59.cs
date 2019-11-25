//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N59 : INatSeq<N59,N5,N9>
    {
        public const ulong Value = 59;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N59 src) => 59;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}