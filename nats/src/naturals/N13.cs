//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N13 : INatSeq<N13>, INatPrime<N11>
    {
        public const ulong Value = 13;

        public static N13 Rep => default;


        [MethodImpl(Inline)]
        public static implicit operator int(N13 src) => 13;

        public ulong NatValue  => Value;

        public override string ToString() 
            => Value.ToString();
    }
}