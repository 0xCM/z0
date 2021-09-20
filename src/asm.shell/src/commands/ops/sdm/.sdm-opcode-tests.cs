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
            var strings = MemoryStrings.load(OpCodeStrings.Offsets, OpCodeStrings.Data);
            var offsets = recover<uint>(OpCodeStrings.Offsets);
            var formatter = Tables.formatter<MemoryStrings>();
            Write(formatter.Format(strings, RecordFormatKind.KeyValuePairs));

            result = CheckOffsets(strings, offsets);
            if(result.Fail)
                return result;
            else
            {
                var count = strings.EntryCount;
                for(var i=0; i<count; i++)
                    Write(text.format(strings[i]));
            }

            return result;
        }

        static Outcome CheckOffsets(in MemoryStrings src, ReadOnlySpan<uint> offsets)
        {
            var result = Outcome.Success;
            var count = src.EntryCount;
            for(var i=0; i<count; i++)
            {
                ref readonly var actual = ref MemoryStrings.offset(src,i);
                ref readonly var expect = ref skip(offsets,i);
                if(actual != expect)
                {
                    result = (false, $"{expect} != {actual}");
                    return result;
                }
            }

            return result;
        }
    }
}