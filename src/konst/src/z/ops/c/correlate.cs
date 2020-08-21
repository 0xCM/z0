//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static CorrelationToken correlate(PartId src)
            => new CorrelationToken((ulong)src);

        [MethodImpl(Inline), Op]
        public static CorrelationToken correlate(ulong src)
            => new CorrelationToken(src);

        [MethodImpl(Inline), Op]
        public static CorrelationToken correlate()
            => new CorrelationToken((ulong)now().Ticks);

        [MethodImpl(Inline), Op]
        public static CorrelationToken correlate(CorrelationToken? ct)
            => ct ?? correlate(0ul);
    }
}