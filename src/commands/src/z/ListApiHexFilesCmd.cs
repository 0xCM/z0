//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct ListApiHexFilesCmd : ICmdSpec<ListApiHexFilesCmd>
    {
        public const string Name = "list-hex";

        public Index<PartId> Parts;
    }
}