//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static WorkflowCommands;

    sealed class ExecWorkflow : CmdReactor<ExecWorkflowCmd,CmdResult>
    {
        protected override CmdResult Run(ExecWorkflowCmd cmd)
        {
            if(find(cmd, out var handler))
            {
                handler();
                return Cmd.ok(cmd, string.Format("Executed <{0}> workflow", cmd.WorkflowName));
            }
            return Cmd.fail(cmd, "Handler not found");
        }
    }
}