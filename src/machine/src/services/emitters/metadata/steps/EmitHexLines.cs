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

    public ref struct EmitHexLines
    {
        readonly IWfPartEmission Wf;
        
        readonly HexDataFormatter Formatter;
        
        readonly IPart Part;

        readonly FilePath TargetPath;
        
        readonly EmissionDataType DataType;
        
        int LineCount;

        uint Offset;

        readonly Span<byte> Buffer;

        [MethodImpl(Inline)]
        public EmitHexLines(IWfPartEmission wf, IPart part)
        {
            Wf = wf;
            Part = part;        
            Formatter = HexFormatters.data();
            DataType = EmissionDataType.HexLine;
            TargetPath = Wf.TargetPath(part.Id, DataType);
            Buffer = sys.alloc<byte>(32);
            Offset = 0;
            LineCount = 0;
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
            var k = Read(reader);
            while(k != 0)
            {
                dst.WriteLine(Formatter.FormatLine(Buffer, Offset));
                
                Offset += k;
                LineCount++;

                Buffer.Clear();
                k = Read(reader);
            }
        
        }

        public void Dispose()
        {
            DataEmitters.emitted(Wf, DataType, Part.Id, LineCount);
        }
    }
}