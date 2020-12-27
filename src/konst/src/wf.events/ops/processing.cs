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
        public static ProcessingFileEvent<T> processing<T>(WfHost host, FS.FilePath src, T kind, CorrelationToken ct)
            => new ProcessingFileEvent<T>(host, kind, src, ct);
    }
}