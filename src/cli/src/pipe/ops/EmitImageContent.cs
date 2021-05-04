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

    using static memory;
    using static Part;
    using static ImageRecords;

    partial class ImageMetaPipe
    {
        public void ClearImageContent()
        {
            var dir = Db.TableDir<ImageContent>();
            var flow = Wf.Running($"Clearing content from <{dir}>");
            var dst = root.list<FS.FilePath>();
            dir.Clear(dst);
            Wf.Ran(flow, $"Cleared <{dst.Count}> files from <{dir}>");
        }

        public void EmitImageContent()
        {
            var flow = Wf.Running();
            var pipe = Wf.ProcessContextPipe();
            ClearImageContent();
            root.iter(Wf.ApiCatalog.Components, c => EmitImageContent(c));
            Wf.Ran(flow);
        }

        [Op]
        public MemoryRange EmitImageContent(Assembly src)
        {
            var rowsize = ImageContent.RowDataSize;
            var dst = Db.Table(ImageContent.TableId, src.GetSimpleName());
            var flow = Wf.EmittingTable<ImageContent>(dst);
            var @base = ImageMemory.@base(src);
            var formatter = HexFormat.DataFormatter(@base, rowsize);
            var path = FS.path(src.Location);
            using var stream = path.Reader();
            using var reader = stream.BinaryReader();
            using var writer = dst.Writer();
            writer.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));
            var buffer = alloc<byte>(rowsize);
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

            Wf.EmittedTable<ImageContent>(flow, lines);
            return (@base, @base + offset);
        }

        [MethodImpl(Inline), Op]
        uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);
    }
}