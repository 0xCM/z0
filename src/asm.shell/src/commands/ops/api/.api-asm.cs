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
            for(var i=0u; i<count; i++)
            {
                ref var dst = ref seek(records,i);
                ref readonly var src = ref skip(hostasm,i);
                dst.Key = i;
                dst.BlockAddress = src.BlockAddress;
                dst.IP = src.IP;
                dst.BlockOffset = src.BlockOffset;
                dst.Expression = src.Expression.Format();
                dst.Encoded = @as<AsmHexCode,ByteBlock16>(src.Encoded);
                dst.Encoded[15] = 0;
                dst.Bitstring = src.Bitstring.Format();
                dst.Sig = src.Sig.Format();
                dst.OpCode = src.OpCode.Format();
                // if(src.OpUri != null)
                //     dst.OpUri = src.OpUri.Format();
                // else
                //     dst.OpUri = RP.Null;
            }
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