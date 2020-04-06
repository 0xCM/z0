//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;    

    public readonly struct N17 : 
        ITypeNatF<N17>, 
        INatSeq<N17,N1,N7>, 
        INatPrime<N11>
    {
        public const ulong Value = 17;

        [MethodImpl(Inline)]
        public static implicit operator int(N17 src) => 17;
        
        public ulong NatValue => Value;

        public override string ToString() => Value.ToString();
    }
}