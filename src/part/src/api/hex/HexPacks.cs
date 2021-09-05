//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost, Actor]
    public readonly struct HexPacks
    {
        const char SegSep = Chars.Colon;

        static Fence<char> SegFence = ('[',']');

        static Fence<char> DataFence = ('<', '>');

        [Flow]
        public static MemoryBlocks blocks(ReadOnlySpan<ApiMemberExtract> src)
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

        [MethodImpl(Inline), Flow]
        public static MemoryBlock block(in ApiMemberExtract src)
            => new MemoryBlock(src.Block.Origin, src.Block.Encoded);

        [Load]
        public static Outcome load(FS.FilePath src, out MemoryBlocks dst)
        {
            var result = Outcome<MemoryBlocks>.Success;
            var unpacked = Outcome<ByteSize>.Success;
            var size  = ByteSize.Zero;
            var buffer = list<MemoryBlock>();
            var counter = z16;
            using var reader = src.AsciReader();
            var data = reader.ReadLine();
            while(result.Ok && text.nonempty(data))
            {
                unpacked = parse(counter++, data, out var block);
                if(unpacked.Fail)
                    result = (false, unpacked.Message);
                else
                {
                    buffer.Add(block);
                    size += unpacked.Data;
                    data = reader.ReadLine();
                }
            }

            if(result.Fail)
                return result;

            dst = new MemoryBlocks(buffer.ToArray());
            return true;
        }

        static Outcome<ByteSize> parse(ushort index, string src, out MemoryBlock dst)
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

            result = AddressParser.parse(text.slice(src, 1, i-1), out MemoryAddress @base);
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
            NumericParser.parse(segLeft, out ushort segidx);
            if(segidx != index)
                return (false, $"Line {line} number does not correspond to the segement index {segidx}");

            var segRight = skip(segparts,1);
            result = Sizes.parse(segRight, out ByteSize segsize);
            if(result.Fail)
                return (false, $"{result.Message} | Could not parse segment size from {segRight}");

            result = Hex.parse(data, out BinaryCode code);

            if(result.Fail)
                return (false, $"{result.Message} | Could not parse code from {data}");

            if(code.IsEmpty)
                return (false, $"Line {src} contains no data");

            if(segsize != code.Length)
                return (false, $"Expected {segsize} bytes but parsed {code.Length}");

            dst = new MemoryBlock(@base, segsize, code);

            return segsize;
        }
    }
}