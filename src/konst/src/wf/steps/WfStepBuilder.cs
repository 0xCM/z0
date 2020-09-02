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
        public static WfRunSpec<WfConfig,S,T> specify<S,T>(WfConfig config, S source, T target)
            => new WfRunSpec<WfConfig,S,T>(config,source, target);

        [MethodImpl(Inline)]
        public static WfRunSpec<WfConfig,WfStepId,T> specify<T>(WfConfig config, WfStepId step, T target)
            => new WfRunSpec<WfConfig,WfStepId,T>(config,step, target);
    }
}