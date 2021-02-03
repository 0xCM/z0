//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;


    public ref struct EmitPartImageData
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart Part;

        readonly PartId PartId;

        readonly MemoryAddress BaseAddress;

        readonly FS.FilePath TargetPath;

        readonly FS.FilePath SourcePath;

        MemoryAddress Offset;

        readonly uint BufferSize;

        uint LineCount;

        readonly char LabelDelimiter;

        readonly HexDataFormatter Formatter;

        [MethodImpl(Inline)]
        public EmitPartImageData(IWfShell wf, IPart part)
        {
            Host = WfShell.host(typeof(EmitPartImageData));
            Wf = wf.WithHost(Host);
            Part = part;
            PartId = part.Id;
            BaseAddress = ImageMaps.@base(Part);
            TargetPath = Wf.Db().Table(ImageContent.TableId, PartId);
            BufferSize = ImageContent.RowDataSize;
            Formatter = Hex.formatter(BaseAddress, (ushort)BufferSize);
            Offset = 0;
            LineCount = 0;
            LabelDelimiter = Chars.Pipe;
            SourcePath = FS.path(Part.Owner.Location);
            Wf.Created();
        }


        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            Wf.Running();
            using var stream = SourcePath.Reader();
            using var reader = stream.BinaryReader();
            using var dst = TargetPath.Writer();
            var flow = Wf.EmittingTable<ImageContent>(TargetPath);
            dst.WriteLine(text.concat($"Address".PadRight(12), RP.SpacedPipe, "Data"));

            var buffer = span<byte>(BufferSize);
            var k = Read(reader,buffer);
            while(k != 0)
            {
                dst.WriteLine(Formatter.FormatLine(buffer, Offset, LabelDelimiter));

                Offset += k;
                LineCount++;

                buffer.Clear();
                k = Read(reader, buffer);
            }

            Wf.EmittedTable<ImageContent>(flow, LineCount, TargetPath);
        }

        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset;
        }

        [MethodImpl(Inline)]
        static uint Read(BinaryReader src, Span<byte> dst)
            => (uint)src.Read(dst);
    }
}