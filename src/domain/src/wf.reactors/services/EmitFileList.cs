//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class EmitFileList : CmdReactor<EmitFileListCmd,CmdResult>
    {
        public static CmdResult run(IWfShell wf, EmitFileListCmd cmd)
            => Reactions.react(wf,cmd);

        protected override CmdResult Run(EmitFileListCmd cmd)
            => run(Wf,cmd);
    }
}