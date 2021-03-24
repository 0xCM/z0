//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static memory;

    using W = AsmRowFieldWidth;

    public class AsmRowProcessor : WfService<AsmRowProcessor>
    {
        public Index<AsmRow> CreateAsmRows()
        {
            var blocks = Wf.ApiHexIndexer().IndexApiBlocks();
            return CreateAsmRows(blocks);
        }

        public Index<AsmRow> CreateAsmRows(ApiCodeBlocks blocks)
            => Wf.AsmDataStore().CreateAsmRows(blocks);

        public Index<AsmRow> CreateAsmRows(Index<ApiCodeBlock> blocks)
            => Wf.AsmDataStore().CreateAsmRows(blocks);

        public uint Emit(Index<AsmRow> src, FS.FilePath dst)
        {
            var count = src.Count;
            var view = src.View;
            var flow = Wf.EmittingTable<AsmRow>(dst);
            var header = Datasets.header53<AsmRowField>();
            using var writer = dst.Writer();
            writer.WriteLine(header);
            var buffer = text.buffer();
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                render(record, buffer);
                writer.WriteLine(buffer.Emit());
            }
            Wf.EmittedTable(flow, count);
            return count;
        }

        [Op]
        static void render(in AsmRow src, ITextBuffer dst)
        {   const string delimiter = "| ";
            dst.AppendPadded(src.Sequence, W.Sequence, delimiter);
            dst.AppendPadded(src.BlockAddress, W.BlockAddress, delimiter);
            dst.AppendPadded(src.IP, W.IP, delimiter);
            dst.AppendPadded(src.GlobalOffset, W.GlobalOffset, delimiter);
            dst.AppendPadded(src.LocalOffset, W.LocalOffset, delimiter);
            dst.AppendPadded(src.Mnemonic, W.Mnemonic, delimiter);
            dst.AppendPadded(src.OpCode, W.OpCode, delimiter);
            dst.AppendPadded(src.Instruction, W.Instruction, delimiter);
            dst.AppendPadded(src.Statement, W.Statement, delimiter);
            dst.AppendPadded(src.Encoded, W.Encoded, delimiter);
            dst.AppendPadded(src.CpuId, W.CpuId, delimiter);
            dst.AppendPadded(src.OpCodeId, W.OpCodeId, delimiter);
        }
    }
}