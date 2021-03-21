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
    using T = System.SByte;

    public readonly struct I8 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(I8 src)
            => NK.I8;

        [MethodImpl(Inline)]
        public static implicit operator I8(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(I8 src)
            => default;
    }
}