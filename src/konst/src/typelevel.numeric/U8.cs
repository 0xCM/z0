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

    public readonly struct U8 : INumericKind<byte>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(U8 src)
            => NK.U8;

        [MethodImpl(Inline)]
        public static implicit operator U8(NK<byte> src)
            => default(U8);

        [MethodImpl(Inline)]
        public static implicit operator NK<byte>(U8 src)
            => default(U8);
    }
}