//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct PipeImageContentCmd : ICmdSpec<PipeImageContentCmd>
    {
        public const string CmdName ="pipe-image-content";

        public FS.FilePath Source;
    }
}