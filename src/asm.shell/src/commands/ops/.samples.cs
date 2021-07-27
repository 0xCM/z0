//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".samples")]
        Outcome ToolSamples(CmdArgs args)
        {
            Files(ToolWs().Samples(arg(args,0).Value).AllFiles);
            return true;
        }
    }
}