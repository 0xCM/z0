//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".import-cult-data")]
        Outcome ImportCultData(CmdArgs args)
        {
            Wf.CultProcessor().Process();
            return true;
        }
    }
}