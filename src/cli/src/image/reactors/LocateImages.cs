//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    sealed class LocateImages : CmdReactor<LocateImagesCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(LocateImagesCmd cmd)
            => react(Wf,cmd);

        static FS.FilePath react(IWfShell wf, LocateImagesCmd cmd)
        {
            LocatedImages.emit2(LocatedImages.current(), cmd.Target);
            return cmd.Target;
        }
    }
}