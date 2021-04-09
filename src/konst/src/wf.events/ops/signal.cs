//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        internal static EventSignal signal(IWfRuntime wf)
            => EventSignal.create(wf);
    }
}