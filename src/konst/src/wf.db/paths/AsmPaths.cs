//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    using X = FS.Extensions;

    partial interface IEnvPaths
    {
        FS.FolderPath AsmRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.Files AsmFiles()
            => AsmRoot().Files(X.Asm,true);

        FS.Files AsmFiles(PartId part)
            => AsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath AsmFile(ApiHostUri host)
            => AsmRoot() + ApiFiles.filename(host, X.Asm);

        FS.FilePath AsmFile(PartId part, string api)
            => AsmRoot() + ApiFileName(part, api, X.Asm);

        FS.FilePath AsmFile(Type host)
            => AsmFile(host.HostUri());

        FS.FilePath AsmFile<T>()
            => AsmFile(typeof(T).HostUri());

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, X.Asm);
    }
}