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
        public static WfStatus<T> status<T>(string actor, T body, CorrelationToken ct)
            => new WfStatus<T>(actor, body, ct);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static WfStatus<T> status<T>(PartId actor, T body, CorrelationToken ct)
            => new WfStatus<T>(actor.Format(), body, ct);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void status<T>(IWfContext wf, string actor, T body, CorrelationToken ct)
            => wf.Raise(status(actor, body, ct));
    }
}