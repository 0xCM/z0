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
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : 
        INativeNatural,
        INatPrimitive<N2>,
        INatSeq<N2>, 
        INatPrime<N2>, 
        INatPow<N2,N2,N1>, 
        INatEven<N2>, 
        INatPrior<N2,N1>, 
        INatPow2<N1>        
    {
        public const ulong Value = 2;

        public const string Text = "2";

        public ulong NatValue => Value;

        public string NatText => Text;

        [MethodImpl(Inline)]
        public static implicit operator byte(N2 src) => (byte)Value;

        [MethodImpl(Inline)]
        public static implicit operator int(N2 src) => (int)Value;
                
        public override string ToString() => Text;
    }
}