//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [ApiDataType]
    public readonly struct Interfaced : IChronic<Interfaced>, ICorrelated<Interfaced>, ITextual
    {
        [MethodImpl(NotInline)]
        public static CorrelationToken ct()
            => correlate(address(nameof(Interfaced)));

        [MethodImpl(NotInline)]
        public static string format()
            => nameof(Interfaced);

        public Timestamp Ts
            => now();

        public CorrelationToken Ct
            => ct();

        public string Format()
            => format();
    }
}