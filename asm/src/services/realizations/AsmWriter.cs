//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using Z0.AsmSpecs;

    using static zfunc;

    sealed class AsmWriter : StreamWriter, IAsmWriter
    {        
        public static IAsmWriter Create(IAsmContext context, FilePath dst)
            => new AsmWriter(context, dst);
                    
        AsmWriter(IAsmContext context, FilePath path)
            : base(path.FullPath, false)
        {
            this.Context = context;
        }
    
        readonly IAsmContext Context;

        IAsmDecoder Decoder {get;}
            = AsmServices.Decoder();

        byte[] Buffer {get; set;}
            = new byte[NativeReader.DefaultBufferLen];

        public void Write(AsmFunction src)
        {
            var formatter = AsmServices.Formatter(Context);
            formatter.FormatDetail(src);
            Write(formatter.FormatDetail(src));
        }

        public void Write(MemberCapture src)
            => Write(Decoder.DecodeFunction(src));

        public void WriteFileHeader()
        {
            WriteLine($"; {now().ToLexicalString()}");
            WriteLine(Context.AsmFormat.SectionDelimiter);
        }

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }

        public void Write(AsmFunctionGroup src) {}
    }
}