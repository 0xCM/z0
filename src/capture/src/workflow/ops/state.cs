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

    partial struct AsmWfBuilder
    {
        [MethodImpl(Inline), Op]
        public static WfCaptureState state(IWfShell wf, IAsmContext asm, WfConfig config)
            => new WfCaptureState(wf, asm, config, wf.Ct);
    }
}