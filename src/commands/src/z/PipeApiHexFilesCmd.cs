//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct PipeApiHexFilesCmd : ICmdSpec<PipeApiHexFilesCmd>
    {
        public const string CmdName = "pipe-api-hex";

        public Index<PartId> Parts;
    }
}