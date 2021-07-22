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

        public FS.FolderPath Dumps()
            => RootDir() + FS.folder("dumps");

        public FS.FolderPath Dumps(string id)
            => Dumps() + FS.folder(id);

        public FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        public FS.FolderPath IndexRoot()
            => Root;

        public FS.FolderPath AsmRoot()
            => CaptureRoot() + FS.folder(asm);

        public FS.FolderPath CodeGenRoot()
            => Root + FS.folder("codegen");

        public FS.FolderPath CodeGenDir(string id)
            => CodeGenRoot() + FS.folder(id);

        public FS.FolderPath AsmDir(PartId part)
            => AsmRoot() + FS.folder(part);

        public FS.FolderPath ExtractRoot()
            => CaptureRoot() + FS.folder(extracts);

        public FS.FilePath RawExtractPath(ApiHostUri host)
            => ExtractRoot() + FS.file(host, "extracts.raw", FS.XPack);

        public FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ExtractRoot() + FS.file(host, "extracts.parsed", FS.XPack);

        public FS.FilePath AsmSrcPath(ApiHostUri host)
            => AsmDir(host.Part) + FS.file(host, FS.Asm);

        public FS.FilePath AsmDataPath(ApiHostUri host)
            => AsmDir(host.Part) + FS.file(host, FS.Csv);

        public FS.FolderPath ContextRoot()
            => CaptureRoot() + FS.folder(context);

        public FS.FilePath StatementIndexPath()
            => RootDir() + FS.file("asm.statements", FS.Csv);

        public FS.FilePath ThumbprintPath(FS.FolderPath dst)
            => dst + FS.file("asm.thumbprints", FS.Asm);

        public FS.FolderPath TableDir()
            => RootDir() + FS.folder("tables");

        public FS.FilePath AsmCallsPath()
            => TableDir() + FS.file("asm.calls", FS.Csv);

        public FS.FilePath JmpTarget()
            => TableDir() + FS.file("asm.jumps", FS.Csv);

        public FS.FilePath TablePath<T>()
            where T : struct, IRecord<T>
                => TableDir() + FS.file(TableId.identify<T>().Format(), FS.Csv);
        public FS.FilePath TablePath(string id)
            => TableDir() + FS.file(id, FS.Csv);

        public FS.FolderPath AsmDetailDir()
            => TableDir() + FS.folder("asm.details");

        public FS.FilePath ThumbprintPath()
            => IndexRoot() + FS.file("thumbprints", FS.Asm);

        // public FS.FilePath ApiCatalogPath()
        //     => ContextRoot().Files(FS.Csv).Where(x => x.FileName.StartsWith("api.catalog")).Single();

        public FS.FilePath ApiCatalogPath()
            => TableDir() + FS.file(TableId.identify<ApiCatalogEntry>().Format(), FS.Csv);

        public FS.FilePath ApiCatalogPath(Timestamp ts)
            => ContextRoot() + FS.file(string.Format("{0}.{1}", TableId.identify<ApiCatalogEntry>(), ts.Format()), FS.Csv);
    }
}