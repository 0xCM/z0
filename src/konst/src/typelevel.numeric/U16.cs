//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using P = System.UInt16;
    using NK = NumericKind;

    public readonly struct U16 : INumericKind<P>
    {
        public const P MaxLiteral = P.MaxValue;

        public const P MinLiteral = P.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U16 src)
            => NK.U16;

        [MethodImpl(Inline)]
        public static implicit operator U16(NK<P> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<P>(U16 src)
            => default;
    }
}