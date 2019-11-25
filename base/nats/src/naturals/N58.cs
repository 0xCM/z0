//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N58 : INatSeq<N58,N5,N8>
    {
        public const ulong Value = 58;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N58 src) => 58;
        
        public ulong NatValue => Value;


        public override string ToString() 
            => Value.ToString();
    }
}