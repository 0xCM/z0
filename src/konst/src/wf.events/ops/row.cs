//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static RowCreatedEvent<T> row<T>(T content, CorrelationToken ct)
            where T : ITextual
                => new RowCreatedEvent<T>(content, ct);

        [MethodImpl(Inline)]
        public static RowCreatedEvent<T,K> row<T,K>(K kind, T content, CorrelationToken ct)
            where T : ITextual
             where K : unmanaged
                => new RowCreatedEvent<T,K>(content, kind, ct);
    }
}