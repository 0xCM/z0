//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm")]
        Outcome ToolChain(CmdArgs args)
        {
            var count = args.Length;
            if(count ==0)
                return (false, "No arguments were supplied");

            var toolchain = Wf.AsmToolchain();
            var srcId = (string)args.First.Value;
            var spec = Workspace.ToolchainSpec(Toolsets.nasm, Toolsets.bddiasm, srcId);
            if(count > 1)
            {
                Enums.parse(args[1].Value, out spec.AsmBitMode);
            }

            return toolchain.Run(spec);
        }
    }
}