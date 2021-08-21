//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".api-catalog")]
        Outcome ApiCatalog(CmdArgs args)
        {
            var result = Outcome.Success;
            var catalog = ApiRuntimeLoader.catalog();
            var parts = catalog.PartIdentities;
            iter(parts, part => Write(part.Format()));
            return result;
        }
    }
}