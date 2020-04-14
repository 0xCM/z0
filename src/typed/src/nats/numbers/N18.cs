//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;    

    public readonly struct N18 : INativeNatural, INatSeq<N18>, INatEven<N18>
    {
        public const ulong Value = 18;

        public static N18 Rep => default;

        public static NatSeq<N1,N8> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N18 src) => 18;
    
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}