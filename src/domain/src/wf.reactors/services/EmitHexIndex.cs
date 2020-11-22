//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitHexIndex : CmdReactor<EmitHexIndexCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitHexIndexCmd cmd)
            => Reactions.react(Wf,cmd);
    }
}