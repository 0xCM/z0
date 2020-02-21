//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N255 : INatSeq<N255>, INatPrior<N255,N256>
    {
        public const ulong Value = (1ul << 8) - 1;

        public static N255 Rep => default;

        public static NatSeq<N2,N5,N5> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N255 src) => 255;
        
        public NatSeq Sequence => this;

        public ulong NatValue => Value;


        public override string ToString() 
            => Value.ToString();
        
    }

}