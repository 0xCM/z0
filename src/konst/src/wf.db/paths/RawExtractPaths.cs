//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath RawExtractRoot()
            => CaptureRoot() + FS.folder(extracts);

        FS.Files RawExtractFiles()
            => RawExtractRoot().AllFiles;

        FS.FilePath RawExtractFile(FS.FileName name)
            => RawExtractRoot() + name;

        FS.FilePath RawExtractFile(ApiHostUri host)
            => RawExtractFile(ApiFiles.filename(host, XCsv));

        FS.Files RawExtractFiles(PartId part)
            => RawExtractFiles().Where(f => f.IsOwner(part));
    }
}