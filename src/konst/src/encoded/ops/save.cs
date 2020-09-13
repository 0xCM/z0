//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Encoded
    {
        [MethodImpl(Inline), Op]
        public static X86ApiCodeTable table(X86ApiCode src)
        {
            var dst = new X86ApiCodeTable();
            table(src,ref dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static ref X86ApiCodeTable table(X86ApiCode src, ref X86ApiCodeTable dst)
        {
            dst.Base = src.Encoded.Base;
            dst.Encoded = src.Data;
            dst.Uri =src.OpUri.Format();
            return ref dst;
        }

        public static X86ApiCodeTable[] save(ReadOnlySpan<X86ApiCode> src, FS.FilePath dst, bool append = false)
        {
            var formatter = Table.rowformatter<X86ApiCodeTable>(X86TableWidths);
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(formatter.FormatHeader());

            var buffer = alloc<X86ApiCodeTable>(count);
            var records = span(buffer);
            for(var i=0u; i<src.Length; i++)
            {
                ref readonly var code = ref z.skip(src, i);
                if(code.IsNonEmpty)
                {
                    var t = table(code, ref seek(records,i));
                    {
                        formatter.Delimit(16, t.Base);
                        formatter.Delimit(80, t.Uri);
                        formatter.Delimit(t.Encoded);
                        writer.WriteLine(formatter.Render());
                    }
                }
            }
            return buffer;
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};

    }
}