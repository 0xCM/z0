//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmCmdService
    {
        [CmdOp(".asm")]
        Outcome Assemble(CmdArgs args)
        {
            var count = args.Length;
            if(count ==0)
                return (false, "No arguments were supplied");

            var toolchain = Wf.AsmToolchain();
            var id = (string)args.First.Value;
            var spec = AsmWs.ToolchainSpec(Toolspace.nasm, Toolspace.bddiasm, id);
            if(count > 1)
                Enums.parse(args[1].Value, out spec.AsmBitMode);

            var result = toolchain.Run(spec);
            if(result)
            {
                var path = AsmWs.BinPath(id);
                _Assembled = path.ReadBytes();
                RoutineName = id;
            }
            return result;
        }
    }
}