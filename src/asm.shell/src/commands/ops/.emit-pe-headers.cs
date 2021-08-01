//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".emit-pe-headers")]
        Outcome EmitSectionHeaders(CmdArgs args)
        {
            var service = Wf.CliEmitter();
            service.EmitSectionHeaders();
            return true;
        }
    }
}