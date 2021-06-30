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
            Wf.IntelSdmProcessor().Run();
            return true;
        }
    }
}