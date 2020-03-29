//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : 
        INatPrimitive<N5>, 
        INatPrior<N5,N4>, 
        INatSeq<N5>,
        INatPrime<N5>, 
        INatOdd<N5>
    {
        public const ulong Value = 5;
 
        public static N5 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N5 src) => 5;

        public ulong NatValue => Value;

        public NatSeq Sequence => this;

        public override string ToString() 
            => Value.ToString();
    }
}