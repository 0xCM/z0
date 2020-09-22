//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial struct EncodedX86
    {
        public static ApiHexRow[] save(ReadOnlySpan<X86ApiCode> src, FS.FilePath dst, bool append = false)
        {
            var formatter = Table.rowformatter<ApiHexRow>(X86TableWidths);
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(formatter.FormatHeader());

            var buffer = alloc<ApiHexRow>(count);
            var records = span(buffer);
            for(var i=0u; i<src.Length; i++)
            {
                ref readonly var code = ref z.skip(src, i);
                if(code.IsNonEmpty)
                {
                    var t = row(code, ref seek(records,i));
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