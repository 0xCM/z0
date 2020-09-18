//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    partial struct WfEvents
    {
        [MethodImpl(Inline)]
        public static WfDataFlowed<H,S,T,R> flowed<H,S,T,R>(H host, DataFlow<S,T,R> df, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new WfDataFlowed<H,S,T,R>(host,df,ct);
    }
}