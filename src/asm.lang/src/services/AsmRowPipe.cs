//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

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
                return array<AsmDetailRow>();

            var records = DataList.create<AsmDetailRow>(Pow2.T12);
            var count = LoadDetails(file, records);
            return records.Emit();
        }

        Outcome<Count> LoadDetails(FS.FilePath path, DataList<AsmDetailRow> dst)
        {
            var rowtype = path.FileName.WithoutExtension.Format().RightOfLast(Chars.Dot);
            var flow = Wf.Running(string.Format("Loading {0} rows from {1}", rowtype, path.ToUri()));
            var result = TextGrids.load(path, out var doc);
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
                    var loaded = AsmParser.parse(src, out AsmDetailRow row);
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
                            AsmRender.semantic(row)
                        );
                        writer.WriteLine(rendered);
                    }
                break;
            }
        }

        [Op]
        public static string RowPattern(AsmMnemonicCode monic = default)
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
    }
}