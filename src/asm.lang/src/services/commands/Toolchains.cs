//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Windows;

    using static Root;
    using static core;
    using static Typed;

    partial class AsmCmdService
    {
        [CmdOp(".asm")]
        Outcome ToolChain(CmdArgs args)
        {
            if(args.Length ==0)
            {
                return (false, "No arguments were supplied");
            }
            var name = (string)args.First.Value;
            var workspace = Wf.AsmWorkspace();
            var toolchain = Wf.AsmToolchain();
            var spec = workspace.ToolchainSpec(Toolsets.nasm, Toolsets.bddiasm, name);
            return toolchain.Run(spec);
        }

        [CmdOp(".sdm")]
        Outcome ProcessSdm(CmdArgs args)
        {
            Wf.IntelSdmProcessor().Run();
            return true;
        }
    }
}