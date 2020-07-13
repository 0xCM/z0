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

    public readonly struct PartFileWriter<T> : IPartFileWriter<T>
        where T : ITextual
    {
        readonly StreamWriter Writer;

        public FilePath TargetPath {get;}

        public PartFileWriter(FilePath dst)
        {
            TargetPath = dst;
            Writer = dst.Writer();
        }

        public void WriterLine(T src)
        {
            Writer.WriteLine(src.Format());
        }

        public void WriteLines(T[] src)
        {
            for(var i=0; i< src.Length; i++)
            {
                Writer.WriteLine(src[i].Format());
            }
        }        

        public void Write(T src)
        {
            Writer.Write(src.Format());
        }

        public void Write(string src)
        {
            Writer.Write(text.ifblank(src, EmptyString));
        }

        public void WriterLine(string src)
        {
            Writer.WriteLine(text.ifblank(src, EmptyString));
        }

        public void WriteLines(string[] src)
        {
            var dst = text.build();
            z.iter(src,line => dst.AppendLine(line));
            Writer.Write(dst.ToString());           
        }

        public void Dispose()
        {
            Writer?.Dispose();
        }
    }
}