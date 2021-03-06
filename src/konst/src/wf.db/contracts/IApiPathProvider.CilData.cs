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
        FS.FolderPath CilDataRoot()
            => CaptureRoot() + FS.folder(cildata);

        FS.FilePath CilDataFile(FS.FileName name)
            => CilDataRoot() + name;

        FS.FilePath CilDataFile(ApiHostUri host)
            => CilDataFile(ApiIdentity.file(host, IlData));

        FS.Files CilDataFiles()
            => CilDataRoot().Files(Csv);

        FS.Files CilDataFiles(PartId part)
            => CilDataFiles().Where(f => f.IsOwner(part));
    }
}