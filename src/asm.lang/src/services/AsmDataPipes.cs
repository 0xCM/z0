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
        AsmWorkspace Workspace;
        protected override void Initialized()
        {
            Workspace = Wf.AsmWorkspace();
        }

        public static Outcome load(TextRow src, out CpuIdRow dst)
        {
            var input = src.Cells;
            var i = 0;
            var outcome = Outcome.Success;
            outcome += DataParser.parse(skip(input,i++), out dst.Chip);
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

        public ReadOnlySpan<CpuIdRow> LoadCpuIdTable(FS.FilePath src)
        {
            using var reader = src.Reader();
            return LoadCpuIdTable(reader);
        }

        public Outcome ImportCpuIdSources()
        {
            //2 space-separated 32-bit hex numbers
            const byte InLength = 2*8 + 1;

            //4 32-bit hex numbers interspersed with spaces
            const byte OutLength = 4*8 + 3;

            const string Imply = " => ";

            var dir = Workspace.DataSource("cpuid");
            var files = dir.Files(FS.Def,true).ToReadOnlySpan();
            var count = files.Length;
            var outcome = Outcome.Success;
            var records = list<CpuIdRow>();

            for(var i=0; i<count; i++)
            {
                if(outcome.Fail)
                    break;

                ref readonly var file = ref skip(files,i);
                var chip = file.FolderName.Format();
                var formatter = Tables.formatter<CpuIdRow>();
                using var reader = file.AsciLineReader();
                while(reader.Next(out var line))
                {
                    if(line.StartsWith(Chars.Hash))
                        continue;

                    var content = line.Content;
                    var index = text.index(content, Imply);
                    if(index != NotFound)
                    {
                        var row = new CpuIdRow();
                        var input = text.left(content, index);
                        var iargs = input.Split(Chars.Space).ToReadOnlySpan();
                        if(iargs.Length != 2)
                        {
                            outcome = (false, "Line did not split on marker");
                            break;
                        }

                        outcome = DataParser.parse(skip(iargs,0), out row.Leaf);
                        if(outcome.Fail)
                        {
                            outcome = (false, "Failed to parse eax");
                            break;
                        }

                        if(skip(iargs,1).Contains(Chars.Star))
                            row.Subleaf = uint.MaxValue;
                        else
                            outcome = DataParser.parse(skip(iargs,1), out row.Subleaf);

                        if(outcome.Fail)
                        {
                            outcome = (false, "Failed to parse ecx");
                            break;
                        }

                        var output = text.right(content,index);
                        if(output.Length < OutLength)
                        {
                            outcome = (false, "Output length too short");
                            break;
                        }

                        var outvals = text.slice(output, 0, OutLength).Trim().Split(Chars.Space).ToReadOnlySpan();
                        if(outvals.Length < 5)
                        {
                            outcome = (false, string.Format("Output count = {0}, expected at least {1}", outvals.Length, OutLength));
                            break;
                        }
                        row.Chip = chip;
                        outcome = DataParser.parse(skip(outvals,1), out row.Eax);
                        if(outcome.Fail)
                            break;

                        outcome = DataParser.parse(skip(outvals,2), out row.Ebx);
                        if(outcome.Fail)
                            break;

                        outcome = DataParser.parse(skip(outvals,3), out row.Ecx);
                        if(outcome.Fail)
                            break;

                        outcome = DataParser.parse(skip(outvals,4), out row.Edx);
                        if(outcome.Fail)
                            break;

                        if(outcome)
                            records.Add(row);
                    }
                }
           }

            var deposited = records.ViewDeposited();
            if(outcome)
            {
                var dst = Workspace.Table<CpuIdRow>();
                var emitting = Wf.EmittingTable<CpuIdRow>(dst);
                var formatter = Tables.formatter<CpuIdRow>();
                using var writer = dst.AsciWriter();
                writer.WriteLine(formatter.FormatHeader());
                var _count = deposited.Length;
                for(var i=0; i<_count; i++)
                    writer.WriteLine(formatter.Format(skip(deposited,i)));

                Wf.EmittedTable(emitting, _count);
            }
            else
                Error(outcome.Message);

            return outcome;
        }

        ReadOnlySpan<CpuIdRow> LoadCpuIdTable(TextReader reader)
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