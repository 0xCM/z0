//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using NK = NumericKind;

    public readonly struct I64 : INumericKind<long>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(I64 src) => NK.I64;

        [MethodImpl(Inline)]
        public static implicit operator I64(NK<long> src) => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<long>(I64 src) => default;
    }

}