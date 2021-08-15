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
        [CmdOp(".emit-llvm-opcodes")]
        Outcome LlvmOpCodes(CmdArgs args)
        {
            var result = Outcome.Success;
            var calcs = MC.calcs();
            var count = calcs.AsmCount;

            var buffer = alloc<OpCodeSpec>(count);
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

            TableEmit(@readonly(buffer), OpCodeSpec.RenderWidths, TableWs().Table<OpCodeSpec>(FS.Csv));

            return result;
        }
    }
}