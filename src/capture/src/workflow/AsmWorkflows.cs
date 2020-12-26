//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    [ApiHost]
    public readonly struct AsmWorkflows
    {
        [MethodImpl(Inline), Op]
        public static IAsmWf create(IWfShell wf)
            => new AsmWf(wf);

        [Op]
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);

        [MethodImpl(Inline), Op]
        public static IWfCaptureBroker broker(IWfShell wf)
            => new WfCaptureBroker(wf);
    }
}