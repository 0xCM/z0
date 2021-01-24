//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using T = System.UInt16;
    using NK = NumericKind;

    public readonly struct U16 : INumericKind<T>
    {
        public const T MaxLiteral = T.MaxValue;

        public const T MinLiteral = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U16 src)
            => NK.U16;

        [MethodImpl(Inline)]
        public static implicit operator U16(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(U16 src)
            => default;
    }
}