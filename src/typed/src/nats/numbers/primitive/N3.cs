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
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : 
        INatPrimitive<N3>, 
        INatPrior<N3,N2>, 
        INatSeq<N3>,
        INatPrime<N3>, 
        INatOdd<N3>
    {
        public const ulong Value = 3;

        public const string Text = "3";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N3 src) => (int)Value;
    
        public override string ToString() => Text;
    }
}