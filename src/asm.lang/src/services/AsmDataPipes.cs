//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;
    using static Typed;

    public class AsmDataPipes : AppService<AsmDataPipes>
    {
        public static Outcome load(TextRow src, out CpuIdRow dst)
        {
            var input = src.Cells;
            var i = 0;
            var outcome = Outcome.Success;
            outcome += DataParser.parse(skip(input,i++), out dst.Leaf);
            outcome += DataParser.parse(skip(input,i++), out dst.Subleaf);
            outcome += DataParser.parse(skip(input,i++), out dst.Eax);
            outcome += DataParser.parse(skip(input,i++), out dst.Ebx);
            outcome += DataParser.parse(skip(input,i++), out dst.Ecx);
            outcome += DataParser.parse(skip(input,i++), out dst.Edx);
            return outcome;
        }

        public static void describe(ReadOnlySpan<CpuIdRow> src, ITextBuffer dst)
        {
            var count = src.Length;
            var j = 0u;
            var w = n8;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                describe(row, dst);
            }
        }

        public static void describe(in CpuIdRow row, ITextBuffer dst)
        {
            var w = n8;
            dst.AppendFormat("eax: {0} [{1}] | ", row.Eax, row.Eax.FormatBitstring(w));
            var ebx = row.Ebx.FormatBitstring(w);
            dst.AppendFormat("ebx: {0} [{1}] | ", row.Ebx, row.Ebx.FormatBitstring(w));
            var ecx = row.Ecx.FormatBitstring(w);
            dst.AppendFormat("ebx: {0} [{1}] | ", row.Ecx, row.Ecx.FormatBitstring(w));
            var edx = row.Edx.FormatBitstring(w);
            dst.AppendFormat("edx: {0} [{1}]", row.Edx, row.Edx.FormatBitstring(w));
        }

        public ReadOnlySpan<CpuIdRow> LoadCpuIdRecords(FS.FilePath src)
        {
            using var reader = src.Reader();
            return LoadCpuIdRecords(reader);
        }

        public ReadOnlySpan<CpuIdRow> LoadCpuIdRecords(TextReader reader)
        {
            const byte FieldCount = CpuIdRow.FieldCount;
            const char Delimiter = Chars.Pipe;

            var header = TextGrids.header(reader.ReadLine(), Delimiter);
            var count = header.Length;
            if(count != FieldCount)
            {
                Wf.Error(Tables.FieldCountMismatch.Format(FieldCount,count));
                return default;
            }

            var current = reader.ReadLine();
            var dst = list<CpuIdRow>();
            while(current != null)
            {
                var data = TextRow.parse(current,Chars.Pipe);
                if(data.CellCount != FieldCount)
                {
                    Wf.Error(Tables.FieldCountMismatch.Format(FieldCount, data.CellCount));
                    return default;
                }

                var result = AsmDataPipes.load(data, out CpuIdRow row);
                if(result.Fail)
                {
                    Wf.Error(result.Message);
                    return default;
                }

                dst.Add(row);

                current = reader.ReadLine();
            }
            return dst.ViewDeposited();
        }
    }
}