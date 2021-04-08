//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;
    using X = FS.Extensions;

    partial interface IEnvPaths
    {
        FS.FolderPath RawExtractRoot()
            => CaptureRoot() + FS.folder(extracts);

        FS.Files RawExtractPaths()
            => RawExtractRoot().TopFiles;

        FS.FilePath RawExtractPath(FS.FileName name)
            => RawExtractRoot() + name;

        FS.FilePath RawExtractPath(FS.FolderPath root, ApiHostUri host)
            => root + ApiFiles.filename(host, X.XCsv);

        FS.FilePath RawExtractPath(ApiHostUri host)
            => RawExtractPath(ApiFiles.filename(host, X.XCsv));

        FS.Files RawExtractFiles(PartId part)
            => RawExtractPaths().Where(f => f.IsOwner(part));
    }
}