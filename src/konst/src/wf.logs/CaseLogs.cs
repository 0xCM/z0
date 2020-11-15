//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Text;

    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.CaseLogs, true)]
    public readonly struct CaseLogs
    {
        [MethodImpl(Inline)]
        public static CaseLog<F,T> create<F,T>(FS.FilePath dst)
            where T : ITabular
            where F : unmanaged, Enum
                => new CaseLog<F,T>(dst);

        [Op]
        public static CaseLog create(FS.FilePath dst)
            => new CaseLog(create<TestCaseField,TestCaseRecord>(dst));

        [Op]
        public static void deposit(ReadOnlySpan<string> rows, FileStream dst)
            => deposit(rows, Streams.sink<string>(dst));

        [MethodImpl(Inline)]
        public static void deposit<T>(T[] src, FileStream dst)
            where T : ITabular
                => deposit(rows(src), dst);

        [MethodImpl(Inline)]
        public static string header<F>()
            where F : unmanaged, Enum
                => Table.header53<F>();

        /// <summary>
        /// Writes text data to the target
        /// </summary>
        /// <param name="src">The source content</param>
        /// <param name="dst">The target stream</param>
        /// <param name="encoding">The encoding to use, which defaults to <see cref='Encoding.UTF8'/> if unspecified</param>
        [Op]
        public static uint write(string src, FileStream dst, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            var data = encoding.GetBytes(src + Eol);
            var length = data.Length;
            dst.Seek(0, SeekOrigin.End);
            dst.Write(data, 0, length);
            dst.Flush();
            return (uint)length;
        }

        public static ReadOnlySpan<string> rows<T>(params T[] src)
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

        [Op]
        public static void deposit(ReadOnlySpan<string> rows, ISink<string> dst)
        {
            for(var i=0u; i<rows.Length; i++)
            {
                dst.Deposit(skip(rows, i));
                dst.Deposit(Eol);
            }
        }

        [Op]
        public static void deposit(ReadOnlySpan<string> rows, StreamWriter dst)
            => deposit(rows, Streams.sink<string>(dst));

        [MethodImpl(Inline)]
        public static void deposit<T>(T[] src, StreamWriter dst)
            where T : ITabular
                => deposit(rows(src), dst);
    }
}