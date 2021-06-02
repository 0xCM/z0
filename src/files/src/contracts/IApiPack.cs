//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Diagnostics;

    using static EnvFolders;

    public interface IApiPack : IFileArchive
    {
        Timestamp Timestamp {get;}

        ApiPackSettings Settings {get;}

        FS.FolderPath IFileArchive.Root
            => Settings.ExtractRoot;

        FS.FolderPath DumpRoot()
            => Root + FS.folder(dumps);

        // FS.Files Dumps()
        //     => DumpRoot().Files(FS.Dmp);

        FS.FileName DumpFile(Process process, Timestamp ts)
            => FS.file(ProcDumpIdentity.create(process,ts).Format(), FS.Dmp);

        FS.FilePath DumpPath(Process process, Timestamp ts)
            => DumpRoot() + DumpFile(process, ts);

        // FS.FolderPath AsmTableRoot()
        //     => Root + FS.folder("tables");

        // FS.FolderPath PartDir(PartId part)
        //     => Root + FS.folder(part);

        // FS.FilePath RawExtractPath(ApiHostUri host)
        //     => HexPackRoot() + FS.file(host, "extracts.raw", FS.XPack);

        // FS.FilePath ParsedExtractPath(ApiHostUri host)
        //     => HexPackRoot() + FS.file(host, "extracts.parsed", FS.XPack);

        // FS.FilePath AsmPath(ApiHostUri host)
        //     =>  AsmSourceDir(host.Part) + FS.file(host, FS.Asm);

        // FS.FolderPath AsmSourceRoot()
        //     => Root + FS.folder(capture) + FS.folder(asm);

        // FS.FolderPath AsmSourceDir(PartId part)
        //     => AsmSourceRoot() + FS.folder(part);

        FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        FS.FolderPath HexPackRoot()
            => CaptureRoot() + FS.folder(extracts);

        FS.FolderPath ContextRoot()
            => CaptureRoot() + FS.folder(context);
    }
}