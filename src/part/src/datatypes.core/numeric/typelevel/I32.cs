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
    using T = System.Int32;

    public readonly struct I32 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;


        [MethodImpl(Inline)]
        public static implicit operator NK(I32 src)
            => NK.I32;

        [MethodImpl(Inline)]
        public static implicit operator I32(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(I32 src)
            => default;
    }
}