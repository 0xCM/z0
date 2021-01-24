//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using NK = NumericKind;
    using T = System.Int64;

    public readonly struct I64 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(I64 src)
            => NK.I64;

        [MethodImpl(Inline)]
        public static implicit operator I64(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(I64 src)
            => default;
    }
}