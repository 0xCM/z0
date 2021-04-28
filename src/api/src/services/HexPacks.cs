//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    public class HexPacks : AppService<HexPacks>
    {
        [Op]
        public ByteSize Emit(in HexPack src, StreamWriter dst)
        {
            var blocks = src.Blocks;
            var count = blocks.Length;
            var buffer = span<char>(src.MaxBlockSize*2);
            var total = 0u;
            for(var i=0u; i<count;i++)
            {
                buffer.Clear();
                ref readonly var block = ref skip(blocks,i);
                var charcount = Hex.hexpack(block.View, buffer);
                var formatted = text.format(slice(buffer,0, charcount));
                var size = (uint)block.Size;
                dst.WriteLine(string.Format(FormatPattern, block.BaseAddress, i, size, formatted));
                total += size;
            }
            return total;
        }

        [Op]
        public ByteSize Emit(in HexPack src, FS.FilePath dst)
        {
            var flow = Wf.EmittingFile(dst);
            var total = Emit(src, dst.Writer());
            Wf.EmittedFile(flow, (uint)total);
            return total;
        }

        const string FormatPattern = "x{0:x}[{1:D5}:{2:D5}]=<{3}>";
    }
}