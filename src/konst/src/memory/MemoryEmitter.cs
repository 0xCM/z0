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

    [ApiHost]
    public readonly struct MemoryEmitter
    {
        [Op]
        public static void emit(MemoryRange src, StreamWriter dst)
        {
            const ushort PageSize = 0x1000;
            var buffer = span<byte>(PageSize);
            var pages = (uint)(src.Length/PageSize);
            var reader = memory.reader<byte>(src);
            var offset = 0ul;
            var formatter = HexDataFormatter.create(src.BaseAddress);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            for(var i=0; i<pages; i++)
            {
                var size = reader.Read((int)offset, PageSize, buffer);
                var lines = formatter.FormatLines(slice(buffer,size));
                for(var j =0; j<lines.Length; j++)
                    dst.WriteLine(skip(lines,j));

                if(size < PageSize)
                    break;

                offset += PageSize;
            }
        }

        [Op]
        public static void emit(MemoryRange src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            emit(src,writer);
        }

        [Op]
        public static void emit(MemoryAddress @base, ByteSize size, FS.FilePath dst)
            => emit((@base,  @base + size), dst);
    }
}