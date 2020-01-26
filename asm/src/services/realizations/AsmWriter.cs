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
        public static IAsmWriter Create(FilePath dst, AsmFormatConfig config)
            => new AsmWriter(dst, config);
            
        AsmWriter(StreamWriter stream, AsmFormatConfig config)
            : base(stream.BaseStream)
        {
            this.FormatConfig = config;
        }
    
        AsmWriter(FilePath path, AsmFormatConfig config)
            : base(path.FullPath, false)
        {
            this.FormatConfig = config;
        }

        readonly AsmFormatConfig FormatConfig;

        IAsmDecoder Decoder {get;}
            = AsmServices.Decoder();

        byte[] Buffer {get; set;}
            = new byte[NativeReader.DefaultBufferLen];

        public void Write(AsmFunction src)
        {
            var formatter = AsmServices.Formatter(FormatConfig);
            formatter.FormatDetail(src);
            Write(formatter.FormatDetail(src));
        }

        public void Write(MemberCapture src)
            => Write(Decoder.DecodeFunction(src));

        public void WriteFileHeader()
        {
            WriteLine($"; {now().ToLexicalString()}");
            WriteLine(FormatConfig.SectionDelimiter);
        }

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }

        public void Write(AsmFunctionGroup src) {}
    }
}