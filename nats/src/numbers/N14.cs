//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N14 : INatSeq<N14,N1,N4>, INatEven<N14>
    {
        public const ulong Value = 14;
        
        public static N14 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N14 src) => 14;
        
        public ulong NatValue => Value;


        public override string ToString() 
            => Value.ToString();
    }

}