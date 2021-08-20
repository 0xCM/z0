//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        Outcome SdmImport()
        {
            var result = EmitSdmOpCodeDetails();
            if(result.Fail)
                return result;

            result = EmitAsmForms();
            if(result.Fail)
                return result;

            result = GenSdmOpCodeStrings();
            return result;
        }
    }
}