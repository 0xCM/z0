//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitRuntimeIndex : CmdReactor<EmitRuntimeIndexCmd,CmdResult>
    {
        protected override CmdResult Run(EmitRuntimeIndexCmd cmd)
            => react(Wf, cmd);

        [Op]
        public static CmdResult react(IWfShell wf, EmitRuntimeIndexCmd cmd)
        {
            var outcome = ApiRuntime.EmitRuntimeIndex(wf);
            outcome.OnSuccess(path => wf.Status(Msg.EmittedRuntimeIndex.Format(path))).OnFailure(msg => wf.Error(msg));
            return outcome ?  Cmd.ok(cmd) : Cmd.fail(cmd, outcome.Message);
        }
    }
}