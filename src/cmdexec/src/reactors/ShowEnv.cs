//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class ShowEnv : CmdReactor<ShowEnvCmd>
    {
        protected override CmdResult Run(ShowEnvCmd cmd)
        {
            Wf.Row(Wf.Env.Format());
            return Cmd.ok(cmd);
        }
    }
}