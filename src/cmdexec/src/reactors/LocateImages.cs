//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class LocateImages : CmdReactor<LocateImagesCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(LocateImagesCmd cmd)
            => react(Wf,cmd);

        static FS.FilePath react(IWfRuntime wf, LocateImagesCmd cmd)
        {
            ImageMaps.emit(ImageMaps.index(), cmd.Target);
            return cmd.Target;
        }
    }
}