//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    partial interface IApiPathProvider
    {
        FS.FolderPath RawExtractRoot()
            => CaptureRoot() + FS.folder(extracts);

        FS.Files RawExtractFiles()
            => RawExtractRoot().AllFiles;

        FS.FilePath RawExtractFile(FS.FileName name)
            => RawExtractRoot() + name;

        FS.FilePath RawExtractFile(ApiHostUri host)
            => RawExtractFile(ApiIdentity.file(host, XCsv));

        FS.Files RawExtractFiles(PartId part)
            => RawExtractFiles().Where(f => f.IsOwner(part));
    }
}