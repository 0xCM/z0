//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;    

    public readonly struct N22 : INatSeq<N22>, INatEven<N22>
    {
        public const ulong Value = 22;

        public static N22 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N22 src) => 22;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}