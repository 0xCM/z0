//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    using D = ApiDataModel;

    [ApiHost]
    public readonly partial struct ApiCodeBlocks
    {
        [MethodImpl(Inline), Op]
        public static ApiPartCodeBlocks combine(PartId part, ApiHostCodeBlocks[] src)
            => new ApiPartCodeBlocks(part,src);

        /// <summary>
        /// Determines whether an operation accepts an argument of specified numeric kind
        /// </summary>
        /// <param name="src">The encoded operation</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool accepts(ApiCodeBlock src, NumericKind match)
            => ApiIdentify.numeric(src.Id.TextComponents.Skip(1)).Contains(match);

        /// <summary>
        /// Determines the arity of the encoded operation
        /// </summary>
        /// <param name="src">The encoded operation</param>
        [MethodImpl(Inline)]
        public static int arity(ApiCodeBlock src)
            => src.OpUri.OpId.TextComponents.Count() - 1;

        /// <summary>
        /// Excludes source operations that do not accept two parameters of specified numeric kind
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="k1">The first parameter kind</param>
        /// <param name="k2">The second parameter kind</param>
        public static IEnumerable<ApiCodeBlock> accepts(IEnumerable<ApiCodeBlock> src, NumericKind k1, NumericKind k2)
            => from code in src
                let kinds = ApiIdentify.numeric(code.OpUri.OpId.TextComponents.Skip(1))
                where kinds.Contains(k1) && kinds.Contains(k2)
                select code;

        [Op]
        public static IEnumerable<ApiCodeBlock> accepts(IEnumerable<ApiCodeBlock> src, NumericKind kind)
            => from code in src
                where accepts(code, kind)
                select code;

        [Op]
        public static IEnumerable<ApiCodeBlock> withArity(IEnumerable<ApiCodeBlock> src, int count)
            => from code in src
                where arity(code) == count
                select code;
        [Op]
        public static uint emit(ReadOnlySpan<D.CodeBlockDescriptor> src, FS.FilePath dst)
        {
            using var writer = dst.Writer();
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(src,i);
                writer.WriteLine(string.Format(D.CodeBlockDescriptor.FormatPattern, block.Part, block.Host, block.Base, block.Size, block.Uri));
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