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

    public ref struct AsmBlockInfo
    {
        ReadOnlySpan<AsmRow> Rows {get;}

        ReadOnlySpan<AsmStatementInfo> Statements {get;}

        public ApiCodeBlock Code {get;}

        public AsmBlockInfo(ReadOnlySpan<AsmRow> rows, ApiCodeBlock code, ReadOnlySpan<AsmStatementInfo> statements)
        {
            Rows = rows;
            Code = code;
            Statements = statements;
        }

        public uint RowCount
        {
            [MethodImpl(Inline)]
            get => (uint)Rows.Length;
        }

        public OpUri OpUri
        {
            [MethodImpl(Inline)]
            get => Code.OpUri;
        }

        [MethodImpl(Inline)]
        public ref readonly AsmStatementInfo Statement(ushort index)
            => ref skip(Statements,index);

        [MethodImpl(Inline)]
        public ref readonly AsmRow Row(ushort index)
            => ref skip(Rows,index);

    }

    public class AsmBlockReader : AsmWfService<AsmBlockReader>
    {
        Index<AsmRow> Rows;

        Index<ApiCodeBlock> Blocks;

        uint CurrentRow;

        uint LastRow;

        uint CurrentBlock;

        uint LastBlock;

        ApiIndexMetrics Metrics;

        public AsmBlockInfo NextBlock()
        {
            if(CurrentBlock < LastBlock)
            {
                ref readonly var row = ref Rows[CurrentRow];
                ref readonly var block = ref Blocks[CurrentBlock];
                var statements = root.list<AsmStatementInfo>();
                var @base = row.BlockAddress;
                var address = @base;
                var i = CurrentRow;
                while(address == @base && i<LastRow)
                {
                    var _row = skip(row, i++);
                    address = _row.BlockAddress;
                    var statement = default(AsmStatementInfo);
                    Fill(_row, ref statement);
                    statements.Add(statement);
                }

                var next = slice(Rows.View, CurrentRow, i);
                CurrentRow = i;
                CurrentBlock++;
                return new AsmBlockInfo(next, block, statements.ToArray());
            }
            else
                return default;
        }

        public bool NextBlock(out AsmBlockInfo block)
        {
            if(CurrentBlock < LastBlock)
            {
                block = NextBlock();
                return true;
            }
            else
            {
                block = default;
                return false;
            }
        }

        public AsmBlockReader WithBlocks(ApiCodeBlocks src)
        {
            CurrentRow = 0;
            CurrentBlock = 0;
            Blocks = src.Blocks.OrderBy(x => x.BaseAddress).Array();
            Metrics = src.CalcMetrics();
            var processor = Wf.AsmRowProcessor();
            Rows = AsmEtl.resequence(processor.CreateAsmRows(Blocks).OrderBy(x => x.IP).Array());
            LastRow = Rows.Count - 1;
            LastBlock = Blocks.Count - 1;
            return this;
        }


        ref AsmStatementInfo Fill(in AsmRow src, ref AsmStatementInfo dst)
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
    }
}