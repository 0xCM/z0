//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfStepBuilder
    {
        [MethodImpl(Inline)]
        public static WfRunSpec<C,S,T> specify<C,S,T>(C config, S source, T target)
            => new WfRunSpec<C,S,T>(config,source, target);

        [MethodImpl(Inline)]
        public static WfRunSpec<WfInit,S,T> specify<S,T>(WfInit config, S source, T target)
            => new WfRunSpec<WfInit,S,T>(config,source, target);

        [MethodImpl(Inline)]
        public static WfRunSpec<WfInit,WfStepId,T> specify<T>(WfInit config, WfStepId step, T target)
            => new WfRunSpec<WfInit,WfStepId,T>(config,step, target);
    }
}