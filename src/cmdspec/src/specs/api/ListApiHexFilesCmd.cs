//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct ListApiHexFilesCmd : ICmd<ListApiHexFilesCmd>
    {
        public const string CmdName = "list-apihex-files";

        public Index<PartId> Parts;
    }
}