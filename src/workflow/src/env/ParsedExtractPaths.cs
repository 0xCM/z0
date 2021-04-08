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
        FS.FolderPath ParsedExtractRoot()
            => CaptureRoot() + FS.folder(parsed);

        FS.FilePath ParsedExtractPath(FS.FileName name)
            => ParsedExtractRoot() + name;

        FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ParsedExtractPath(ApiFiles.filename(host, X.PCsv));

        FS.FilePath ParsedExtractPath(FS.FolderPath root, ApiHostUri host)
            => root + ApiFiles.filename(host, X.PCsv);

        FS.Files ParsedExtractPaths()
            => ParsedExtractRoot().TopFiles;

        FS.Files ParsedExtractPaths(PartId part)
            => ParsedExtractPaths().Where(f => f.IsOwner(part));
    }
}