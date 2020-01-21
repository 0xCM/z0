//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    public sealed class AsmWriter : StreamWriter
    {
        public AsmWriter(StreamWriter stream)
            : base(stream.BaseStream)
        {

        }

        public AsmWriter(FilePath path, bool append = false)
            : base(path.FullPath, append)
        {

        }

        byte[] Buffer {get; set;}
            = new byte[NativeReader.DefaultBufferLen];

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }

        public AsmWriter Configure(int? buffersize = null)
        {
            if(buffersize != null && Buffer.Length != buffersize)
                Buffer = new byte[buffersize.Value];                
            return this;
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

        public void WriteAsm(AsmFuncInfo f, AsmFormatConfig fmt)
        {
            Write(f.FormatDetail(fmt));
        }

        public void WriteAsm(MethodDisassembly src, AsmFormatConfig fmt)
            => WriteAsm(AsmFunction.define(src),fmt);

        public void WriteAsm(INativeMemberData data, AsmFormatConfig fmt)
            => WriteAsm(AsmFunction.define(data),fmt);

    }
}