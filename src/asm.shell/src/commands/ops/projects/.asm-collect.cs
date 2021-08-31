//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm-collect")]
        Outcome AsmCollect(CmdArgs args)
        {
            var result = Outcome.Success;
            result = CollectObjAsm();
            if(result.Fail)
                return result;

            result = CollectSyms();

            return result;
        }
    }
}