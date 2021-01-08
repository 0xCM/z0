//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitEnumCatalogCmd : ICmdSpec<EmitEnumCatalogCmd>
    {
        public const string CmdName = "emit-enum-catalog";
    }
}