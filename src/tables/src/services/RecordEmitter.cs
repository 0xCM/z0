//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Root;
    using static core;

    public readonly struct RecordEmitter<T> : IRecordEmitter<T>
        where T : struct
    {
        public FS.FilePath Target {get;}

        readonly IRecordFormatter<T> Formatter;

        readonly StreamWriter Writer;

        [MethodImpl(Inline)]
        public RecordEmitter(IRecordFormatter<T> formatter, FS.FilePath dst)
        {
            Target = dst;
            Writer = dst.Writer();
            Formatter = formatter;
        }

        public void EmitHeader()
        {
            Writer.WriteLine(Formatter.FormatHeader());
        }

        public void Emit(in T src)
        {
            Writer.WriteLine(Formatter.Format(src));
        }

        public void Emit(ReadOnlySpan<T> src)
        {
            for(var i=0; i<src.Length; i++)
                Writer.WriteLine(Formatter.Format(skip(src,i)));
        }

        public void Dispose()
        {
            Writer?.Flush();
            Writer?.Dispose();
        }
    }
}