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
    using T = System.Double;

    public readonly struct F64 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(F64 src)
            => NK.F64;

        [MethodImpl(Inline)]
        public static implicit operator F64(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(F64 src)
            => default;
    }
}