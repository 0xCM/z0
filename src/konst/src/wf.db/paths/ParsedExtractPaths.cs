//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath ParsedExtractRoot()
            => CaptureRoot() + FS.folder(parsed);

        FS.FilePath ParsedExtractFile(FS.FileName name)
            => ParsedExtractRoot() + name;

        FS.FilePath ParsedExtractFile(ApiHostUri host)
            => ParsedExtractFile(ApiIdentity.file(host, PCsv));

        FS.Files ParsedExtractFiles()
            => ParsedExtractRoot().AllFiles;

        FS.Files ParsedExtractFiles(PartId part)
            => ParsedExtractFiles().Where(f => f.IsOwner(part));
    }
}