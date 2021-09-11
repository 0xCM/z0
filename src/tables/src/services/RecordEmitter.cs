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

    public readonly struct RecordEmitter : IRecordEmitter
    {
        public Outcome Emit<T>(in T src, StreamWriter dst)
            where T : struct
        {
            try
            {
                var formatter = Tables.formatter<T>();
                dst.WriteLine(formatter.Format(src));
            }
            catch(Exception e)
            {
                return e;
            }
            return true;
        }

        public Outcome Emit<T>(ReadOnlySpan<T> src, StreamWriter dst, bool header = true)
            where T : struct
        {
            var formatter = Tables.formatter<T>();
            if(header)
                dst.WriteLine(formatter.FormatHeader());
            return Write(src,formatter,dst);
        }

        public Outcome Emit<T>(ReadOnlySpan<T> src, ReadOnlySpan<byte> widths, StreamWriter dst, bool header = true)
            where T : struct
        {
            var formatter = Tables.formatter<T>(widths);
            if(header)
                dst.WriteLine(formatter.FormatHeader());
            return Write(src,formatter,dst);
        }

        Outcome Write<T>(ReadOnlySpan<T> src, IRecordFormatter<T> formatter, StreamWriter dst)
            where T : struct
        {
            try
            {
                for(var i=0; i<src.Length; i++)
                    dst.WriteLine(formatter.Format(skip(src,i)));
            }
            catch(Exception e)
            {
                return e;
            }
            return true;
        }
    }
}