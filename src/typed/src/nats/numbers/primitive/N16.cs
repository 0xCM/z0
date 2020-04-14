//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    public readonly struct N16 : 
        INativeNatural,
        ITypeNatF<N16>,
        INatSeq<N16>, 
        INatPow<N16,N2,N4>, 
        INatPow2<N4>, 
        INatDivisible<N16,N8>, 
        INatDivisible<N16,N4> 
    {
        public const ulong Value = 16;

        public ulong NatValue => Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N16 src) => 16;

        [MethodImpl(Inline)]
        public static implicit operator W16(N16 src) => default(W16);

        [MethodImpl(Inline)]
        public static implicit operator N16(W16 src) => default(N16);

        public override string ToString() 
            => Value.ToString();
    }
}