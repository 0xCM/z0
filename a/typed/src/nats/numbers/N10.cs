//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;    

    public readonly struct N10 : INatSeq<N10,N1,N0>, INatEven<N10>, INatDivisible<N10,N5>
    {
        public const ulong Value = 10;

        [MethodImpl(Inline)]
        public static implicit operator int(N10 src) => 10;

        public ulong NatValue  => Value;

        public override string ToString() 
            => Value.ToString();
    }
}