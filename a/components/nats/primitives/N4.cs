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
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : 
        INatPrimitive<N4>, 
        INatPrior<N4,N3>, 
        INatSeq<N4>, 
        INatPow<N4,N2,N2>, 
        INatEven<N4>,
        INatPow2<N2>        
    {
        public const ulong Value = 4;

        public static N4 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N4 src) => 4;

        public ulong NatValue  => Value;

        public NatSeq Sequence
            => this;

        public string format()
            => NatValue.ToString();

        public override string ToString() 
            => format();
    }
}