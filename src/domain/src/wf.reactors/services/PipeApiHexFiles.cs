//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class PipeApiHexFiles : CmdReactor<PipeApiHexFilesCmd,CmdResult>
    {
        protected override CmdResult Run(PipeApiHexFilesCmd cmd)
            => Reactions.react(Wf,cmd);
    }
}
