//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using T = System.UInt64;
    using NK = NumericKind;

    public readonly struct U64 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U64 src)
            => NK.U64;

        [MethodImpl(Inline)]
        public static implicit operator U64(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(U64 src)
            => default;
    }
}