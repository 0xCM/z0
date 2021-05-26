//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ApiExtractPaths
    {
        readonly FS.FolderPath Root;

        readonly IEnvPaths Paths;

        [MethodImpl(Inline)]
        public ApiExtractPaths(FS.FolderPath root)
        {
            Root = root;
            Paths = EnvPaths.create();
        }

        public FS.FolderPath RootDir()
            => Root;

        public FS.FolderPath AsmTableRoot()
            => Root + FS.folder("tables");

        public FS.FolderPath PartDir(PartId part)
            => Root + FS.folder(part);

        public FS.FolderPath AsmSourceRoot()
            => Paths.CaptureRoot(Root) + FS.folder("asm");

        public FS.FolderPath AsmSourceDir(PartId part)
            => AsmSourceRoot() + FS.folder(part);

        public FS.FolderPath ExtractRoot()
            => Paths.CaptureRoot(Root) + FS.folder("extracts");

        public FS.FilePath RawExtractPath(ApiHostUri host)
            => ExtractRoot() + FS.file(host, "extracts.raw", FS.XPack);

        public FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ExtractRoot() + FS.file(host, "extracts.parsed", FS.XPack);

        public FS.FilePath AsmPath(ApiHostUri host)
            =>  AsmSourceDir(host.Part) + FS.file(host, FS.Asm);

        public FS.FolderPath ContextRoot()
            => Paths.CaptureRoot(Root) + FS.folder("context");

        public FS.FilePath ApiRebasePath(Timestamp ts)
            => ContextRoot() + FS.file(string.Format("{0}.{1}", Tables.identify<ApiCatalogEntry>(), ts.Format()), FS.Csv);
    }
}