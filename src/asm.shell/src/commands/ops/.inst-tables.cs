//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".inst-tables", "Loads the instruction table files into the context")]
        Outcome InstTables(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = DataSources.Dataset(AsmTableScopes.SdmInstructions).Files(FS.Csv);
            Files(src);
            return result;
        }
    }
}