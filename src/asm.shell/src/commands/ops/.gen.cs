//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".gen")]
        Outcome Generate(CmdArgs args)
        {
            var result = Outcome.Success;
            Wf.AsmEtl().EmitAsmTokens();
            result = EmitApiLiterals();
            if(result.Fail)
                return result;

            result = EmitAsmForms();
            if(result.Fail)
                return result;

            result = GenModRmBits();
            if(result.Fail)
                return result;

            result = GenSibBits();
            if(result.Fail)
                return result;

            result = SdmImport();
            if(result.Fail)
                return result;


            return result;
        }
    }
}