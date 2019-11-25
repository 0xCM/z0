//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N80 : INatSeq<N80,N8,N0>
    {
        public const ulong Value = 80;

        public static N80 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N80 src) => 80;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}