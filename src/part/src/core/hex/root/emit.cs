//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Linq;

    using static core;

    partial struct Hex
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
                var charcount = charpack(block.View, buffer);
                var formatted = text.format(slice(buffer,0, charcount));
                var size = (uint)block.Size;
                dst.WriteLine(string.Format(HexPackLine, block.BaseAddress, i, size, formatted));
                total += size;
            }
            return total;
        }

        [Op]
        public static ByteSize emit(Index<MemorySeg> src, StreamWriter dst)
        {
            var count = src.Count;
            var bufferSize = src.Select(x => x.Size).Max()*2;
            var buffer = span<char>(bufferSize);
            var total = 0u;
            var segs = src.View;
            for(var i=0u; i<count;i++)
            {
                buffer.Clear();
                ref readonly var seg = ref skip(segs,i);
                var charcount = charpack(seg.View, buffer);
                var formatted = text.format(slice(buffer,0, charcount));
                var size = (uint)seg.Size;
                dst.WriteLine(string.Format(HexPackLine, seg.BaseAddress, i, size, formatted));
                total += size;
            }
            return total;
        }

        [Op]
        public static ByteSize emit(MemorySeg src, uint bpl, StreamWriter dst)
        {
            var div = src.Length/bpl;
            var mod = src.Length % bpl;
            var count = div + (mod != 0 ? 1 : 0);
            var buffer = alloc<MemorySeg>(count);
            ref var target = ref first(buffer);
            var @base = src.BaseAddress;
            var offset = MemoryAddress.Zero;
            for(var i=0; i<div; i++)
            {
                seek(target,i) = new MemorySeg(@base + offset, bpl);
                offset += bpl;
            }
            if(mod !=0)
                seek(target, div) = new MemorySeg(@base + offset, mod);
            return emit(buffer, dst);
        }
    }
}