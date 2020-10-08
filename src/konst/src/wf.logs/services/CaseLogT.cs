//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public class CaseLog<F,R> : ICaseLog<R>
        where R : ITabular
        where F : unmanaged, Enum
    {
        static ReadOnlySpan<string> rows<T>(params T[] src)
            where T : ITabular
        {
            var count = src.Length;
            var dst = span(alloc<string>(count));
            var input = span(src);
            for(var i=0u; i<count; i++)
            {
                ref readonly var record = ref skip(input,i);
                var delimited = record.DelimitedText(FieldDelimiter);
                seek(dst,i) = delimited;
            }

            return dst;
        }

        [MethodImpl(Inline)]
        static void deposit(ReadOnlySpan<string> rows, ISink<string> dst)
        {
            for(var i=0u; i<rows.Length; i++)
                dst.Deposit(skip(rows, i));
        }

        [MethodImpl(Inline)]
        static void deposit(ReadOnlySpan<string> rows, FileStream dst)
            => deposit(rows, Streams.sink<string>(dst));

        [MethodImpl(Inline)]
        public static void deposit<T>(T[] src, FileStream dst)
            where T : ITabular
                => deposit(rows(src), dst);

        object Locker;

        int Counter;

        //StreamWriter Writer;

        readonly FileStream Status;

        readonly FS.FilePath Target;

        static string HeaderText
            => Table.header53<F>();

        internal CaseLog(FS.FilePath dst)
        {
            Target = dst;
            Locker = new object();
            //Writer = Target.Writer();
            Status = dst.Stream();
            FS.write(HeaderText, Status);
            //Writer.WriteLine(HeaderText);
            Counter = 0;
        }

        public void Deposit(params R[] src)
        {
            try
            {
                lock(Locker)
                {
                    deposit(src, Status);
                    // CaseLog.deposit(src,Writer);
                    // Writer.Flush();
                }
            }
            catch(Exception e)
            {
                term.error(e);
            }
        }

        public void Dispose()
            => Status.Dispose();
            //=> Writer.Dispose();
    }
}