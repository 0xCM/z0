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
        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static WfStepRan<T> ran<T>(WfStepId step, T content, CorrelationToken ct)
            => new WfStepRan<T>(step, content, ct);

        [MethodImpl(Inline)]
        public static WfStepRan<T> ran<S,T>(S step, T content, CorrelationToken ct)
            where S : struct, IWfStep<S>
                => new WfStepRan<T>(step.Id, content, ct);
    }
}