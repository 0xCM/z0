//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using P = System.UInt32;
    using NK = NumericKind;

    public readonly struct U32 : INumericKind<P>
    {
        public const P MaxLiteral = P.MaxValue;

        public const P MinLiteral = P.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U32 src)
            => NK.U32;

        [MethodImpl(Inline)]
        public static implicit operator U32(NK<P> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<P>(U32 src)
            => default;
    }

}