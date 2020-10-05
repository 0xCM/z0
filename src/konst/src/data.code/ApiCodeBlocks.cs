//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly partial struct ApiCodeBlocks
    {
        [Op]
        public static uint emit(ReadOnlySpan<ApiCodeBlockInfo> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(ApiCodeBlockInfo.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public static BinaryCode define(byte[] data)
            => new BinaryCode(data);

        [MethodImpl(Inline), Op]
        public static ApiMemberCode define(in ApiMember member, in ApiCodeBlock data)
            => new ApiMemberCode(member, data);

        [MethodImpl(Inline), Op]
        public static ApiCaptureBlock define(OpIdentity id, MethodInfo method, BasedCodeBlock extracted, BasedCodeBlock parsed, ExtractTermCode term)
            => new ApiCaptureBlock(id, method, extracted, parsed, term);

        [MethodImpl(Inline), Op]
        public static ref ApiCodeRow row(ApiCodeBlock src, ref ApiCodeRow dst)
        {
            dst.Base = src.Code.Base;
            dst.Encoded = src.Data;
            dst.Uri =src.Uri.Format();
            return ref dst;
        }

        public static ApiCodeRow[] save(ReadOnlySpan<ApiCodeBlock> src, FS.FilePath dst, bool append = false)
        {
            var formatter = TableRows.formatter<ApiCodeRow>(X86TableWidths);
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

        static ReadOnlySpan<byte> X86TableWidths => new byte[3]{16,80,80};
    }
}