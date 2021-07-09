//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;

    using SQ = SymbolicQuery;

    partial class AsmCmdService
    {
        Outcome ImportXedTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var path = Workspace.DataSource(xed) + FS.file("xed-tables", FS.Txt);


            return result;
        }
    }
}