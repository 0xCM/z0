//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath CilDataRoot()
            => CaptureRoot() + FS.folder(cildata);

        FS.FilePath CilDataFile(FS.FileName name)
            => CilDataRoot() + name;

        FS.FilePath CilDataFile(ApiHostUri host)
            => CilDataFile(ApiFiles.filename(host, IlData));

        FS.Files CilDataFiles()
            => CilDataRoot().Files(Csv);

        FS.Files CilDataFiles(PartId part)
            => CilDataFiles().Where(f => f.IsOwner(part));

        FS.FolderPath CilCodeRoot()
            => CaptureRoot() + FS.folder(cil);

        FS.FilePath CilCodeFile(FS.FileName name)
            => CilCodeRoot() + name;

        FS.FilePath CilCodeFile(ApiHostUri host)
            => CilCodeFile(ApiFiles.filename(host, Il));

        FS.Files CilCodeFiles()
            => CilCodeRoot().Files(Csv);

        FS.Files CilCodeFiles(PartId part)
            => CilCodeFiles().Where(f => f.IsOwner(part));
    }
}