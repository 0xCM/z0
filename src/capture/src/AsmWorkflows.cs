//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Part;

    [ApiHost]
    public readonly struct AsmWorkflows
    {
        [Op]
        public static IAsmWf create(IWfShell wf)
            => new AsmWf(wf, context(wf));

        [Op]
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);
    }
}