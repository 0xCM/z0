//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 5050
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N50 : INatSeq<N50,N5,N0>
    {
        public const ulong Value = 50;

        public static N50 Rep => default;
                

        [MethodImpl(Inline)]
        public static implicit operator int(N50 src) => 50;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}