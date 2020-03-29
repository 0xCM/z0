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
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : 
        INatPrimitive<N9>, 
        INatPrior<N9,N8>,
        INatSeq<N9>,
        INatOdd<N9>,
        INatDivisible<N9,N3>
    {
        public const ulong Value = 9;

        public static N9 Rep => default;
         
        [MethodImpl(Inline)]
        public static implicit operator int(N9 src) => 9;
  
        public ulong NatValue => 9;

        public NatSeq Sequence=> this;

        public override string ToString() 
            => Value.ToString();             
    }
}