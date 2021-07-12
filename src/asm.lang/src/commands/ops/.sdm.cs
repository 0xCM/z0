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
            //Wf.IntelSdmProcessor().Run();
            var sdm = Wf.IntelSdmProcessor();
            var outcome = Outcome.Success;

            sdm.ClearTargets();

            outcome = sdm.EmitCharMaps();
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitLinedSdm(1);
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitLinedSdm(2);
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitLinedSdm(3);
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitLinedSdm(4);
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitLinedSdm();
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitSdmSplits();
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitCombinedToc();
            if(outcome.Fail)
                return outcome;

            outcome = sdm.EmitAnalysis();
            if(outcome.Fail)
                return outcome;

            return outcome;
        }
    }
}