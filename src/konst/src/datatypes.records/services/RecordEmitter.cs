//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Part;
    using static memory;

    public readonly struct RecordEmitter<T> : IRecordEmitter<T>
        where T : struct, IRecord<T>
    {
        public FS.FilePath Target {get;}

        readonly IRecordFormatter<T> Formatter;

        readonly StreamWriter Writer;

        [MethodImpl(Inline)]
        internal RecordEmitter(IRecordFormatter<T> formatter, FS.FilePath dst)
        {
            Target = dst;
            Writer = dst.Writer();
            Formatter = formatter;
        }

        public void Dispose()
        {
            Writer?.Flush();
            Writer?.Dispose();
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
    }
}