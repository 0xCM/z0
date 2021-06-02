//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;
    using System.IO;

    using static Root;
    using static core;

    public class AsmRowPipe : AppService<AsmRowPipe>
    {

        public AsmRowPipe()
        {
        }

        public FS.Files AsmDetailFiles()
            => Db.TableDir<AsmDetailRow>().AllFiles;

        public Index<AsmDetailRow> LoadAsmDetails()
        {
            var records = DataList.create<AsmDetailRow>(Pow2.T18);
            var paths = AsmDetailFiles().View;
            var flow = Wf.Running(string.Format("Loading {0} asm recordsets", paths.Length));
            var count = paths.Length;
            var counter = 0u;
            for(var i=0; i<count; i++)
            {
                ref readonly var path = ref skip(paths,i);
                var result = LoadDetails(path, records);
                if(result)
                    counter += result.Data;
            }

            Wf.Ran(flow, string.Format("Loaded {0} total asm instruction rows", counter));
            return records.Emit();
        }

        public Index<AsmDetailRow> LoadDetails(AsmMnemonicCode monic)
        {
            var file = AsmDetailFiles().FirstOrDefault(f => f.FileName.Contains(monic.ToString()));
            if(file.IsEmpty)
                return sys.empty<AsmDetailRow>();

            var records = DataList.create<AsmDetailRow>(Pow2.T12);
            var count = LoadDetails(file, records);
            return records.Emit();
        }

        Outcome<Count> LoadDetails(FS.FilePath path, DataList<AsmDetailRow> dst)
        {
            var rowtype = path.FileName.WithoutExtension.Format().RightOfLast(Chars.Dot);
            var flow = Wf.Running(string.Format("Loading {0} rows from {1}", rowtype, path.ToUri()));
            var result = TextDoc.parse(path, out var doc);
            var kRows = 0;
            if(result)
            {
                var kCells = doc.Header.Labels.Count;
                if(kCells != AsmDetailRow.FieldCount)
                    return (false,string.Format("Found {0} fields in {1} while {2} were expected", kCells, path.ToUri(), AsmDetailRow.FieldCount));

                var rows = doc.Rows;
                kRows = rows.Length;
                for(var j=0; j<kRows; j++)
                {
                    ref readonly var src = ref skip(rows,j);
                    if(src.CellCount != AsmDetailRow.FieldCount)
                        return (false, string.Format("Found {0} fields in {1} while {2} were expected", kCells, src, AsmDetailRow.FieldCount));
                    var loaded = LoadRow(src, out AsmDetailRow row);
                    if(!loaded)
                    {
                        Wf.Error(loaded.Message);
                        return false;
                    }

                    dst.Add(row);
                }

                Wf.Ran(flow, string.Format("Loaded {0} {1} rows from {2}", kRows, rowtype, path.ToUri()));
            }
            else
            {
                Wf.Error(result.Message);
            }

            return (true,kRows);
        }

        public ReadOnlySpan<CpuIdRow> LoadCpuIdRows(FS.FilePath src)
        {
            using var reader = src.Reader();
            return LoadCpuIdRows(reader);
        }

        public ReadOnlySpan<CpuIdRow> LoadCpuIdRows(TextReader reader)
        {
            const byte FieldCount = CpuIdRow.FieldCount;
            const char Delimiter = Chars.Pipe;

            var header = TextDocs.header(reader.ReadLine(), Delimiter);
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

                var result = LoadRow(data, out CpuIdRow row);
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

        Outcome LoadRow(TextRow src, out CpuIdRow dst)
        {
            var input = src.Cells.View;
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

        Outcome LoadRow(TextRow src, out AsmDetailRow dst)
        {
            var input = src.Cells.View;
            var i = 0;
            var outcome = Outcome.Empty;
            dst = default;
            outcome = DataParser.parse(skip(input, i++), out dst.Sequence);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.BlockAddress);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.IP);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.GlobalOffset);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.LocalOffset);
            if(!outcome)
                return outcome;

            dst.Mnemonic = new AsmMnemonic(skip(input, i++));

            outcome = AsmParser.parse(skip(input, i++), out dst.OpCode);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Instruction);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Statement);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.Encoded);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.CpuId);
            if(!outcome)
                return outcome;

            outcome = DataParser.parse(skip(input, i++), out dst.OpCodeId);
            if(!outcome)
                return outcome;
            return true;
        }

        public void RenderRows(AsmMnemonicCode code, FS.FilePath dst)
        {
            var rows = @readonly(Wf.AsmRowPipe().LoadDetails(code).OrderBy(x => x.Statement).Array());
            var count = rows.Length;
            if(count == 0)
                return;

            using var writer = dst.Writer();

            switch(code)
            {
                case AsmMnemonicCode.JMP:
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var row = ref skip(rows,i);
                        var rendered = string.Format(RowPattern(code),
                            row.IP,
                            row.Statement,
                            row.BlockAddress,
                            row.LocalOffset,
                            row.Encoded.Length,
                            row.Instruction,
                            row.OpCode,
                            row.Encoded,
                            AsmBitstrings.format(row.Encoded),
                            Semantic(row)
                        );
                        writer.WriteLine(rendered);
                    }
                break;
            }
        }

        [Op]
        public string FormatRow(in AsmDetailRow src, FuncIn<AsmDetailRow,string> semantic)
            => string.Format(RowPattern(),
                            src.IP,
                            src.Statement,
                            src.BlockAddress,
                            src.LocalOffset,
                            src.Encoded.Length,
                            src.Instruction,
                            src.OpCode,
                            src.Encoded,
                            AsmBitstrings.format(src.Encoded),
                            Semantic(src)
                        );

        [Op]
        public string RowPattern(AsmMnemonicCode monic = default)
        {
            var pattern = EmptyString;
            switch(monic)
            {
                case AsmMnemonicCode.JMP:
                    pattern = "{0} {1,-32} ; [{2}:{3}:{4}] => ({5})<{6}> => [{7}] => [{8}] | {9}";
                break;
                default:
                    pattern = "{0} {1,-32} ; [{2}:{3}:{4}] => ({5})<{6}> => [{7}] => [{8}] | {9}";
                    break;
            }
            return pattern;
        }

        [Op]
        public string Semantic(in AsmDetailRow row)
        {
            var monic = AsmMnemonicCode.None;
            if(!AsmParser.parse(row.Mnemonic, out monic))
                return string.Format("The mnemonic {0} is not known", row.Mnemonic);

            var encoded = row.Encoded;
            var ip = row.IP;
            var @base = row.BlockAddress;

            switch(monic)
            {
                case AsmMnemonicCode.JMP:

                if(JmpRel8.test(encoded))
                    return string.Format("jmp(rel8,{0},{1}) -> {2}",
                        JmpRel8.dx(encoded),
                        JmpRel8.offset(@base, ip, encoded),
                        JmpRel8.target(ip, encoded)
                        );
                else if(JmpRel32.test(encoded))
                    return string.Format("jmp(rel32,{0},{1}) -> {2}",
                        JmpRel32.dx(encoded).FormatMinimal(),
                        JmpRel32.offset(@base, ip, encoded).FormatMinimal(),
                        JmpRel32.target(ip, encoded)
                        );
                else if(Jmp64.test(encoded))
                    return string.Format("jmp({0})", Jmp64.target(encoded));

                break;
            }
            return EmptyString;
        }
    }
}