//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct CodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static uint pack(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var j = 0u;
            var count = root.min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst,j++) = Hex.hexchar(LowerCase, b, 1);
                seek(dst,j++) = Hex.hexchar(LowerCase, b, 0);
            }
            return j;
        }

        [Op]
        public static ByteSize pack(ReadOnlySpan<ApiCodeBlock> src, Span<HexPacked> dst, Span<char> buffer)
        {
            var count = (uint)root.min(src.Length, dst.Length);
            var size = 0ul;
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                buffer.Clear();
                ref var package = ref seek(dst,i);
                package.Index = i;
                package.Address = block.BaseAddress;
                package.Size = block.Size;
                package.Data = text.format(slice(buffer,0, pack(block.View, buffer)));
                size += package.Size;
            }
            return size;
        }

        [Op]
        public static ByteSize pack(ReadOnlySpan<ApiCodeBlock> src, Span<HexPacked> dst)
            => pack(src,dst, alloc<char>(48400));

        [Op]
        public static HexPack pack(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<MemoryBlock>(count);
            return pack(src, buffer);
        }

        [Op]
        public static HexPack pack(Index<MemoryBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return HexPack.Empty;
            src.Sort();
            return new HexPack(src, src.Select(x => x.Size).Max());
        }

        [Op]
        public static HexPack pack(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return HexPack.Empty;
            var buffer = alloc<MemoryBlock>(count);

            var max = ByteSize.Zero;
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                seek(dst,i) = memory.block(code.Origin, code.Encoded);
                if(code.Length > max)
                    max = code.Length;
            }

            buffer.Sort();
            return new HexPack(buffer, max);
        }

        [Op]
        public static HexPack pack(ReadOnlySpan<ApiExtractBlock> src, Index<MemoryBlock> buffer)
        {
            var count = src.Length;
            if(count == 0)
                return HexPack.Empty;

            var max = ByteSize.Zero;
            ref var dst = ref buffer.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(src,i);
                var data = extract.Data;
                seek(dst,i) = memory.block(extract.Origin, data);
                if(data.Length > max)
                    max = data.Length;
            }

            buffer.Sort();
            return new HexPack(buffer, max);
        }
    }
}