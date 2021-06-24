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

        ApiExtractSettings Settings {get;}

        FS.FolderPath IFileArchive.Root
            => Settings.ExtractRoot;

        FS.FolderPath DumpRoot()
            => Root + FS.folder(dumps);

        FS.FileName DumpFile(Process process, Timestamp ts)
            => FS.file(ProcDumpIdentity.create(process,ts).Format(), FS.Dmp);

        FS.FilePath DumpPath(Process process, Timestamp ts)
            => DumpRoot() + DumpFile(process, ts);

        FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        FS.FolderPath HexPackRoot()
            => CaptureRoot() + FS.folder(extracts);

        FS.FolderPath ContextRoot()
            => CaptureRoot() + FS.folder(context);
    }
}