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
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : 
        INativeNatural,
        INatPrimitive<N7>, 
        INatPrior<N7,N6>,
        INatSeq<N7>,
        INatPrime<N7>, 
        INatOdd<N7> 
    {
        public const ulong Value = 7;

        public const string Text = "7";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N7 src) => (int)Value;

        public override string ToString() => Text;
    }
}