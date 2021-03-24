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

        FS.Files RawExtractFiles()
            => RawExtractRoot().AllFiles;

        FS.FilePath RawExtractFile(FS.FileName name)
            => RawExtractRoot() + name;

        FS.FilePath RawExtractFile(ApiHostUri host)
            => RawExtractFile(ApiFiles.filename(host, X.XCsv));

        FS.Files RawExtractFiles(PartId part)
            => RawExtractFiles().Where(f => f.IsOwner(part));
    }
}