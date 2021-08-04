//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".cpuid-rows")]
        Outcome LoadCpuidRows(CmdArgs args)
        {
            var result = Outcome.Success;
            var rows = AsmTables.LoadCpuIdImports();
            Write(rows, CpuIdRow.RenderWidths);
            return result;
        }
    }
}