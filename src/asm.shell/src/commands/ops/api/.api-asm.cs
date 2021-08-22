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
        [CmdOp(".api-asm")]
        Outcome ApiAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var rows = AsmEtl.LoadHostAsmRows(ApiArchive.HostAsm());
            var src = rows.View;
            var count = src.Length;
            var buffer = alloc<AsmDataBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref var b = ref seek(dst,i);
                ref readonly var s = ref skip(src,i);
                b.GlobalIndex = i;
                b.BlockAddress = s.BlockAddress;
                b.IP = s.IP;
                b.BlockOffset = s.BlockOffset;
                text.asci(s.Expression.Content, b.Expression.Bytes);
            }

            return result;
        }
    }
}