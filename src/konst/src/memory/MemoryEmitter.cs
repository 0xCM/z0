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
    using static Part;

    [ApiHost]
    public readonly struct MemoryEmitter : IWfStateless<MemoryEmitter>
    {
        public IWfShell Wf {get;}

        [MethodImpl(Inline)]
        public static MemoryEmitter create(IWfShell wf)
            => new MemoryEmitter(wf);

        [MethodImpl(Inline)]
        MemoryEmitter(IWfShell wf)
            => Wf = wf;

        public void Emit2(MemoryRange src, StreamWriter dst)
        {
            var formatter = HexDataFormatter.create(src.Min, 40);
            var data = memory.cover<byte>(src.Min, src.Size);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            formatter.FormatLines(data, line => dst.WriteLine(line));
        }

        [Op]
        public void Emit2(MemoryRange src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            Emit2(src, writer);
        }

        [Op]
        public void Emit2(MemoryAddress @base, ByteSize size, FS.FilePath dst)
            => Emit2((@base,  @base + size), dst);

        [Op]
        public void Emit(MemoryRange src, StreamWriter dst)
        {
            const ushort PageSize = 0x1000;

            var buffer = span<byte>(PageSize);
            var pages = (uint)(src.Size/PageSize);
            var reader = memory.reader<byte>(src);
            var offset = 0ul;
            var @base = src.Min;

            Wf.Status($"Length = {src.Size}, Pages={pages}, Base={@base}, End = {src.Max}");

            var formatter = HexDataFormatter.create(@base);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            for(var i=0; i<pages; i++)
            {
                var size = reader.Read((int)offset, PageSize, buffer);
                var lines = formatter.FormatLines(slice(buffer, size));
                for(var j =0; j<lines.Length; j++)
                    dst.WriteLine(skip(lines,j));

                offset += PageSize;

                if(size < PageSize || offset >= src.Size)
                    break;
            }
        }

        [Op]
        public void Emit(MemoryRange src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            Emit(src,writer);
        }

        [Op]
        public void Emit(MemoryAddress @base, ByteSize size, FS.FilePath dst)
            => Emit((@base,  @base + size), dst);
    }
}