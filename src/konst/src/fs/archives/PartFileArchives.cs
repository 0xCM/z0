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

    [ApiHost]
    public readonly struct PartFileArchives
    {
        readonly IPartFilePaths Paths;

        [MethodImpl(Inline)]
        public PartFileArchives(IPartFilePaths paths)
            => Paths = paths;

        [MethodImpl(Inline), Op]
        public IHostCaptureArchive Capture(ApiHostUri host)
            => HostCaptureArchive.create(Paths.ResourceRoot + FolderName.Define("capture"), host);

        [MethodImpl(Inline), Op]
        public ISemanticPaths Semantic(ApiHostUri host)
            => SemanticPaths.create();

        static void Clear(PartId part, FilePath file, Action<FilePath> handler)
            => file.Delete().OnSome(handler);

        static void Clear(PartId part, ReadOnlySpan<FilePath> files, Action<FilePath> handler)
        {
            var count = files.Length;
            for(var i=0u; i<count; i++)
                Clear(part, skip(files,i), handler);
        }

        static void Clear(PartId part, FolderPath src, FileExtension ext, Action<FilePath> handler)
            => Clear(part, src.Files(ext), handler);

    }
}