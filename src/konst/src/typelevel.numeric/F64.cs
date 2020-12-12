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

    public readonly struct F64 : INumericKind<double>
    {
        [MethodImpl(Inline)]
        public static implicit operator NK(F64 src)
            => NK.F64;

        [MethodImpl(Inline)]
        public static implicit operator F64(NK<float> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<double>(F64 src)
            => default;
    }
}