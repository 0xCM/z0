//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sdm-import")]
        Outcome SdmImport(CmdArgs args)
        {
            var result = SdmOpCodeDetailEmit();
            if(result.Fail)
                return result;

            result = AsmFormsEmit();
            return result;
        }
    }
}