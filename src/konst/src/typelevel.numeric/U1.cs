//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using P = bit;
    using NK = NumericKind;

    public readonly struct U1 : INumericKind<P>
    {
        public const bool MinLiteral = false;

        public const bool MaxLiteral = true;

        [MethodImpl(Inline)]
        public static implicit operator NK(U1 src)
            => NK.U8;

        [MethodImpl(Inline)]
        public static implicit operator U1(NK<P> src)
            => default(U1);
    }
}