//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;    

    public readonly struct N20 : INatSeq<N20>, INatEven<N20>
    {
        public const ulong Value = 20;

        public static N20 Rep => default;
        
        [MethodImpl(Inline)]
        public static implicit operator int(N20 src) => 20;
        
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}