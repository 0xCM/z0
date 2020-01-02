//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;    

    public readonly struct N37 : INatSeq<N37>
    {
        public const ulong Value = 37;

        public static N37 Rep => default;


        [MethodImpl(Inline)]
        public static implicit operator int(N37 src) => 37;
        
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}