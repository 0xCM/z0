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
            var sdm = Wf.IntelSdmProcessor();
            var lines = sdm.MatchHeaderPatterns(IntelSdm.VolDigit.V2);
            return true;
        }
    }
}