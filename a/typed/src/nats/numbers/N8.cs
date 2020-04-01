//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : 
        INatPrimitive<N8>, 
        INatPrior<N8,N7>, 
        INatSeq<N8>,
        INatPow<N8,N2,N3>, 
        INatEven<N8>,
        INatPow2<N3>,
        INatDivisible<N8,N4>        
    { 
        public const ulong Value = 8;
     
        [MethodImpl(Inline)]
        public static implicit operator int(N8 src) => 8;

        [MethodImpl(Inline)]
        public static implicit operator W8(N8 src) => default(W8);

        [MethodImpl(Inline)]
        public static implicit operator N8(W8 src) => default(N8);

        public ulong NatValue => 8;

        public NatSeq Sequence
            => this;

        public string format()
            => NatValue.ToString();

        public override string ToString() 
            => format();         
    }
}