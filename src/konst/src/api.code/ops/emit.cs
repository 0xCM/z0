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

    partial struct ApiCode
    {
        public static ApiCodeRow[] emit(ReadOnlySpan<ApiCodeBlock> src, FS.FilePath dst, bool append = false)
        {
            var formatter = TableFormatter.row<ApiCodeRow>(X86TableWidths);
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(formatter.FormatHeader());

            var buffer = alloc<ApiCodeRow>(count);
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

        public static uint emit(ReadOnlySpan<ApiCodeDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        static ref ApiCodeRow row(ApiCodeBlock src, ref ApiCodeRow dst)
        {
            dst.Base = src.Code.BaseAddress;
            dst.Encoded = src.Storage;
            dst.Uri =src.Uri.Format();
            return ref dst;
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}