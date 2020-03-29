//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;    

    public readonly struct N19 : INatSeq<N19>
    {
        public const ulong Value = 19;


        [MethodImpl(Inline)]
        public static implicit operator int(N19 src) => 19;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}