//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N63 : INatSeq<N63,N6,N3>, INatPrior<N63,N64>
    {
        public const ulong Value = (1ul << 6) - 1;     

        public static N63 Rep => default;
        
        
        [MethodImpl(Inline)]
        public static implicit operator int(N63 src) => 63;
        
        public ulong NatValue => Value;
        
        public override string ToString() 
            => Value.ToString();
    }
}