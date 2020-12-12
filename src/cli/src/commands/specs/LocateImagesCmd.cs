//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct LocateImagesCmd : ICmdSpec<LocateImagesCmd,FS.FilePath>
    {
        public const string CmdName = "locate-images";

        public int ProcessId;

        public FS.FilePath Target;
    }
}