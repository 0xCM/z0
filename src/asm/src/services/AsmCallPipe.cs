//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static core;

    public sealed class AsmCallPipe : AppService<AsmCallPipe>
    {
        public ReadOnlySpan<AsmCallRow> EmitRows(ReadOnlySpan<ApiPartRoutines> src)
        {
            var dst = Db.TableDir<AsmCallRow>();
            return EmitRows(src, dst);
        }

        public ReadOnlySpan<AsmCallRow> EmitRows(ReadOnlySpan<ApiPartRoutines> src, FS.FolderPath dst)
        {
            var rows = root.datalist<AsmCallRow>();
            var count = src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var routines = ref skip(src,i);
                var path = Db.Table(dst, AsmCallRow.TableId, routines.Part);
                EmitRows(routines, rows, path);
            }
            return rows.View();
        }

        void EmitRows(in ApiPartRoutines src, DataList<AsmCallRow> rows, FS.FilePath dst)
        {
            var flow = Wf.EmittingTable<AsmCallRow>(dst);
            using var writer = dst.Writer();
            var calls = Calls(src.Instructions());
            var view = calls.View;
            var count = view.Length;
            var formatter = Tables.formatter<AsmCallRow>(AsmCallRow.RenderWidths);
            writer.WriteLine(formatter.FormatHeader());
            for(var i=0; i<count; i++)
            {
                ref readonly var row = ref skip(view,i);
                writer.WriteLine(formatter.Format(row));
                rows.Add(row);
            }

            Wf.EmittedTable(flow, count);
        }

        /// <summary>
        /// Filters a set of instructions predicated on s specified mnemonic
        /// </summary>
        /// <param name="src">The data sourde</param>
        /// <param name="mnemonic">The mnemonic of interest</param>
        [Op]
        static Index<ApiInstruction> filter(Index<ApiInstruction> src, IceMnemonic mnemonic)
            => from a in src.Storage
                let i = a.Instruction
                where i.Mnemonic == mnemonic
                select a;

        [Op]
        public Index<AsmCallRow> Calls(Index<ApiInstruction> src)
        {
            var calls = filter(src, IceMnemonic.Call).View;
            var count = calls.Length;
            var buffer = alloc<AsmCallRow>(count);
            ref var row = ref first(span(buffer));
            for(var i=0u; i<count; i++)
            {
                ref readonly var call = ref skip(calls,i);
                ref var dst = ref seek(row,i);
                var bytes = @readonly(call.EncodedData.Storage);
                var offset = ByteReader.read(slice(bytes,1));
                dst.Block = call.BaseAddress;
                dst.Source = call.IP;
                dst.Target = call.NextIp + offset;
                dst.InstructionSize = call.InstructionSize;
                dst.TargetOffset = dst.Target - (dst.Source + dst.InstructionSize);
                dst.Instruction = call.Statment;
                dst.Encoded = call.Encoded;
            }
            return buffer;
        }

        public Index<AsmCallRow> LoadRows()
        {
            var paths = Db.TableDir<AsmCallRow>().AllFiles.View;
            var flow = Wf.Running(string.Format("Loading {0} call recordsets", paths.Length));
            var dst = root.list<AsmCallRow>();
            var count = paths.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var file = ref skip(paths,i);
                var doc = TextDocs.parse(file);
                if(doc)
                {
                    var rows = doc.Value.Rows;
                    var kRows = rows.Length;
                    for(var j = 0; j<kRows; j++)
                    {
                        ref readonly var row = ref skip(rows,j);
                        if(row.CellCount == AsmCallRow.FieldCount)
                        {
                            var cells = row.Cells.View;
                            var record = new AsmCallRow();
                            var k = 0;
                            DataParser.parse(skip(cells, k++).Text, out record.Block);
                            DataParser.parse(skip(cells, k++).Text, out record.Source);
                            DataParser.parse(skip(cells, k++).Text, out record.Target);
                            DataParser.parse(skip(cells, k++).Text, out record.InstructionSize);
                            DataParser.parse(skip(cells, k++).Text, out record.TargetOffset);
                            record.Instruction = skip(cells, k++).Text;
                            DataParser.parse(skip(cells, k).Text, out record.Encoded);
                            dst.Add(record);
                        }
                    }
                }
            }

            Wf.Ran(flow, string.Format("Loaded {0} total call instructions", dst.Count));
            return dst.ToArray();
        }
    }
}