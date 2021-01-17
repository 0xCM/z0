//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static z;

    sealed class RunPart : CmdReactor<RunPartCmd>
    {
        protected override CmdResult Run(RunPartCmd cmd)
        {
            Wf.Warn(string.Format("{0} unimplemented", cmd.Format()));
            return Cmd.ok(cmd);
        }
    }
}