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

    public readonly struct I32 : INumericKind<int>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(I32 src) => NK.I32; 

        [MethodImpl(Inline)]
        public static implicit operator I32(NK<int> src) => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<int>(I32 src) => default;
    }
}