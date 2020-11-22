//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class LocateImages : CmdReactor<LocateImagesCmd, FS.FilePath>
    {
        protected override FS.FilePath Run(LocateImagesCmd cmd)
            => Reactions.react(Wf,cmd);
    }
}