//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using P = System.Byte;
    using NK = NumericKind;

    public readonly struct U64 : INumericKind<P>
    {
        public const P MaxLiteral = P.MaxValue;

        public const P MinLiteral = P.MinValue;

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