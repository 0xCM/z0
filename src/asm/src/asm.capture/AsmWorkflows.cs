//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Z0.Asm;

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