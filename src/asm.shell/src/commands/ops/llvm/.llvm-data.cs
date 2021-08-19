//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.llvm;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-data")]
        Outcome EmitLlvmTables(CmdArgs args)
        {
            var result = Outcome.Success;
            EmitSymKinds(Symbols.index<MC.Register>(), TableWs().LlvmTable(LlvmTableNames.regnames));
            EmitLlvmOpCodes();
            EmitLlvmMnemonics();
            ImportLists(LlvmDatasetNames.TblgenLists, "llvm");
            GenLlvmStringTables();
            return result;
        }
    }
}