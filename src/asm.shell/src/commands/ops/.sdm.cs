//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".sdm")]
        Outcome ProcessSdm(CmdArgs args)
        {
            var sdm = Wf.IntelSdm();
            var result = sdm.Process();
            //var lines = sdm.MatchHeaderPatterns(SdmModels.VolDigit.V2);
            return result;
        }
    }
}