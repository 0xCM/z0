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
        public static IAsmContext context(IAppContext root)
            => new AsmContext(root);

        [MethodImpl(Inline), Op]
        public static IAsmWf create(IWfShell wf)
            => new AsmWf(wf);

        [MethodImpl(Inline), Op]
        public static IAsmWf create(IWfShell wf, WfHost host)
            => new AsmWf(wf.WithHost(host));

        [MethodImpl(Inline), Op]
        public static IWfCaptureBroker broker(IWfShell wf)
            => new WfCaptureBroker(wf);

        [MethodImpl(Inline), Op]
        public static WfCaptureState state(IWfShell wf, IAsmContext asm)
            => new WfCaptureState(wf, asm);
    }
}