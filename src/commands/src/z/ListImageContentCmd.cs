//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct ListImageContentCmd : ICmdSpec<ListImageContentCmd>
    {
        public const string CmdName ="list-image-content";

        public FS.FilePath Source;
    }
}