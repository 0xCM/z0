//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct ApiExtracts
    {
        [Op]
        public static ApiExtractRow[] emit(ReadOnlySpan<ApiExtractBlock> src, FS.FilePath dst, bool append = false)
        {
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            ref readonly var w0 = ref skip(X86TableWidths, 0);
            ref readonly var w1 = ref skip(X86TableWidths, 1);
            ref readonly var w2 = ref skip(X86TableWidths, 2);
            var pattern = text.embrace($"0,-{w0}") + RP.SpacedPipe + text.embrace($"1,-{w1}") + RP.SpacedPipe + text.embrace($"2,-{w2}");

            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(string.Format(pattern, nameof(ApiExtractRow.Base), nameof(ApiExtractRow.Uri), nameof(ApiExtractRow.Encoded)));

            var buffer = alloc<ApiExtractRow>(count);
            var records = span(buffer);
            for(var i=0u; i<count; i++)
            {
                ref readonly var code = ref skip(src, i);
                if(code.IsNonEmpty)
                {
                    var extract = row(code, ref seek(records,i));
                    writer.WriteLine(string.Format(pattern, extract.Base, extract.Uri, extract.Encoded));
                }
            }
            return buffer;
        }

        [MethodImpl(Inline), Op]
        static ref ApiExtractRow row(in ApiExtractBlock src, ref ApiExtractRow dst)
        {
            dst.Base = src.Extract.BaseAddress;
            dst.Encoded = src.Storage;
            dst.Uri = src.Uri.Format();
            return ref dst;
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}