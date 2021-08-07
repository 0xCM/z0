//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using Z0.llvm;

    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".llvm-mc-data")]
        Outcome LlvmMcData(CmdArgs args)
        {
            const string Example = "00 00 00 04 96 10 4c ce";
            var result = Outcome.Success;
            var calcs = MC.calcs();
            var count = calcs.AsmCount;

            var buffer = alloc<LlvmOpCodeSpec>(count);
            ref var dst = ref first(buffer);
            var ids = calcs.AsmId();
            for(ushort i=0; i<count; i++)
            {
                ref readonly var id = ref skip(ids,i);
                ref readonly var sym = ref calcs.Sym(id);
                var opcode = calcs.OpCode(id);
                ref var record = ref seek(dst,i);
                record.Index = i;
                record.Mnemonic = calcs.Monic(id);
                record.OpId = sym.Name.Content.Content;
                record.OpCodeValue = opcode;
                record.OpCodeBytes = AsmRender.hexbytes(opcode);
            }

            Array.Sort(buffer);

            TableEmit(@readonly(buffer), LlvmOpCodeSpec.RenderWidths, TablePath<LlvmOpCodeSpec>());

            return result;
        }
    }
}