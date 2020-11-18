//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    [ApiHost]
    public sealed class EmitResourceData : CmdHost<EmitResourceData, EmitResourceDataCmd>
    {
        protected override CmdResult Execute(IWfShell wf, in EmitResourceDataCmd spec)
            => run(wf, spec);

        public static CmdResult run(IWfShell wf, EmitResourceDataCmd spec)
            => Workers.exec(wf, spec);
    }

    sealed class EmitResourceDataReactor : CmdReactor<EmitResourceDataReactor, EmitResourceDataCmd, CmdResult>
    {
        protected override CmdResult Run(EmitResourceDataCmd cmd)
            => Workers.exec(Wf, cmd);
    }
}