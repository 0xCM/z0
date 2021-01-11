//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Interfaced : IChronic<Interfaced>, ICorrelated<Interfaced>, ITextual
    {
        [MethodImpl(NotInline)]
        public static string format()
            => nameof(Interfaced);

        public Timestamp Ts
            => root.now();

        public CorrelationToken Ct
            => CorrelationToken.Default;

        public string Format()
            => format();
    }
}