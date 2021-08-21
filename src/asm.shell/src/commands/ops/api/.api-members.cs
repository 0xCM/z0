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
        [CmdOp(".api-members")]
        Outcome ApiMembers(CmdArgs args)
        {
            var result = Outcome.Success;
            var entries = ApiCatalogs.LoadApiCatalog(ApiArchive.ApiCatalog());
            iter(entries, e => Write(e.OpUri));
            return result;
        }
    }
}