//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(Name)]
    public struct EmitHexIndexCmd : ICmdSpec<EmitHexIndexCmd>
    {
        public const string Name = "index-hex";

        public Index<PartId> Parts;
    }
}