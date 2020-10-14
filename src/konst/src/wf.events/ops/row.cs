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
        public static RowsEvent<T> rows<T>(T content, CorrelationToken ct)
            where T : ITextual
                => new RowsEvent<T>(content, ct);

        [MethodImpl(Inline)]
        public static RowsEvent<T,K> rows<T,K>(K kind, T content, CorrelationToken ct)
            where T : ITextual
             where K : unmanaged
                => new RowsEvent<T,K>(content, kind, ct);
    }
}