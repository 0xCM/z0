//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static z;

    using F = AsmRowField;

    partial struct asm
    {
        public static uint emit(IWfShell wf, AsmRowSet<IceMnemonic> src)
        {
            var count = src.Count;
            if(count != 0)
            {
                var dst = wf.Db().Table(AsmRow.TableId, src.Key.ToString());
                var records = span(src.Sequenced);
                var formatter = Table.dsformatter<AsmRowField>();
                var header = Table.header53<AsmRowField>();

                wf.EmittingTable<AsmRow>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(header);
                for(var i=0; i<count; i++)
                {
                    ref readonly var record = ref skip(records,i);
                    var line = format(record, formatter).Render();
                    writer.WriteLine(line);
                }
                wf.EmittedTable<AsmRow>(count, dst);
            }
            return count;
        }

        [Op]
        public static ref readonly DatasetFormatter<AsmRowField> format(in AsmRow src, in DatasetFormatter<AsmRowField> dst)
        {
            dst.Delimit(F.Sequence, src.Sequence);
            dst.Delimit(F.BlockAddress, src.BlockAddress);
            dst.Delimit(F.IP, src.IP);
            dst.Delimit(F.GlobalOffset, src.GlobalOffset);
            dst.Delimit(F.LocalOffset, src.LocalOffset);
            dst.Delimit(F.Mnemonic, src.Mnemonic);
            dst.Delimit(F.OpCode, src.OpCode);
            dst.Delimit(F.Instruction, src.Instruction);
            dst.Delimit(F.SourceCode, src.SourceCode);
            dst.Delimit(F.Encoded, src.Encoded);
            dst.Delimit(F.CpuId, src.CpuId);
            dst.Delimit(F.OpCodeId, src.OpCodeId);
            return ref dst;
        }
    }
}