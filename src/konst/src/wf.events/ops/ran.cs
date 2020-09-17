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
        public static WfStepRan<T> ran<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRan<T>(step, content, ct);

        [MethodImpl(Inline)]
        public static WfStepRan<T> ran<H,T>(H host, T content, CorrelationToken ct)
            where H : IWfHost<H>, new()
                => new WfStepRan<T>(host.Id, content, ct);

        [MethodImpl(Inline), Op]
        public static ToolRan ran(WfToolId tool, CorrelationToken ct)
            => new ToolRan(tool, ct);
    }
}