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
        [CmdOp(".gen-reg-names")]
        Outcome EmitRegNames(CmdArgs args)
        {
            var dst = Gen().Path("cs","regnames", FS.Cs);
            var flow = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var regs = AsmRegs.list(GP);
            var count = regs.Length;
            var buffer = text.buffer();
            for(var i=0; i<count; i++)
            {
                if(i != 0 && i%4 == 0)
                    buffer.AppendLine();

                ref readonly var reg = ref skip(regs,i);
                buffer.AppendFormat("{0,-6}", reg);
            }
            Write(buffer.Emit());
            var bytespan = SpanRes.specify("GpRegNames", recover<RegOp,byte>(regs).ToArray());
            writer.WriteLine(bytespan.Format());
            EmittedFile(flow, regs.Length);
            return true;
        }
    }
}