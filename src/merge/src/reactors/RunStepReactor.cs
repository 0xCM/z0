//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class RunStepReactor : CmdReactor<RunStepCmd,CmdResult>
    {
        protected override CmdResult Run(RunStepCmd cmd)
        {
            switch(cmd.StepName)
            {
                case XedEtlWfHost.StepName:
                    XedEtlWfHost.create().Run(Wf);
                    return Cmd.ok(cmd);

            }

            return Cmd.fail(cmd, "Handler not found");
        }
    }
}