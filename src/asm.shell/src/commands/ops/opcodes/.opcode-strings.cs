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

        [CmdOp(".opcode-strings")]
        public Outcome OcStrings(CmdArgs args)
        {
            var result = Outcome.Success;

            result = LoadOpcodes(out var opcodes);
            if(result.Fail)
                return result;

            var count = opcodes.Length;
            // var content = alloc<string>(opcodes.Length);
            // for(var i=0; i<count; i++)
            //     seek(content,i) = skip(opcodes,i).OpCode;

            // var table = StringTables.create("OpCodeStrings", content);
            // var offsets = table.Offsets;
            // for(var i=0u; i<count; i++)
            // {
            //     var chars = table[i];
            //     var offset = skip(offsets,i);
            //     var length = chars.Length;
            //     var chars2 = slice(OpCodeStrings.Data,offset,length);
            //     Write(string.Format("{0} | {1} | {2,-6} | {3,-32} | {4,-32}", i, offset, length, text.format(chars), text.format(chars2)));
            // }

            //var count = opcodes.Length;
            var items = alloc<ListItem<string>>(count);
            for(var i=0u; i<count; i++)
            {
                seek(items,i) = (i,skip(opcodes,i).OpCode);
            }

            var spec = StringTables.specify("Z0.Asm", "OpCodeStrings", items);
            result = EmitStringTable(spec);

            return result;
        }

        [CmdOp(".test-opcode-strings")]
        public Outcome TestOcStrings(CmdArgs args)
        {
            var result = Outcome.Success;
            var info = StringTableInfo.infer(OpCodeStrings.Offsets, OpCodeStrings.Data);
            var offsets = recover<uint>(OpCodeStrings.Offsets);
            var formatter = Tables.formatter<StringTableInfo>();
            Write(formatter.Format(info, RecordFormatKind.KeyValuePairs));

            result = CheckStringOffsets(info,offsets);
            if(result.Fail)
                return result;
            else
                Write("Success");

            return result;
        }

        Outcome CheckStringOffsets(in StringTableInfo info, ReadOnlySpan<uint> offsets)
        {
            var result = Outcome.Success;
            for(var i=0u; i<info.EntryCount; i++)
            {
                var actual = StringTables.offset(info,i);
                var expect = skip(offsets,i);
                if(actual != expect)
                {
                    result = (false,$"{expect} != {actual}");
                    return result;
                }
                //Write(string.Format("{0} | {1} | {2}", i, skip(offsets,i), actual));
            }

            return result;
        }
    }
}