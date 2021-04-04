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
        public void ClearApiImageContent()
        {
            var dir = Db.TableDir<ImageContent>();
            var flow = Wf.Running($"Clearing content from <{dir}>");
            var dst = root.list<FS.FilePath>();
            dir.Clear(dst);
            Wf.Ran(flow, $"Cleared <{dst.Count}> files from <{dir}>");
        }

        public void EmitApiImageContent()
        {
            var flow = Wf.Running();
            ClearApiImageContent();
            root.iter(Wf.Api.PartComponents, c => EmitImageContent(c));
            Wf.Ran(flow);
        }

        public MemoryRange EmitImageContent(Assembly src)
        {
            var rowsize = ImageContent.RowDataSize;
            var dst = Db.Table(ImageContent.TableId, src.GetSimpleName());
            var flow = Wf.EmittingTable<ImageContent>(dst);
            var @base = ImageMaps.@base(src);
            var formatter = HexFormats.data(@base, rowsize);
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

        [MethodImpl(Inline)]
        uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);
    }
}