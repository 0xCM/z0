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
    using T = System.Single;

    public readonly struct F32 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(F32 src)
            => NK.F32;

        [MethodImpl(Inline)]
        public static implicit operator F32(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(F32 src)
            => default;
    }
}