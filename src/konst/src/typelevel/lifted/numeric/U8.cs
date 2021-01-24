//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using T = System.Byte;
    using NK = NumericKind;

    public readonly struct U8 : INumericKind<T>
    {
        public const T Max = T.MaxValue;

        public const T Min = T.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U8 src)
            => NK.U8;

        [MethodImpl(Inline)]
        public static implicit operator U8(NK<T> src)
            => default(U8);

        [MethodImpl(Inline)]
        public static implicit operator NK<T>(U8 src)
            => default(U8);
    }
}