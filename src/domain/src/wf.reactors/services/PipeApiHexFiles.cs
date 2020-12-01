//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class PipeApiHexFiles : CmdReactor<ListApiHexFilesCmd,CmdResult>
    {
        protected override CmdResult Run(ListApiHexFilesCmd cmd)
            => Reactions.react(Wf,cmd);
    }
}
