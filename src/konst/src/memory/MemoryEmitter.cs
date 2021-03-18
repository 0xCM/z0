//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static memory;

    [Service(typeof(IMemoryEmitter))]
    public class MemoryEmitter : WfService<MemoryEmitter>, IMemoryEmitter
    {
        public void Emit(MemoryRange src, StreamWriter dst, byte bpl = 40)
        {
            var formatter = HexDataFormatter.create(src.Min, bpl);
            var data = memory.cover<byte>(src.Min, src.Size);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            formatter.FormatLines(data, line => dst.WriteLine(line));
        }

        public void Emit(MemoryRange src, FS.FilePath dst, byte bpl = 40)
        {
            using var writer = dst.Writer();
            Emit(src, writer, bpl);
        }

        public void Emit(MemoryAddress @base, ByteSize size, FS.FilePath dst, byte bpl = 40)
            => Emit((@base,  @base + size), dst, bpl);

        public unsafe void EmitPaged(MemoryRange src, StreamWriter dst, byte bpl = 40)
        {
            memory.liberate(src);
            var buffer = span<byte>(PageSize);
            var pages = (uint)(src.Size/PageSize);
            var reader = memory.reader<byte>(src);
            var offset = 0ul;
            var @base = src.Min;

            Wf.Status($"Length = {src.Size} | Pages={pages} | Base={src.Min} | End = {src.Max}");

            var formatter = HexDataFormatter.create(src.Min, bpl);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            for(var i=0; i<pages; i++)
            {
                var size = reader.Read((int)offset, PageSize, buffer);
                Wf.Babble($"Read {size} bytes");
                var content = slice(buffer, size);
                var lines = formatter.FormatLines(content);
                var kLines = lines.Length;
                for(var j =0; j<kLines; j++)
                    dst.WriteLine(skip(lines,j));

                offset += PageSize;

                if(size < PageSize || offset >= src.Size)
                    break;
            }
        }

        public void EmitPaged(MemoryRange src, FS.FilePath dst, byte bpl = 40)
        {
            using var writer = dst.Writer();
            EmitPaged(src,writer, bpl);
        }

        public void EmitPaged(MemoryAddress @base, ByteSize size, FS.FilePath dst, byte bpl = 40)
            => EmitPaged((@base,  @base + size), dst, bpl);
    }
}