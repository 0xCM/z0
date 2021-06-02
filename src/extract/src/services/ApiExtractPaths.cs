//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static EnvFolders;

    public readonly struct ApiPackArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public static ApiPackArchive create(FS.FolderPath root)
            => new ApiPackArchive(root);

        [MethodImpl(Inline)]
        public ApiPackArchive(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath RootDir()
            => Root;

        public FS.FolderPath AsmTableRoot()
            => Root + FS.folder(tables);

        public FS.FolderPath PartDir(PartId part)
            => Root + FS.folder(part);

        public FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        public FS.FolderPath IndexRoot()
            => Root;

        public FS.FolderPath AsmSourceRoot()
            => CaptureRoot() + FS.folder(asm);

        public FS.FolderPath AsmSourceDir(PartId part)
            => AsmSourceRoot() + FS.folder(part);

        public FS.FolderPath ExtractRoot()
            => CaptureRoot() + FS.folder(extracts);

        public FS.FilePath RawExtractPath(ApiHostUri host)
            => ExtractRoot() + FS.file(host, "extracts.raw", FS.XPack);

        public FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ExtractRoot() + FS.file(host, "extracts.parsed", FS.XPack);

        public FS.FilePath AsmPath(ApiHostUri host)
            =>  AsmSourceDir(host.Part) + FS.file(host, FS.Asm);

        public FS.FolderPath ContextRoot()
            => CaptureRoot() + FS.folder(context);

        FS.FilePath ThumbprintPath()
            => IndexRoot() + FS.file("thumbprints", FS.Asm);

        public FS.FilePath ApiRebasePath(Timestamp ts)
            => ContextRoot() + FS.file(string.Format("{0}.{1}", Tables.identify<ApiCatalogEntry>(), ts.Format()), FS.Csv);
    }
}