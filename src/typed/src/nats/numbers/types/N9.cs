//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : 
        INat9<N9>,
        INativeNatural,
        INatPrimitive<N9>, 
        INatPrior<N9,N8>,
        INatSeq<N9>,
        INatOdd<N9>,
        INatDivisible<N9,N3>
    {
        public const ulong Value = 9;

        public const string Text = "9";

        public ulong NatValue 
            => Value;

        public string NatText 
            => Text;

        [MethodImpl(Inline)]
        public static implicit operator int(N9 src) 
            => (int)Value;
  
        [MethodImpl(Inline)]
        public static implicit operator byte(N9 src) 
            => (byte)Value;

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Text;
    }
}