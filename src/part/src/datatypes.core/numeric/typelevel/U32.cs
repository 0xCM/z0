//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using T = System.UInt32;
    using NK = NumericKind;

    public readonly struct U32 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U32 src)
            => NK.U32;

        [MethodImpl(Inline)]
        public static implicit operator U32(NK<T> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(U32 src)
            => default;
    }
}