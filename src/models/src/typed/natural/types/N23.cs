//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;    

    public readonly struct N23 : INativeNatural, INatSeq<N23,N2,N3>
    {
        public const ulong Value = 23;

        public static N23 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N23 src) => 23;
        
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}