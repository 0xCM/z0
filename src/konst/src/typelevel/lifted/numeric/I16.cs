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
    using T = System.Int16;

    public readonly struct I16 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(I16 src)
            => NK.I16;

        [MethodImpl(Inline)]
        public static implicit operator I16(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(I16 src)
            => default;
    }
}