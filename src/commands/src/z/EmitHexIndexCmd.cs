//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitHexIndexCmd : ICmdSpec<EmitHexIndexCmd>
    {
        public const string CmdName = "index-hex";

        public Index<PartId> Parts;
    }
}