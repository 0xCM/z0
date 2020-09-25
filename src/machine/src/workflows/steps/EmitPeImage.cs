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

    public ref struct EmitPeImage
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IPart Part;

        readonly MemoryAddress BaseAddress;

        readonly FS.FilePath TargetPath;

        readonly FS.FilePath SourcePath;

        MemoryAddress Offset;

        readonly Span<byte> Buffer;

        readonly uint BufferSize;

        uint LineCount;

        char LabelDelimiter;

        readonly HexDataFormatter Formatter;

        [MethodImpl(Inline)]
        public EmitPeImage(IWfShell wf, WfHost host, IPart part, MemoryAddress @base, FilePath dst)
        {
            Wf = wf;
            Host = host;
            Part = part;
            TargetPath = FS.path(dst.Name);
            BaseAddress = @base;
            Formatter = Formatters.data(BaseAddress);
            Offset = 0;
            LineCount = 0;
            LabelDelimiter = Chars.Pipe;
            BufferSize = 32;
            Buffer = sys.alloc<byte>(BufferSize);
            SourcePath = FS.path(Part.Owner.Location);
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Emitting<BinaryCode>(Host, TargetPath);

            using var stream = SourcePath.Reader();
            using var reader = stream.BinaryReader();
            using var dst = TargetPath.Writer();
            dst.WriteLine(text.concat($"Address".PadRight(12), SpacePipe, "Data"));

            var k = Read(reader);
            while(k != 0)
            {
                dst.WriteLine(Formatter.FormatLine(Buffer, Offset, LabelDelimiter));

                Offset += k;
                LineCount++;

                Buffer.Clear();
                k = Read(reader);
            }

            Wf.Emitted<BinaryCode>(Host, LineCount, FS.path(TargetPath.Name));
        }

        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset;
        }

        uint Read(BinaryReader reader)
        {
            Buffer.Clear();
            return (uint)reader.Read(Buffer);
        }
    }
}