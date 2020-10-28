//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost("api.summaries")]
    public readonly struct ApiSummaries
    {
        const string DefaultTargetId = "z0.api";

        [MethodImpl(Inline), Op]
        public static ApiSummaryInfo[] from(IWfShell wf)
            => from(wf.Api);

        [MethodImpl(Inline), Op]
        public static FS.FilePath target(IFileDb db)
            => target(db, DefaultTargetId);

        [MethodImpl(Inline), Op]
        public static FS.FilePath target(IFileDb db, string id)
            => db.IndexFile(id);

        [MethodImpl(Inline), Op]
        public static ApiSummaryInfo row(in ApiMetadataUri uri, in MethodSig sig)
        {
            var dst = new ApiSummaryInfo();
            dst.Uri = uri;
            dst.Sig = sig;
            return dst;
        }

        [Op]
        public static ApiSummaryInfo[] parts(IWfShell wf, params PartId[] src)
            => from(wf.Api.PartCatalogs(src).SelectMany(c => c.Operations).Array());

        [Op]
        public static ApiSummaryInfo[] from(ReadOnlySpan<MethodInfo> src)
        {
            var ops = src;
            var identities = ops.Map(ApiIdentity.identify);
            var sigs = ops.Map(x => x.Signature());
            var count = ops.Length;
            var buffer = alloc<ApiSummaryInfo>(count);
            var dst = span(buffer);
            for(var i=0u; i<count; i++)
                seek(dst,i) = row(skip(identities,i), skip(sigs,i));
            return buffer;
        }

        [Op]
        public static ApiSummaryInfo[] from(ISystemApiCatalog src)
            => from(src.Operations);

        [Op]
        public static void emit(ReadOnlySpan<ApiSummaryInfo> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(skip(src,i).Format());
        }

        [MethodImpl(Inline), Op]
        public static void emit(ISystemApiCatalog src, FS.FilePath dst)
            => emit(from(src), dst);

        [MethodImpl(Inline), Op]
        public static void emit(IWfShell wf)
            => emit(wf.Api, wf.Db().IndexFile("z0.api"));
    }
}