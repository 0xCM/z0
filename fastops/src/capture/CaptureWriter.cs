//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    class CaptureWriter : StreamWriter, ICaptureWriter
    {
        public static ICaptureWriter Create(FilePath dst, bool header = true, bool append = false)
        {
            dst.FolderPath.CreateIfMissing();            
            var exists = dst.Exists();
            var writer = new CaptureWriter(dst,append);
            if(!exists || !append && header)
                writer.WriteHeader();
            return writer;

        }

        CaptureWriter(FilePath path, bool append = false)
            : base(path.FullPath, append)
        {

        }

        public int BytesPerLine {get; private set;}
            = 4;

        public bool LineLabels {get; private set;}
            = true;

        byte[] Buffer {get; set;}
            = new byte[CaptureServices.DefaultBufferLen];

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

        public void WriteData(CapturedMember src, HexLineFormat config)
        {
            Write(src.FormatHexLines(config));                            
        }

        public void WriteData(CapturedMember src)
        {
            Write(src.FormatHexLines(null));                            
        }
    }
}