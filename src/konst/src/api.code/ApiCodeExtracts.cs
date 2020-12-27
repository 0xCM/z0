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
    public readonly struct ApiCodeExtracts
    {
        [Op]
        public static ApiCodeExtract[] emit(ReadOnlySpan<ApiCodeBlock> src, FS.FilePath dst, bool append = false)
        {
            var widths = X86TableWidths;
            var count = src.Length;
            var header = (dst.Exists && append) ? false : true;
            var sep = " | ";
            var pattern =
                  text.embrace($"0,-{widths[0]}") + sep
                + text.embrace($"1,-{widths[1]}") + sep
                + text.embrace($"2,-{widths[2]}");

            using var writer = dst.Writer(append);
            if(header)
                writer.WriteLine(string.Format(pattern,
                    nameof(ApiCodeExtract.Base),
                    nameof(ApiCodeExtract.Uri),
                    nameof(ApiCodeExtract.Encoded)
                    ));

            var buffer = alloc<ApiCodeExtract>(count);
            var records = span(buffer);
            for(var i=0u; i<src.Length; i++)
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
        static ref ApiCodeExtract row(ApiCodeBlock src, ref ApiCodeExtract dst)
        {
            dst.Base = src.Code.BaseAddress;
            dst.Encoded = src.Storage;
            dst.Uri =src.Uri.Format();
            return ref dst;
        }

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}