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
        public static void processing<T>(IWfContext wf, string actor, T kind, FilePath src, CorrelationToken ct)
            => wf.Raise(WfCore.processing(actor,kind,src,ct));
    }
}