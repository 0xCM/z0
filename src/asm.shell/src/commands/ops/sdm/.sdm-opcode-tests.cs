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
        [CmdOp(".sdm-opcode-tests")]
        public Outcome TestOcStrings(CmdArgs args)
        {
            var result = Outcome.Success;
            var runtime = MemoryStrings.create(OpCodeStrings.Offsets, OpCodeStrings.Data);
            var offsets = recover<uint>(OpCodeStrings.Offsets);
            var formatter = Tables.formatter<MemoryStrings>();
            Write(formatter.Format(runtime, RecordFormatKind.KeyValuePairs));

            result = CheckOffsets(runtime,offsets);
            if(result.Fail)
                return result;
            else
                Write("Success");

            return result;
        }

        static Outcome CheckOffsets(in MemoryStrings info, ReadOnlySpan<uint> offsets)
        {
            var result = Outcome.Success;
            for(var i=0; i<info.EntryCount; i++)
            {
                var actual = MemoryStrings.offset(info,i);
                var expect = skip(offsets,i);
                if(actual != expect)
                {
                    result = (false,$"{expect} != {actual}");
                    return result;
                }
            }

            return result;
        }
    }
}