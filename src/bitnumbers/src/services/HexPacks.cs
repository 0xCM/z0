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
    using static Rules;

    [ApiHost]
    public readonly struct HexPacks
    {
        const char SegSep = Chars.Colon;

        const char DataSep = Chars.Eq;

        const string HexPackLine = "x{0:x}[{1:D5}:{2:D5}]=<{3}>";

        static Fence<char> SegFence = ('[',']');

        static Fence<char> DataFence = ('<', '>');

        [Op]
        public static HexPack pack(MemoryBlock src)
            => new HexPack(core.array(src), src.Size);

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
                package.Data = text.format(slice(buffer,0, Hex.charpack(block.View, buffer)));
                size += package.Size;
            }
            return size;
        }

        [Op]
        public static HexPack pack(ReadOnlySpan<ApiExtractBlock> src)
        {
            var count = src.Length;
            var buffer = alloc<MemoryBlock>(count);
            return pack(src, buffer);
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
                seek(dst,i) = memory.memblock(code.Origin, code.Encoded);
                if(code.Length > max)
                    max = code.Length;
            }

            buffer.Sort();
            return new HexPack(buffer, max);
        }

        [Op]
        public static HexPack pack(ReadOnlySpan<ApiMemberExtract> src)
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
                var encoded = code.Block.Encoded;
                seek(dst,i) = memory.memblock(code.Origin, encoded);
                if(encoded.Length > max)
                    max = encoded.Length;
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
                seek(dst,i) = memory.memblock(extract.Origin, data);
                if(data.Length > max)
                    max = data.Length;
            }

            buffer.Sort();
            return new HexPack(buffer, max);
        }

        [MethodImpl(Inline), Op]
        public static uint charpack(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var j = 0u;
            var count = min(src.Length, dst.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst,j++) = Hex.hexchar(LowerCase, b, 1);
                seek(dst,j++) = Hex.hexchar(LowerCase, b, 0);
            }
            return j;
        }

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

        public static Outcome<HexPack> load(FS.FilePath src)
        {
            var result = default(Outcome<HexPack>);
            var unpacked = default(Outcome<ByteSize>);
            var size  = ByteSize.Zero;
            var lines = list<MemoryBlock>();
            var counter = z16;
            using var reader = src.Reader();
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

            return result;
        }

        public static Outcome<ByteSize> unpack(ushort index, string src, out MemoryBlock dst)
        {
            var count = src.Length;
            var line = index + 1;
            dst = default;
            if(count == 0)
            {
                dst = MemoryBlock.Empty;
                return ByteSize.Zero;
            }

            if(first(src) != 'x')
                return(false,$"Line {line} does not begin with the required character 'x'");

            var i = src.IndexOf('h');
            if(i == NotFound)
                return(false, $"Line {line} does not contain address terminator 'h'");

            var parsed = DataParser.parse(text.slice(src, 1, i-1), out MemoryAddress @base);
            if(parsed.Fail)
                return parsed;

            if(!text.unfence(src, SegFence, out var seg))
                return (false, $"Line {line} does not contain segment fence");

            if(!text.unfence(src, DataFence, out var data))
                return (false, $"Line {line} does not contain data fence");

            var segparts = text.split(src,SegSep);
            if(segparts.Length != 2)
                return (false, $"Line {line} segement specifier does not have the required 2 components");

            DataParser.parse(segparts[0], out ushort segidx);
            if(segidx != index)
                return (false, $"Line {line} number does not correspond to the segement index");

            DataParser.parse(segparts[1], out ByteSize segsize);

            DataParser.parse(data, out BinaryCode code);
            if(code.IsEmpty)
                return (false, $"Line {line} contains no data");

            dst = new MemoryBlock(@base, segsize, code);

            return segsize;
        }

        static Outcome<ByteSize> unpack_fast(uint index, ReadOnlySpan<char> src, out MemoryBlock dst)
        {
            var result = Outcome.Success;
            var count = src.Length;
            if(count == 0)
            {
                dst = MemoryBlock.Empty;
                return ByteSize.Zero;
            }

            dst = default;
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                var origin =new MemoryRange(MemoryAddress.Zero,ByteSize.Zero);

                if(i==0)
                {
                    if(c != 'x')
                    {
                        result = (false,$"Line {index + 1} does not begin with the required character 'x'");
                        return result;
                    }
                }
                else
                {
                    if(i==1)
                    {
                        var buffer = CharBlock16.Null.Data;
                        var max = buffer.Length;
                        var j=0;
                        while(j < max)
                        {
                            ref readonly var a = ref skip(src, i++);
                            if(a != 'h')
                                seek(buffer, j++) = a;
                            else
                                break;
                        }

                        var @base = 0ul;
                        var size = Hex.parse(slice(buffer,0,j), bytes(@base));
                        if(size != 0)
                        {
                            origin = new MemoryRange(@base, ByteSize.Zero);
                        }


                        //var number = slice(address,0,j);

                    }
                }
            }


            return result;

        }

        [Op]
        public static string linepack(in MemorySeg src, uint index, Span<char> buffer)
        {
            var memspan = src.ToSpan();
            var count = charpack(memspan.View, buffer);
            var chars = slice(buffer, 0, count);
            return string.Format(HexPackLine, memspan.BaseAddress, index, memspan.Size, text.format(chars));
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