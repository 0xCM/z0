//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    sealed class AsmWriter : StreamWriter, IAsmWriter
    {
        public AsmWriter(StreamWriter stream)
            : base(stream.BaseStream)
        {

        }

        public AsmWriter(FilePath path, bool append = false)
            : base(path.FullPath, append)
        {

        }

        IAsmFunctionBuilder Builder {get;}
            = AsmServices.FunctionBuilder();

        byte[] Buffer {get; set;}
            = new byte[NativeReader.DefaultBufferLen];

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }

        public void Configure(int? buffersize = null)
        {
            if(buffersize != null && Buffer.Length != buffersize)
                Buffer = new byte[buffersize.Value];                
        }

        /// <summary>
        /// Writes a standard timestamped header
        /// </summary>
        public void WriteHeader(AsmFormatConfig fmt)
        {
            WriteLine(AsmFormat.Comment(now().ToLexicalString()));
            WriteSeparator(fmt);
        }

        public void WriteSeparator(AsmFormatConfig fmt)
        {
            WriteLine(fmt.FunctionDelimiter);

        }

        public void WriteFunction(AsmFunction src, AsmFormatConfig fmt)
        {
            Write(src.FormatDetail(fmt));
        }

        public void WriteFunction(NativeMemberCapture src, AsmFormatConfig fmt)
            => WriteFunction(AsmDecoder.function(src),fmt);

    }
}