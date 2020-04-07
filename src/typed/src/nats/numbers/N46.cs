//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4649
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N46 : INatSeq<N46>
    {
        public const ulong Value = 46;

        public static N46 Rep => default;
        
        public static NatSeq<N4,N6> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N46 src) => 46;
    
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}