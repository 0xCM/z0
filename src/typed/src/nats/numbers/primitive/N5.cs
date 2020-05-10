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
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : 
        INativeNatural,
        INatPrimitive<N5>, 
        INatPrior<N5,N4>, 
        INatSeq<N5>,
        INatPrime<N5>, 
        INatOdd<N5>
    {
        public const ulong Value = 5;

        public const string Text = "5";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N5 src) => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N5 src) => (int)Value;

        public override string ToString() => Text;
    }
}