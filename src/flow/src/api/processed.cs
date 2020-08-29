//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow
    {
        [Op, Closures(UnsignedInts)]
        public static void processed<T>(IWfContext wf, string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => wf.Raise(WfEvents.processed(actor, kind, src, size, ct));
    }
}