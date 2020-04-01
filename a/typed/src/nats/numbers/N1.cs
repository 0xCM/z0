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
        INatPrimitive<N1>,         
        INatPrior<N1,N0>, 
        INatSeq<N1>, 
        INatPow<N1,N1,N0>, 
        INatOdd<N1>, 
        INatPow2<N0>         
    {
        public const ulong Value = 1;


        [MethodImpl(Inline)]
        public static implicit operator int(N1 src) => 1;

        [MethodImpl(Inline)]
        public static implicit operator W1(N1 src) => default(W1);

        [MethodImpl(Inline)]
        public static implicit operator N1(W1 src) => default(N1);

        public NatSeq Sequence => this;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }


}