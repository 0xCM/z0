//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N11 : INatSeq<N11>, INatPrime<N11>
    {
        public const ulong Value = 11;

        public static N11 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N11 src) => 11;
            
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
     }
}