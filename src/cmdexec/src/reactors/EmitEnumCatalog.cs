//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class EmitEnumCatalog : CmdReactor<EmitEnumCatalogCmd>
    {
        protected override CmdResult Run(EmitEnumCatalogCmd cmd)
        {
            EnumCatalogs.emit(Wf, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}