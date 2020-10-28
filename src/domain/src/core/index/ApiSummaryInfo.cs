//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static z;

    public struct ApiSummaryInfo : ITextual
    {
        public static ReadOnlySpan<ApiSummaryInfo> from(ISystemApiCatalog src)
        {
            var ops = @readonly(src.Operations);
            var identities = ops.Map(ApiIdentity.identify);
            var sigs = ops.Map(x => x.Signature());
            var count = ops.Length;
            var dst = span<ApiSummaryInfo>(count);
            for(var i=0u; i<count; i++)
                seek(dst,i) = ApiSummaryInfo.define(skip(identities,i), skip(sigs,i));
            return dst;
        }

        public static void emit(ISystemApiCatalog src, FS.FilePath dst)
            => emit(from(src), dst);

        public static void emit(ReadOnlySpan<ApiSummaryInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(src,i).Format());
        }

        public const string RenderPattern = "| {0,-64} | {1}";

        [MethodImpl(Inline)]
        public static ApiSummaryInfo define(in ApiMetadataUri uri, in MethodSig sig)
        {
            var dst = new ApiSummaryInfo();
            dst.Uri = uri;
            dst.Sig = sig;
            return dst;
        }

        public ApiMetadataUri Uri;

        public MethodSig Sig;

        public string Format()
            => string.Format(RenderPattern, Uri,Sig);

        public override string ToString()
            => Format();
    }
}