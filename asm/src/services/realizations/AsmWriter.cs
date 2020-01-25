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
        
        public AsmWriter(StreamWriter stream)
            : base(stream.BaseStream)
        {

        }

        public AsmWriter(FilePath path)
            : base(path.FullPath, false)
        {

        }

        IAsmDecoder Decoder {get;}
            = AsmServices.Decoder();

        byte[] Buffer {get; set;}
            = new byte[NativeReader.DefaultBufferLen];

        public void WriteFunction(AsmFunction src, AsmFormatConfig config)
        {
            var formatter = AsmServices.Formatter(config);
            formatter.FormatDetail(src);
            Write(formatter.FormatDetail(src));
        }

        public void WriteFunction(MemberCapture src, AsmFormatConfig config)
            => WriteFunction(Decoder.DecodeFunction(src),config);

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }
    }
}