//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4749
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N47 : INatSeq<N47>
    {
        public const ulong Value = 47;

        public static N47 Rep => default;
        
        public static NatSeq<N4,N7> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N47 src) => 47;

        

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}