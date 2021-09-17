//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".api-catalog")]
        Outcome ApiCatalog(CmdArgs args)
        {
            var result = Outcome.Success;
            var catalog = State.ApiCatalog(ApiRuntimeLoader.catalog);
            var parts = catalog.PartIdentities;
            var desc = string.Format("Parts:[{0}]", parts.Map(p => p.Format()).Delimit());
            Write(desc);
            return result;
        }
    }
}