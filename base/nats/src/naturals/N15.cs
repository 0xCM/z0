//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N15 : INatSeq<N15,N1,N5>, INatDivisible<N15,N5>
    {
        public const ulong Value = 15;

        public static N15 Rep => default;


        [MethodImpl(Inline)]
        public static implicit operator int(N15 src) => 15;
        public ulong NatValue  => Value;

        public override string ToString() 
            => Value.ToString();
    }


}