//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N12 : INatSeq<N12>, INatEven<N12>
    {
        public const ulong Value = 12;

        [MethodImpl(Inline)]
        public static implicit operator int(N12 src) => 12;
        
        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}