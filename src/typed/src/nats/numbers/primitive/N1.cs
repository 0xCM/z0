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
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : 
        INativeNatural,
        INatPrimitive<N1>,         
        INatPrior<N1,N0>, 
        INatSeq<N1>, 
        INatPow<N1,N1,N0>, 
        INatOdd<N1>, 
        INatPow2<N0>
    {
        public const ulong Value = 1;

        public const string Text = "1";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N1 src) => (int)Value;

        [MethodImpl(Inline)]
        public static implicit operator W1(N1 src) => default(W1);

        [MethodImpl(Inline)]
        public static implicit operator N1(W1 src) => default(N1);

        public override string ToString() => Text;
    }
}