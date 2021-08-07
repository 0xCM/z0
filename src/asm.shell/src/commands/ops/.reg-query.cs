//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static RegTokens;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".reg-query")]
        Outcome RegQuery(CmdArgs args)
        {
            var result = Outcome.Success;
            var regs = AsmRegSets.create(Wf);
            var pred = arg(args,0).Value;
            var selected = default(ReadOnlySpan<RegOp>);
            switch(pred)
            {
                case "gp8":
                    selected = regs.GpGrid().Row(GpRegKind.Gp8);
                    break;
                case "gp16":
                    selected = regs.GpGrid().Row(GpRegKind.Gp16);
                break;
                case "gp32":
                    selected = regs.GpGrid().Row(GpRegKind.Gp32);
                break;
                case "gp64":
                    selected = regs.GpGrid().Row(GpRegKind.Gp64);
                break;
                case "xmm":
                    selected = regs.XmmRegs();
                break;
                case "ymm":
                break;
                case "zmm":
                break;
                case "k":
                case "mask":
                break;
            }

            var buffer = text.buffer();
            iter(selected, reg => buffer.AppendFormat("{0} ", reg));
            Write(buffer.Emit());

            return result;
        }
    }
}