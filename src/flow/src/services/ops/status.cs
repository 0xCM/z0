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
        [MethodImpl(Inline)]
        public static WfStatus<T> status<T>(string actor, T body, CorrelationToken ct)
            => new WfStatus<T>(actor, body, ct);

        [MethodImpl(Inline)]
        public static void status<T>(IWfContext wf, string actor, T body, CorrelationToken ct)
            => wf.Raise(status(actor, body, ct));
    }
}