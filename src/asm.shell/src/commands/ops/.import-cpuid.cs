//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-cpuid")]
        Outcome ImportCpuid(CmdArgs args)
        {
            return AsmTables.ImportCpuIdSources();
        }
    }
}