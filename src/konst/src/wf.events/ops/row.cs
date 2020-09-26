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
        public static RowCreated<T> row<T>(T content, CorrelationToken ct)
            where T : ITextual
                => new RowCreated<T>(content, ct);

        [MethodImpl(Inline)]
        public static RowCreated<T,K> row<T,K>(K kind, T content, CorrelationToken ct)
            where T : ITextual
             where K : unmanaged
                => new RowCreated<T,K>(content, kind, ct);
    }
}