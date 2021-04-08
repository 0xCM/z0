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
        FS.FolderPath CilDataRoot()
            => CaptureRoot() + FS.folder(cildata);

        FS.FilePath CilDataPath(FS.FileName name)
            => CilDataRoot() + name;

        FS.FilePath CilDataPath(ApiHostUri host)
            => CilDataPath(ApiFiles.filename(host, X.IlData));

        FS.FilePath CilDataPath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) +   HostFile(host, X.IlData);

        FS.Files CilDataPaths()
            => CilDataRoot().Files(X.Csv);

        FS.Files CilDataPaths(PartId part)
            => CilDataPaths().Where(f => f.IsOwner(part));

        FS.FolderPath CilCodeRoot()
            => CaptureRoot() + FS.folder(cil);

        FS.FilePath CilCodePath(FS.FileName name)
            => CilCodeRoot() + name;

        FS.FilePath CilCodePath(ApiHostUri host)
            => CilCodePath(ApiFiles.filename(host, X.Il));

        FS.FilePath CilCodePath(FS.FolderPath dst, ApiHostUri host)
            => dst +  PartFolder(host.Part) +  HostFile(host, X.Il);

        FS.Files CilCodePaths()
            => CilCodeRoot().Files(X.Csv);

        FS.Files CilCodePaths(PartId part)
            => CilCodePaths().Where(f => f.IsOwner(part));
    }
}