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

    public readonly struct U64 : INumericKind<ulong>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(U64 src) => NK.U64;

        [MethodImpl(Inline)]
        public static implicit operator U64(NK<ulong> src) => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<ulong>(U64 src) => default;
    }
}