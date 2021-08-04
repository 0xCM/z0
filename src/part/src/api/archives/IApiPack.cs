//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;

    using static EnvFolders;

    public interface IApiPack : IFileArchive
    {
        Timestamp Timestamp {get;}

        ApiExtractSettings ExtractSettings {get;}

        FS.FolderPath IFileArchive.Root
            => ExtractSettings.ExtractRoot;

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

        FS.FolderPath AsmCaptureRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.FolderPath AsmCaptureDir(PartId id)
            => AsmCaptureRoot() + FS.folder(id.Format());

        FS.FilePath AsmCapture(ApiHostUri host)
            => AsmCaptureDir(host.Part) + FS.file(string.Format("{0}.{1}", host.Part.Format(), host.HostName), FS.Asm);

        FS.Files AsmCapturePaths(PartId id)
            => AsmCaptureDir(id).Files(FS.Asm);

        FS.FilePath AsmStatementSummary()
            => Root + FS.file("asm.statements", FS.Csv);

        ApiPackArchive Archive()
            => ApiPackArchive.create(Root);
    }
}