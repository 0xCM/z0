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
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : 
        INativeNatural,
        INatPrimitive<N6>, 
        INatPrior<N6,N5>, 
        INatSeq<N6>, 
        INatEven<N6>, 
        INatDivisible<N6,N3>
    {
        public const ulong Value = 6;

        public const string Text = "6";

        [MethodImpl(Inline)]
        public static implicit operator int(N6 src) => 6;

        public ulong NatValue => 6;

        public override string ToString() => Value.ToString(); 
     }
}