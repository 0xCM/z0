//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;
    using static z;

    public ref struct EmitImageData
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart Part;

        readonly MemoryAddress BaseAddress;

        readonly FS.FilePath TargetPath;

        readonly FS.FilePath SourcePath;

        MemoryAddress Offset;

        readonly uint BufferSize;

        uint LineCount;

        readonly char LabelDelimiter;

        readonly HexDataFormatter Formatter;

        [MethodImpl(Inline)]
        public EmitImageData(IWfShell wf, WfHost host, IPart part)
        {
            Wf = wf;
            Host = host;
            Part = part;
            BaseAddress = ProcessImages.@base(Part);
            TargetPath = FS.dir((wf.ResourceRoot + FolderName.Define("images")).Name) + FS.file(Part.Format(), FS.ext("csv"));
            Formatter = Formatters.data(BaseAddress);
            Offset = 0;
            LineCount = 0;
            LabelDelimiter = Chars.Pipe;
            BufferSize = 32;
            SourcePath = FS.path(Part.Owner.Location);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Emitting<ImageData>(Host, TargetPath);

            using var stream = SourcePath.Reader();
            using var reader = stream.BinaryReader();
            using var dst = TargetPath.Writer();
            dst.WriteLine(text.concat($"Address".PadRight(12), SpacePipe, "Data"));

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

            Wf.Emitted<ImageData>(Host, LineCount, FS.path(TargetPath.Name));
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