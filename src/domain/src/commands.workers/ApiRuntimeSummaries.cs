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

    public readonly struct ApiRuntimeSummaries
    {
        public const string RenderPattern = "| {0,-16} | {1,-64} | {2,16} | {3, -64} | {4}";

        public static ReadOnlySpan<byte> RenderWidths => new byte[]{16,64,16,64,32};

        public static string format(in ApiRuntimeSummary src)
            => string.Format(RenderPattern, src.Address, src.Uri, src.Genericity, src.Sig, src.Metadata);

        [MethodImpl(Inline), Op]
        public static FS.FilePath target(IFileDb db, string id)
            => db.IndexFile(id);

        [Op]
        public static void emit(ReadOnlySpan<ApiRuntimeSummary> src, FS.FilePath dst)
        {
            var count = src.Length;
            using var writer = dst.Writer();
            for(var i=0; i<count; i++)
                writer.WriteLine(ApiRuntimeSummaries.format(skip(src,i)));
        }
    }
}