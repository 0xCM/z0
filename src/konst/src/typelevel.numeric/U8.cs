//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using P = System.Byte;
    using NK = NumericKind;

    public readonly struct U8 : INumericKind<P>
    {
        public const P Max = P.MaxValue;

        public const P Min = P.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(U8 src)
            => NK.U8;

        [MethodImpl(Inline)]
        public static implicit operator U8(NK<P> src)
            => default(U8);

        [MethodImpl(Inline)]
        public static implicit operator NK<P>(U8 src)
            => default(U8);
    }
}