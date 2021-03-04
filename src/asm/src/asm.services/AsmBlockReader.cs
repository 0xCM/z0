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

    public class AsmBlockReader : AsmWfService<AsmBlockReader>
    {
        Index<Source> Rows;

        ApiCodeBlocks Blocks;

        uint CurrentRow;

        uint LastRow;

        uint CurrentBlock;

        uint LastBlock;

        ApiIndexMetrics Metrics;

        public ReadOnlySpan<Source> NextBlock()
        {
            if(CurrentBlock < LastBlock)
            {
                ref readonly var row = ref Rows[CurrentRow];
                var @base = row.BlockAddress;
                var address = @base;
                var i = CurrentRow;
                while(address == @base && i<LastRow)
                    address = skip(row, i++).BlockAddress;

                var next = slice(Rows.View, CurrentRow, i);
                CurrentRow = i;
                CurrentBlock++;
                return next;

            }
            else
                return default;
        }

        public bool NextBlock(out ReadOnlySpan<Source> block)
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
            Blocks = src;
            Metrics = Blocks.CalcMetrics();
            var processor = Wf.AsmRowProcessor();
            Rows = AsmEtl.resequence(processor.CreateAsmRows(Blocks).OrderBy(x => x.IP).Array());
            LastRow = Rows.Count - 1;
            LastBlock = Blocks.BlockCount - 1;
            return this;
        }
    }
}