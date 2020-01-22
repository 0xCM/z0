//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    public class NativeWriter : StreamWriter
    {
        public NativeWriter(StreamWriter stream)
            : base(stream.BaseStream)
        {

        }

        public NativeWriter(FilePath path, bool append = false)
            : base(path.FullPath, append)
        {

        }

        public int BytesPerLine {get; private set;}
            = 4;

        public bool LineLabels {get; private set;}
            = true;

        byte[] Buffer {get; set;}
            = new byte[NativeReader.DefaultBufferLen];

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

        public void WriteData(INativeMemberData data, NativeFormatConfig? config = null)
        {
            Write(data.Format(config));                            
        }
    }
}