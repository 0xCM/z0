//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;    

    public readonly struct N32 : INatSeq<N32>,  INatPow<N32,N2,N5>, INatPow2<N5>, 
        INatDivisible<N32,N8>, INatDivisible<N32,N4>, INatDivisible<N32,N16>
    {
        public const ulong Value = 32;

        public static N32 Rep => default;

        public static NatSeq<N3,N2> Seq => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N32 src) => 32;

        [MethodImpl(Inline)]
        public static implicit operator W32(N32 src) => default(W32);

        [MethodImpl(Inline)]
        public static implicit operator N32(W32 src) => default(N32);

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }
}