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
        [CmdOp(".sdm-opcode-list")]
        Outcome SdmOpCodeList(CmdArgs args)
        {
            var result = LoadSdmOpcodes(out var opcodes);
            if(result.Fail)
                return result;

            var dst = AsmWs.DataDir() + FS.file("sdm.opcode-list", FS.Txt);
            using var writer = dst.AsciWriter();
            var src = @readonly(opcodes);
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(src,i);
                ref var opcode = ref SdmModels.opcode(record, out _);
                var fmt = opcode.Format();
                writer.WriteLine(fmt);
                Write(fmt);
            }
            Emitted(dst);
            return result;
        }
    }
}