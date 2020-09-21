//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using NK = NumericKind;

    public readonly struct U16 : INumericKind<ushort>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(U16 src)
            => NK.U16;

        [MethodImpl(Inline)]
        public static implicit operator U16(NK<ushort> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<ushort>(U16 src)
            => default;
    }

}