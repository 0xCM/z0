//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N70 : INatSeq<N70>
    {
        public const ulong Value = 70;

        public static N70 Rep => default;

        public static NatSeq<N7,N0> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N70 src) => 70;

        

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}