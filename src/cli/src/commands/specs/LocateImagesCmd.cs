//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct LocateImagesCmd : ICmdSpec<LocateImagesCmd,FS.FilePath>
    {
        public const string Name = "locate-images";

        [CmdParam("procid")]
        public int ProcessId;

        [CmdParam("out")]
        public FS.FilePath Target;
    }
}