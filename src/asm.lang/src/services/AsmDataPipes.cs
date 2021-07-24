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

    public class AsmDataPipes : AppService<AsmDataPipes>
    {
        AsmWs Workspace;

        protected override void Initialized()
        {
            Workspace = Wf.AsmWs();
        }

        public Index<AsmHostStatement> LoadHostStatements(FS.FilePath src)
        {
            var result = TextGrids.load(src, out var doc);
            if(!result)
            {
                Error(result.Message);
                return default;
            }
            else
            {
                var dst = alloc<AsmHostStatement>(doc.RowCount);
                var count = AsmParser.parse(doc, dst);
                if(count)
                    return dst;

                Error(count.Message);
                return default;
            }
        }

        public Index<AsmHostStatement> LoadHostStatements(FS.FolderPath dir)
        {
            var files = dir.EnumerateFiles(FS.Csv, true).Array();
            var flow = Wf.Running(ParsingStatements.Format(files.Length,dir));
            var dst = bag<AsmHostStatement>();
            var docs = TextGrids.load(files);
            var counter = 0u;
            foreach(var doc in docs)
            {
                var parsing = Wf.Running(ParsingStatementRows.Format(doc.RowCount));
                var count = AsmParser.parse(doc, dst);
                if(count.Fail)
                    Wf.Error(count.Message);
                else
                {
                    var scount = count.Data;
                    Wf.Ran(parsing, ParsedStatementRows.Format(scount));
                    counter += scount;
                }
            }

            Wf.Ran(flow, ParsedStatements.Format(counter));

            return dst.ToArray();
        }

        public ReadOnlySpan<CpuIdRow> LoadCpuIdImports()
        {
            var src = Workspace.ImportTable<CpuIdRow>();
            using var reader = src.Utf8Reader();
            return LoadCpuIdImports(reader);
        }

        public Outcome ImportCpuIdSources()
        {
            //2 space-separated 32-bit hex numbers
            const byte InLength = 2*8 + 1;

            //4 32-bit hex numbers interspersed with spaces
            const byte OutLength = 4*8 + 3;

            const string Imply = " => ";

            var srcdir = Workspace.DataSource("sde.cpuid");
            var srcfiles = srcdir.Files(FS.Def, true).ToReadOnlySpan();
            var count = srcfiles.Length;
            var outcome = Outcome.Success;
            var records = list<CpuIdRow>();

            for(var i=0; i<count; i++)
            {
                if(outcome.Fail)
                    break;

                ref readonly var file = ref skip(srcfiles,i);
                var chip = file.FolderName.Format();
                var formatter = Tables.formatter<CpuIdRow>();
                using var reader = file.LineReader(TextEncodingKind.Asci);
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
                outcome = Emit(deposited);
            else
                Error(outcome.Message);

            return outcome;
        }

        Outcome Emit(ReadOnlySpan<CpuIdRow> src)
        {
            var dst = Workspace.ImportTable<CpuIdRow>();
            var emitting = Wf.EmittingTable<CpuIdRow>(dst);
            var formatter = Tables.formatter<CpuIdRow>();
            using var rowWriter = dst.AsciWriter();
            rowWriter.WriteLine(formatter.FormatHeader());
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(src,i);
                rowWriter.WriteLine(formatter.Format(row));
            }
            Wf.EmittedTable(emitting, count);

            using var bitWriter = Workspace.Bitfield("cpuid").AsciWriter();
            var buffer = text.buffer();
            AsmRender.bitfields(src,buffer);
            bitWriter.WriteLine(buffer.Emit());
            return true;
        }

        ReadOnlySpan<CpuIdRow> LoadCpuIdImports(TextReader reader)
        {
            const byte FieldCount = CpuIdRow.FieldCount;
            const char Delimiter = Chars.Pipe;

            var header = TextGrids.header(reader.ReadLine(), Delimiter);
            var count = header.Length;
            if(count != FieldCount)
            {
                Error(Tables.FieldCountMismatch.Format(FieldCount,count));
                return default;
            }

            var current = reader.ReadLine();
            var dst = list<CpuIdRow>();
            while(current != null)
            {
                var data = TextRow.parse(current,Chars.Pipe);
                if(data.CellCount != FieldCount)
                {
                    Error(Tables.FieldCountMismatch.Format(FieldCount, data.CellCount));
                    return default;
                }

                var result = AsmParser.parse(data, out CpuIdRow row);
                if(result.Fail)
                {
                    Error(result.Message);
                    return default;
                }

                dst.Add(row);

                current = reader.ReadLine();
            }

            return dst.ViewDeposited();
        }


        public static MsgPattern<Count,FS.FolderPath> ParsingStatements => "Parsing statements from {0} files from {1}";

        public static MsgPattern<Count> ParsedStatements => "Parsed {0} total statements";

        public static MsgPattern<Count> ParsingStatementRows => "Parsing {0} rows";

        public static MsgPattern<Count> ParsedStatementRows => "Parsing {0} rows";
    }
}