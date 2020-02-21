//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N87 : INatSeq<N87,N8,N7>
    {
        public const ulong Value = 87;

        public static N87 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N87 src) => 87;
        
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}