//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    partial class AsmCmdService
    {
        Index<HostAsmRecord> LoadHostAsmRows()
            => AsmEtl.LoadHostAsmRows(ApiArchive.HostAsm());

        Index<AsmDataBlock> DistillHostAsmBlocks()
        {
            var hostasm = State.HostAsm(LoadHostAsmRows);
            var count = hostasm.Length;
            var buffer = alloc<AsmDataBlock>(count);
            ref var records = ref first(buffer);
            var block = MemoryAddress.Zero;
            var skipping = false;
            var key = 0u;
            for(var i=0u; i<count; i++)
            {
                ref readonly var src = ref skip(hostasm,i);
                ref readonly var BlockAddress = ref src.BlockAddress;
                ref readonly var Expression = ref src.Expression;
                var newblock = (block != BlockAddress);
                if(!newblock && skipping)
                    continue;

                if(newblock)
                {
                    block = BlockAddress;
                    skipping = false;
                }

                if(Expression.IsInvalid)
                {
                    skipping = true;
                    continue;
                }

                ref var dst = ref seek(records, key++);
                dst.Key = key;
                dst.BlockAddress = BlockAddress;
                dst.IP = src.IP;
                dst.BlockOffset = src.BlockOffset;
                dst.Expression = Expression.Format();
                dst.Encoded = src.Encoded.Format();
                dst.Bitstring = src.Bitstring.Format();
                dst.Sig = src.Sig.Format();
                dst.OpCode = src.OpCode.Format();
            }

            return slice(@readonly(buffer), 0, key).ToArray();
        }

        void EmitHostAsmBlocks(ReadOnlySpan<AsmDataBlock> src, FS.FilePath dst)
        {
            TableEmit(src, AsmDataBlock.RenderWidths, TextEncodingKind.Unicode, dst);
        }

        [CmdOp(".api-asm")]
        Outcome ApiAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var dst = Ws.Gen().Subdir("csv") + Tables.filename<AsmDataBlock>();
            EmitHostAsmBlocks(State.Records(DistillHostAsmBlocks),dst);
            return result;
        }
    }
}