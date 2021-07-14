//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".sdm")]
        Outcome ProcessSdm(CmdArgs args)
        {
            //Wf.IntelSdmProcessor().Run();
            var sdm = Wf.IntelSdmProcessor();
            return sdm.Run();
        }
    }
}