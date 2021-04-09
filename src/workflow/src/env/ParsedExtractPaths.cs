//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;


    partial interface IEnvPaths
    {
        FS.FolderPath ParsedExtractRoot()
            => CaptureRoot() + FS.folder(parsed);

        FS.FilePath ParsedExtractPath(FS.FileName name)
            => ParsedExtractRoot() + name;

        FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ParsedExtractPath(HostFile(host, FS.PCsv));

        FS.FilePath ParsedExtractPath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) + HostFile(host, FS.PCsv);

        FS.Files ParsedExtractPaths()
            => ParsedExtractRoot().TopFiles;

        FS.Files ParsedExtractPaths(PartId part)
            => ParsedExtractPaths().Where(f => f.IsOwner(part));
    }
}