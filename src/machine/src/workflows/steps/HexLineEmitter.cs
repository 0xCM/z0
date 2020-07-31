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

    public ref struct HexLineEmitter
    {
        readonly IAppContext Wf;
        
        readonly HexDataFormatter Formatter;
        
        readonly IPart Part;

        readonly FilePath TargetPath;
        
        readonly EmissionDataType DataType;
        
        int LineCount;

        readonly MemoryAddress BaseAddress;

        ulong Offset;

        readonly Span<byte> Buffer;

        bool EmitHeader;

        char LabelDelimiter;

        [MethodImpl(Inline)]
        public HexLineEmitter(IAppContext wf, IPart part, MemoryAddress @base, FilePath dst)
        {
            Wf = wf;
            Part = part;        
            BaseAddress = @base;
            Formatter = HexFormatters.data(BaseAddress);
            DataType = EmissionDataType.PartDat;
            TargetPath = dst;
            Buffer = sys.alloc<byte>(32);
            Offset = 0;
            LineCount = 0;
            EmitHeader = true;
            LabelDelimiter = Chars.Pipe;
            DataType.Emitting(TargetPath, Wf);
        }

        uint Read(BinaryReader reader)
        {
            Buffer.Clear();
            return (uint)reader.Read(Buffer);
        }
        
        public void Run()
        {
            var src = FilePath.Define(Part.Owner.Location);            
            using var stream = src.Reader();
            using var reader = stream.BinaryReader();
            using var dst = TargetPath.Writer();
            if(EmitHeader)
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
        }

        public void Dispose()
        {
            TableEmission.emitted(Wf, DataType, Part.Id, LineCount);
        }

        public MemoryAddress OffsetAddress
        {
            [MethodImpl(Inline)]
            get => Offset + BaseAddress;
        }
    }
}