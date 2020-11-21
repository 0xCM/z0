//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct PipeApiHexFilesCmd : ICmdSpec<PipeApiHexFilesCmd>
    {
        public const string Name = "pipe-hex";

        public Index<PartId> Parts;
    }
}