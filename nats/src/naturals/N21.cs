//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static constant;    

    public readonly struct N21 : INatSeq<N21>
    {
        public const ulong Value = 21;

        public static N21 Rep => default;

        public static NatSeq<N2,N1> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N21 src) => 21;

        

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }


}