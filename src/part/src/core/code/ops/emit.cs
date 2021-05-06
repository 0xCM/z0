//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    partial struct CodeBlocks
    {
        [Op]
        public static ByteSize emit(in HexPack src, StreamWriter dst)
        {
            var blocks = src.Blocks;
            var count = blocks.Length;
            var buffer = span<char>(src.MaxBlockSize*2);
            var total = 0u;
            for(var i=0u; i<count;i++)
            {
                buffer.Clear();
                ref readonly var block = ref skip(blocks,i);
                var charcount = hexchars(block.View, buffer);
                var formatted = text.format(slice(buffer,0, charcount));
                var size = (uint)block.Size;
                dst.WriteLine(string.Format(HexPackLine, block.BaseAddress, i, size, formatted));
                total += size;
            }
            return total;
        }
    }
}