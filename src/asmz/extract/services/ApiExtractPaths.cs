//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiExtractPaths
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public ApiExtractPaths(FS.FolderPath root)
        {
            Root = root;
        }

        public FS.FolderPath DataRoot()
            => Root + FS.folder("data");

        public FS.FolderPath PartDir(PartId part)
            => Root + FS.folder(part);

        public FS.FolderPath ExtractStore()
            => DataRoot() + FS.folder("extracts");

        public FS.FolderPath AsmSourceRoot()
            => Root + FS.folder("asm");

        public FS.FolderPath AsmSourceDir(PartId part)
            => AsmSourceRoot() + FS.folder(part);

        public FS.FilePath RawExtractPath(ApiHostUri host)
            => ExtractStore() + FS.file(host, "extracts-raw", FS.XPack);

        public FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ExtractStore() + FS.file(host, "extracts-parsed", FS.XPack);

        public FS.FilePath AsmPath(ApiHostUri host)
            =>  AsmSourceDir(host.Part) + FS.file(host, FS.Asm);

        public FS.FolderPath ContextRoot()
            => DataRoot() + FS.folder("context");

        public FS.FilePath ApiRebasePath(Timestamp ts)
            => ContextRoot() + FS.file(string.Format("{0}.{1}", Tables.identify<ApiCatalogEntry>(), ts.Format()), FS.Csv);
    }
}