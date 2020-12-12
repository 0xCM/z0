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
    using P = System.Single;

    public readonly struct F32 : INumericKind<float>
    {
        public const P Max = P.MaxValue;

        public const P Min = P.MinValue;

        [MethodImpl(Inline)]
        public static implicit operator NK(F32 src)
            => NK.F32;

        [MethodImpl(Inline)]
        public static implicit operator F32(NK<float> src)
            => default;

        [MethodImpl(Inline)]
        public static implicit operator NK<float>(F32 src)
            => default;
    }
}