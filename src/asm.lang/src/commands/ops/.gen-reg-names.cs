//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Root;
    using static core;
    using static AsmCodes;

    partial class AsmCmdService
    {
        [CmdOp(".gen-regnames")]
        Outcome EmitRegNames(CmdArgs args)
        {
            var dst = Workspace.Generated("common","regnames", FS.Cs);
            var flow = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var regs = AsmRegs.list(GP);
            var bytespan = SpanRes.specify("GpRegNames", recover<RegOp,byte>(regs).ToArray());
            writer.WriteLine(bytespan.Format());
            EmittedFile(flow, regs.Length);
            return true;
        }
    }
}