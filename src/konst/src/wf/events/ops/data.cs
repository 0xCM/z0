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
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static DataRow<T> data<T>(T data, CorrelationToken ct)
            where T : ITextual
                => new DataRow<T>(data, ct);

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static DataRow<T,K> data<T,K>(T data, K kind, CorrelationToken ct)
            where T : ITextual
                => new DataRow<T,K>(data, kind, ct);
    }
}
