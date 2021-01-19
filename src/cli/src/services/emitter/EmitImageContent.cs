//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;
    using System.Reflection;

    using static Part;
    using static memory;

    partial class ImageDataEmitter
    {
        public MemoryRange EmitImageContent(Assembly src)
        {
            var dst = Wf.Db().Table(ImageContent.TableId, src.GetSimpleName());
            var flow = Wf.EmittingTable<ImageContent>(dst);
            var @base = ImageMaps.@base(src);
            var formatter = Hex.formatter(@base);
            var path = FS.path(src.Location);
            using var stream = path.Reader();
            using var reader = stream.BinaryReader();
            using var writer = dst.Writer();
            writer.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            var buffer = span<byte>(ImageContent.RowDataSize);
            var k = Read(reader, buffer);
            var offset = MemoryAddress.Zero;
            var lines = 0;
            while(k != 0)
            {
                writer.WriteLine(formatter.FormatLine(buffer, offset, Chars.Pipe));

                offset += k;
                lines++;

                buffer.Clear();
                k = Read(reader, buffer);
            }

            Wf.EmittedTable<ImageContent>(flow, lines, dst);
            return (@base, @base + offset);
        }

        [MethodImpl(Inline)]
        static uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);
    }
}