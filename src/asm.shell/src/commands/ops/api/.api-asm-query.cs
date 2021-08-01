//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".api-asm-query")]
        Outcome QueryApiAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            result = Enums.parse<AsmMnemonicCode>(arg(args,0).Value, out var code);
            if(result.Fail)
                return result;

            var dst = OutWs().Queries() + FS.file(string.Format("qpi.asm.{0}", code), FS.Csv);
            var count = AsmTables.RenderRows(code, dst);
            RecordsEmitted(count,dst);
            return result;
        }
    }
}