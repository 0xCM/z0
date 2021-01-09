//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using P = System.UInt64;
    using NK = NumericKind;

    public readonly struct U64 : INumericKind<P>
    {
        public const P Max = P.MaxValue;

        public const P Min = P.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U64 src)
            => NK.U64;

        [MethodImpl(Inline)]
        public static implicit operator U64(NK<P> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<P>(U64 src)
            => default;
    }
}