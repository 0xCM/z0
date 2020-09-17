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
        public static DataRow<T> data<T>(T content, CorrelationToken ct)
            where T : ITextual
                => new DataRow<T>(content, ct);

        [MethodImpl(Inline)]
        public static DataRow<T,K> data<T,K>(K kind, T content, CorrelationToken ct)
            where T : ITextual
                => new DataRow<T,K>(content, kind, ct);
    }
}
