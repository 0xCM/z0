//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;    

    public readonly struct N13 : INatSeq<N13>, INatPrime<N11>
    {
        public const ulong Value = 13;

        [MethodImpl(Inline)]
        public static implicit operator int(N13 src) => 13;

        public ulong NatValue  => Value;

        public override string ToString() 
            => Value.ToString();
    }
}