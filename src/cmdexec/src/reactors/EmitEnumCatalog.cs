//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    sealed class EmitEnumCatalog : CmdReactor<EmitEnumCatalogCmd>
    {
        protected override CmdResult Run(EmitEnumCatalogCmd cmd)
        {
            var services = Wf.ApiServices();
            services.EmitSymbolicLiterals(Wf.Components, cmd.Target);
            return Cmd.ok(cmd);
        }
    }
}