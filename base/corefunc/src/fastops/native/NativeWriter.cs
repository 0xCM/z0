//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    public class NativeWriter : StreamWriter, INativeWriter
    {
        public static INativeWriter Create(FilePath dst, bool append = false)
            => new NativeWriter(dst,append);

        public NativeWriter(FilePath path, bool append = false)
            : base(path.FullPath, append)
        {

        }

        public int BytesPerLine {get; private set;}
            = 4;

        public bool LineLabels {get; private set;}
            = true;

        byte[] Buffer {get; set;}
            = new byte[NativeServices.DefaultBufferLen];

        public byte[] TakeBuffer()
        {
            Buffer.Clear();
            return Buffer;
        }

        /// <summary>
        /// Writes a standard timestamped header
        /// </summary>
        public virtual void WriteHeader()
        {
            WriteLine($"; {now().ToLexicalString()}");
            WriteLine(new string(AsciSym.Dash, 80));
        }

        public void WriteData(MemberCapture src, NativeFormatConfig config)
        {
            Write(src.Format(config));                            
        }

        public void WriteData(MemberCapture src)
        {
            Write(src.Format(null));                            
        }
    }
}