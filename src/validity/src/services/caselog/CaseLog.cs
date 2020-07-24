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
    

    public readonly struct CaseLog : ICaseLog
    {
        public static ReadOnlySpan<string> rows<R>(params R[] src)
            where R : ITabular
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
        public static void deposit(ReadOnlySpan<string> rows, ISink<string> dst)
        {
            for(var i=0u; i<rows.Length; i++)
                dst.Deposit(skip(rows, i));
        }

        [MethodImpl(Inline)]
        public static void deposit(ReadOnlySpan<string> rows, StreamWriter dst)
            => deposit(rows, Streams.sink<string>(dst));

        [MethodImpl(Inline)]
        public static void deposit<R>(R[] src, StreamWriter dst)
            where R : ITabular
                => deposit(rows(src), dst);

        public static CaseLog create(FilePath dst)
            => new CaseLog(new CaseLog<TestCaseField,TestCaseRecord>(dst));

        readonly ICaseLog<TestCaseRecord> Log;
        
        CaseLog(ICaseLog<TestCaseRecord> log)
            => Log = log;

        public void Dispose()
            => Log.Dispose();

        public void Deposit(params TestCaseRecord[] src)
            => Log.Deposit(src);
    }
}