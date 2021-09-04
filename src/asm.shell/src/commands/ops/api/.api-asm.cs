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
        Index<HostAsmRecord> LoadHostAsm()
            => AsmEtl.LoadHostAsmRows(ApiArchive.HostAsm());

        Index<AsmDataBlock> LoadAsmBlocks()
        {
            var hostasm = State.HostAsm(LoadHostAsm);
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

            var path = Ws.Gen().Subdir("csv") + Tables.filename<AsmDataBlock>();
            TableEmit(slice(@readonly(buffer), 0, key), AsmDataBlock.RenderWidths, TextEncodingKind.Unicode, path);
            return buffer;
        }

        [CmdOp(".api-asm")]
        Outcome ApiAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var blocks = State.Records(LoadAsmBlocks);
            return result;
        }
    }
}