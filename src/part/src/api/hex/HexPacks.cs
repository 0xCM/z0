//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Linq;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct HexPacks
    {
        const char SegSep = Chars.Colon;

        const string HexPackLine = "x{0:x}[{1:D5}:{2:D5}]=<{3}>";

        const string ArrayPackLine = "x{0:x}[{1:D5}:{2:D5}]={3}";

        static Fence<char> SegFence = ('[',']');

        static Fence<char> DataFence = ('<', '>');

        [Op]
        public static MemoryBlocks pack(MemoryBlock src)
            => new MemoryBlocks(core.array(src));

        [Op]
        public static MemoryBlocks pack(Index<MemoryBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return MemoryBlocks.Empty;
            src.Sort();
            return new MemoryBlocks(src);
        }

        [Op]
        public static ByteSize pack(ReadOnlySpan<ApiCodeBlock> src, Span<HexPacked> dst, Span<char> buffer)
        {
            var count = (uint)min(src.Length, dst.Length);
            var size = 0ul;
            for(var i=0u; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                buffer.Clear();
                ref var package = ref seek(dst,i);
                package.Index = i;
                package.Address = block.BaseAddress;
                package.Size = block.Size;
                package.Data = text.format(slice(buffer,0, Hex.charpack(block.View, buffer)));
                size += package.Size;
            }
            return size;
        }

        [Op]
        public static MemoryBlocks pack(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<MemoryBlock>(count);
            return pack(src, buffer);
        }

        [Op]
        public static MemoryBlocks pack(ReadOnlySpan<ApiCodeBlock> src)
        {
            var count = src.Length;
            if(count == 0)
                return MemoryBlocks.Empty;
            var buffer = alloc<MemoryBlock>(count);

            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                seek(dst,i) = new MemoryBlock(code.Origin, code.Encoded);
            }

            buffer.Sort();
            return new MemoryBlocks(buffer);
        }

        [Op]
        public static MemoryBlocks pack(ReadOnlySpan<ApiMemberExtract> src)
        {
            var count = src.Length;
            if(count == 0)
                return MemoryBlocks.Empty;
            var buffer = alloc<MemoryBlock>(count);

            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var code = ref skip(src,i);
                var encoded = code.Block.Encoded;
                seek(dst,i) = new MemoryBlock(code.Origin, encoded);
            }

            buffer.Sort();
            return new MemoryBlocks(buffer);
        }

        [Op]
        public static MemoryBlocks pack(ReadOnlySpan<ApiExtractBlock> src, Index<MemoryBlock> buffer)
        {
            var count = src.Length;
            if(count == 0)
                return MemoryBlocks.Empty;

            ref var dst = ref buffer.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var extract = ref skip(src,i);
                var data = extract.Data;
                seek(dst,i) = new MemoryBlock(extract.Origin, data);
            }

            buffer.Sort();
            return new MemoryBlocks(buffer);
        }

        // [MethodImpl(Inline), Op]
        // public static uint charpack(ReadOnlySpan<byte> src, Span<char> dst)
        // {
        //     var j = 0u;
        //     var count = min(src.Length, dst.Length);
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var b = ref skip(src,i);
        //         seek(dst,j++) = Hex.hexchar(LowerCase, b, 1);
        //         seek(dst,j++) = Hex.hexchar(LowerCase, b, 0);
        //     }
        //     return j;
        // }

        [Op]
        public static ByteSize emit(in MemoryBlocks src, StreamWriter dst)
        {
            var blocks = src.View;
            var maxsz = Buffers.maxblock(blocks).Size;
            var count = blocks.Length;
            var buffer = span<char>(maxsz*2);
            var total = 0u;
            for(var i=0u; i<count;i++)
            {
                buffer.Clear();
                ref readonly var block = ref skip(blocks,i);
                var charcount = Hex.charpack(block.View, buffer);
                var formatted = text.format(slice(buffer,0, charcount));
                var size = (uint)block.Size;
                dst.WriteLine(string.Format(HexPackLine, block.BaseAddress, i, size, formatted));
                total += size;
            }
            return total;
        }

        public static Outcome load(FS.FilePath src, out MemoryBlocks dst)
        {
            var result = Outcome<MemoryBlocks>.Success;
            var unpacked = Outcome<ByteSize>.Success;
            var size  = ByteSize.Zero;
            var lines = list<MemoryBlock>();
            var counter = z16;
            using var reader = src.AsciReader();
            var data = reader.ReadLine();
            while(result.Ok && text.nonempty(data))
            {
                unpacked = unpack(counter++, data, out var block);
                if(unpacked.Fail)
                    result = (false, unpacked.Message);
                else
                {
                    lines.Add(block);
                    size += unpacked.Data;
                    data = reader.ReadLine();
                }
            }

            if(result.Fail)
                return result;

            dst = new MemoryBlocks(lines.ToArray());
            return true;
        }

        public static Outcome<ByteSize> unpack(ushort index, string src, out MemoryBlock dst)
        {
            var count = src.Length;
            var line = index + 1;
            var result = Outcome.Success;
            dst = default;
            if(count == 0)
            {
                dst = MemoryBlock.Empty;
                return (false, "The input, it is empty");
            }

            if(first(src) != 'x')
                return(false, $"Line {src} does not begin with the required character 'x'");

            var i = src.IndexOf('h');
            if(i == NotFound)
                return(false, $"Line {src} does not contain address terminator 'h'");

            result = DataParser.parse(text.slice(src, 1, i-1), out MemoryAddress @base);
            if(result.Fail)
                return (false, $"{result.Message} | Could not parse address from '{src}'");

            if(!text.unfence(src, SegFence, out var seg))
                return (false, $"Line {src} does not contain segment fence");

            if(!text.unfence(src, DataFence, out var data))
                return (false, $"Line {src} does not contain data fence");

            var segparts = text.split(seg, SegSep);
            if(segparts.Length != 2)
                return (false, $"Line {src} segement specifier does not have the required 2 components");

            var segLeft = skip(segparts,0);
            DataParser.parse(segLeft, out ushort segidx);
            if(segidx != index)
                return (false, $"Line {line} number does not correspond to the segement index {segidx}");

            var segRight = skip(segparts,1);
            result = DataParser.parse(segRight, out ByteSize segsize);
            if(result.Fail)
                return (false, $"{result.Message} | Could not parse segment size from {segRight}");

            result = parse(data, out BinaryCode code);

            if(result.Fail)
                return (false, $"{result.Message} | Could not parse code from {data}");

            if(code.IsEmpty)
                return (false, $"Line {src} contains no data");

            if(segsize != code.Length)
                return (false, $"Expected {segsize} bytes but parsed {code.Length}");

            dst = new MemoryBlock(@base, segsize, code);

            return segsize;
        }

        public static Outcome parse(string src, out BinaryCode dst)
        {
            var result = Outcome.Success;
            var count = text.length(src);
            if(count % 2 != 0)
                return (false, UnevenNibbles.Format(src));
            var size = count/2;
            var buffer = alloc<byte>(size);
            var input = span(src);
            ref var output = ref first(buffer);
            for(int i=0, j=0; i<count; i+=2, j++)
            {
                result = Hex.parse(skip(input,i), skip(input, i+1), out seek(output, j));
                if(result.Fail)
                {
                    dst = BinaryCode.Empty;
                    return result;
                }
            }

            dst = buffer;
            return true;
        }

        [Op]
        public static string linepack(in MemorySeg src, uint index, Span<char> buffer)
        {
            var memspan = src.ToSpan();
            var count = Hex.charpack(memspan.View, buffer);
            var chars = slice(buffer, 0, count);
            return string.Format(HexPackLine, memspan.BaseAddress, index, (uint)memspan.Size, text.format(chars));
        }

        [Op]
        public static string arraypack(in MemorySeg src, uint index, Span<char> buffer)
        {
            var memory = src.ToSpan();
            var count = Hex.hexarray(memory.View, buffer);
            var chars = slice(buffer, 0, count);
            return string.Format(ArrayPackLine, memory.BaseAddress, index, (uint)memory.Size, text.format(chars));
        }

        [Op]
        public static string arraypack(in MemoryBlock src, uint index, Span<char> buffer)
        {
            var memory = src.View;
            var count = Hex.hexarray(memory, buffer);
            var chars = slice(buffer, 0, count);
            return string.Format(ArrayPackLine, src.BaseAddress, index, (uint)src.Size, text.format(chars));
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
                var charcount = Hex.charpack(seg.View, buffer);
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

        static MsgPattern<string> UnevenNibbles => "An even number of nibbles was not provided in the source text '{0}'";
    }
}