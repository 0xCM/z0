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

    using Target = AsmStatementInfo;
    using Source = AsmRow;

    public class AsmDistiller : AsmWfService<AsmDistiller>
    {
        uint MaxLineCount;

        AsmRowProcessor RowProcessor;

        Index<Source> Rows;

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

        protected override void OnContextCreated()
        {
            // RowProcessor = Wf.AsmRowProcessor();
            // CreateIndices();
        }

        // void CreateIndices()
        // {
        //     CurrentRow = 0;
        //     var flow = Wf.Running();
        //     Blocks = Wf.ApiHexIndexer().IndexApiBlocks();
        //     Rows = RowProcessor.CreateAsmRows(Blocks).Where(x => x.IP != 0).OrderBy(x => x.IP).Array();
        //     LastRow = Rows.Count - 1;
        //     CurrentBlock = Rows[CurrentRow].BlockAddress;
        //     Wf.Ran(flow, Rows.Count);
        // }

        bool NextRow(out Source row)
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
            var formatter = Records.formatter<Target>(32);
            var input = default(Source);
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
                    {
                        break;
                    }
                }
                Wf.EmittedTable(flow, counter);
            }
            return counter;
        }

        ref Target Fill(in Source src, ref Target dst)
        {
            dst.Sequence = src.Sequence;
            dst.BlockAddress = src.BlockAddress;
            dst.IP = src.IP;
            dst.GlobalOffset = src.GlobalOffset;
            dst.LocalOffset = src.LocalOffset;
            dst.OpCode = asm.opcode(src.OpCode.Value);
            AsmSigParser.sig(src.Instruction, out dst.Sig);
            dst.Statement = asm.statement(src.Statement);
            dst.Encoded = src.Encoded;
            return ref dst;
        }

        public void DistillStatements()
        {

            DistillStatements(Wf.ApiHexIndexer().IndexApiBlocks());

            // Db.ClearTables<Target>();
            // var flow = Wf.Running();
            // var total = 0u;
            // var count = DistillNextSegment();
            // while(count != 0)
            // {
            //     count = DistillNextSegment();
            //     total += count;
            // }
            // Wf.Ran(flow,total);
        }

        public void DistillStatements(ApiCodeBlocks src)
        {
            var flow = Wf.Running();
            Db.ClearTables<Target>();

            RowProcessor = Wf.AsmRowProcessor();
            CurrentRow = 0;
            Blocks = src;
            Rows = RowProcessor.CreateAsmRows(Blocks).Where(x => x.IP != 0).OrderBy(x => x.IP).Array();
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
    }
}