//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;

    using static Part;

    partial class XWf
    {
        public static EventSignal Signal<T>(this IWfRuntime wf)
            => wf.EventSink.Signal<T>();

        public static EventSignal Signal(this IWfRuntime wf, WfHost source)
            => wf.EventSink.Signal(source);

    }
}