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

    public readonly struct PartFileWriter : IPartFileWriter<PartFileWriter, string>
    {
        readonly StreamWriter Writer;

        public FilePath TargetPath {get;}

        [MethodImpl(Inline)]
        public PartFileWriter(FilePath dst)
        {
            TargetPath = dst;
            Writer = dst.Writer();
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