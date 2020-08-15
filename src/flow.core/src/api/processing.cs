//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfCore    
    {
        [Op, Closures(UnsignedInts)]
        public static WfProcessingFile<T> processing<T>(string actor, T kind, FilePath src, CorrelationToken ct)
            => new WfProcessingFile<T>(actor, kind, src, ct);

        [Op, Closures(UnsignedInts)]
        public static void processing<T>(IWfContext wf, string actor, T kind, FilePath src, CorrelationToken ct)
            => wf.Raise(processing(actor,kind,src,ct));
    }
}