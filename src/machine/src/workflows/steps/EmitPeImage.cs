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
    using static EmitPeImageStep;

    public ref struct EmitPeImage
    {
        readonly IWfShell Wf;

        readonly CorrelationToken Ct;

        readonly IPart Part;

        readonly MemoryAddress BaseAddress;

        readonly FilePath TargetPath;

        readonly FilePath SourcePath;

        MemoryAddress Offset;

        readonly Span<byte> Buffer;

        readonly uint BufferSize;

        uint LineCount;

        char LabelDelimiter;

        readonly HexDataFormatter Formatter;

        [MethodImpl(Inline)]
        public EmitPeImage(IWfShell wf, IPart part, MemoryAddress @base, FilePath dst, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Part = part;
            TargetPath = dst;
            BaseAddress = @base;
            Formatter = Formatters.data(BaseAddress);
            Offset = 0;
            LineCount = 0;
            LabelDelimiter = Chars.Pipe;
            BufferSize = 32;
            Buffer = sys.alloc<byte>(BufferSize);
            SourcePath = FilePath.Define(Part.Owner.Location);
            Wf.Created(StepId);
        }

        public void Run()
        {
            Wf.Emitting(StepId, DatasetName, TargetPath);

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

            Wf.Emitted(StepId, DatasetName, LineCount, TargetPath);

        }

        public void Dispose()
        {
            Wf.Finished(StepId);
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