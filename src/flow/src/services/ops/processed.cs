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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfProcessedFile<T> processed<T>(string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => new WfProcessedFile<T>(actor, kind, src, size, ct);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void processed<T>(IWfContext wf, string actor, T kind, FilePath src, uint size, CorrelationToken ct)
            => wf.Raise(processed(actor, kind, src, size, ct));
    }
}