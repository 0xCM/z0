//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;
    using static memory;

    using Target = AsmStatementDetail;

    public class AsmDistiller : AsmWfService<AsmDistiller>
    {
        uint MaxLineCount;

        AsmRowStore RowStore;

        Index<AsmRow> Rows;

        MemoryAddress CurrentBlock;

        ApiCodeBlocks Blocks;

        MemorySymbols Symbols;

        uint CurrentRow;

        uint LastRow;

        public AsmDistiller()
        {
            MaxLineCount = 50000;
            CurrentRow = 0;
            LastRow = 0;
            CurrentBlock = 0;
            Blocks = ApiCodeBlocks.Empty;
            Symbols = MemorySymbols.alloc(50000);
        }

        public FS.Files Distillations()
            => Db.TableDir<AsmStatementDetail>().TopFiles;

        public void DistillStatements()
        {
            DistillStatements(Wf.ApiHexIndexer().IndexApiBlocks());
        }

        public void DistillStatements(ApiCodeBlocks src)
        {
            var flow = Wf.Running();
            Db.ClearTables<Target>();

            RowStore = Wf.AsmRowStore();
            CurrentRow = 0;
            Blocks = src;
            Rows = RowStore.CreateAsmRows(Blocks).Where(x => x.IP != 0).OrderBy(x => x.IP).Array();
            LastRow = Rows.Count - 1;
            CurrentBlock = Rows[CurrentRow].BlockAddress;

            var total = 0u;
            var count = DistillNextSegment();
            while(count != 0)
            {
                count = DistillNextSegment();
                total += count;
            }

            Wf.Ran(flow,total);
        }

        public Index<AsmStatementDetail> LoadDistillation(FS.FilePath src)
        {
            var flow = Wf.Running($"Parsing {src.ToUri()}");
            var partial = 0;
            var full = 0;
            var attempt = TextDocs.parse(src, out var doc);
            const byte fields = AsmStatementDetail.FieldCount;
            if(attempt)
            {
                var header = doc.Header;
                if(header.Labels.Length !=fields)
                {
                    Wf.Error($"The header {header} has {header.Labels.Length} fields and yet {fields} were expected");
                    return sys.empty<AsmStatementDetail>();
                }
                var count = doc.RowCount;
                var rows = doc.RowData.View;
                var buffer = sys.alloc<AsmStatementDetail>(count);
                var dst = span(buffer);
                for(var i=0; i<count; i++)
                {
                    ref readonly var row = ref skip(rows,i);
                    ref var target = ref seek(dst,i);
                    var outcome = Parse(row, out target);
                    if(outcome.Data < fields)
                        partial++;
                    else
                        full++;
                }

                Wf.Ran(flow, Msg.ParsedStatements.Format(full, partial, src));
                return buffer;
            }
            else
            {
                Wf.Error(attempt.Message);
                return sys.empty<AsmStatementDetail>();
            }
        }

        Outcome<byte> Parse(TextRow src, out AsmStatementDetail dst)
        {
            var count = src.CellCount;
            var i=0;
            var cells = src.Cells.View;
            dst = default;
            if(count >= 5)
            {
                ref readonly var cell = ref skip(cells,i);
                DataParser.parse(skip(cells, i++), out dst.Sequence);
                DataParser.parse(skip(cells, i++), out dst.BlockAddress);
                DataParser.parse(skip(cells, i++), out dst.IP);
                DataParser.parse(skip(cells, i++), out dst.GlobalOffset);
                DataParser.parse(skip(cells, i++), out dst.LocalOffset);
            }

            if(count == AsmStatementDetail.FieldCount)
            {
                dst.OpCode = asm.opcode(skip(cells, i++));
                AsmSyntax.sig(skip(cells, i++), out dst.Sig);
                dst.Expression = asm.statement(skip(cells,i++));
                if(HexByteParser.parse(skip(cells,i++), out var data))
                    dst.Encoded = data;
                else
                    dst.Encoded = AsmHexCode.Empty;
            }
            else
            {
                dst.OpCode = AsmOpCodeExpr.Empty;
                dst.Sig = AsmSigExpr.Empty;
                dst.Expression = AsmStatementExpr.Empty;
                dst.Encoded = AsmHexCode.Empty;
            }

            return (byte)i;
        }

        bool NextRow(out AsmRow row)
        {
            if(CurrentRow < LastRow)
            {
                row = Rows[CurrentRow++];
                var last = CurrentBlock;
                CurrentBlock = row.BlockAddress;
                if(CurrentBlock != last)
                {
                    Symbols.Deposit(last, Blocks.Code(last).Uri.Format());
                }
                return true;
            }
            else
            {
                row = default;
                return false;
            }
        }

        [MethodImpl(Inline)]
        string discriminator(MemoryAddress src)
            => src.Format();

        uint DistillNextSegment()
        {
            var formatter = Tables.formatter<Target>(32);
            var input = default(AsmRow);
            var output = default(Target);
            var counter = 0u;
            var finishing = false;
            if(NextRow(out input))
            {
                var dst = Db.Table<Target>(discriminator(input.IP));
                var flow = Wf.EmittingTable<Target>(dst);
                using var writer = dst.Writer();
                writer.WriteLine(formatter.FormatHeader());
                writer.WriteLine(formatter.Format(Fill(input, ref output)));
                counter++;
                while(NextRow(out input))
                {
                    writer.WriteLine(formatter.Format(Fill(input, ref output)));
                    counter++;
                    if(counter >= MaxLineCount)
                        break;
                }
                Wf.EmittedTable(flow, counter);
            }
            return counter;
        }

        ref Target Fill(in AsmRow src, ref Target dst)
        {
            dst.Sequence = src.Sequence;
            dst.BlockAddress = src.BlockAddress;
            dst.IP = src.IP;
            dst.GlobalOffset = src.GlobalOffset;
            dst.LocalOffset = src.LocalOffset;
            dst.OpCode = src.OpCode;
            AsmSyntax.sig(src.Instruction, out dst.Sig);
            dst.Expression = asm.statement(src.Statement);
            dst.Encoded = src.Encoded;
            return ref dst;
        }
    }
}