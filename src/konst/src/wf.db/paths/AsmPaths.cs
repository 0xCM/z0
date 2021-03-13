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
        FS.FolderPath AsmRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.Files AsmFiles()
            => AsmRoot().Files(Asm,true);

        FS.Files AsmFiles(PartId part)
            => AsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath AsmFile(ApiHostUri host)
            => AsmRoot() + ApiFiles.filename(host, Asm);

        FS.FilePath AsmFile(PartId part, string api)
            => AsmRoot() + ApiFileName(part, api, Asm);

        FS.FilePath AsmFile(Type host)
            => AsmFile(host.HostUri());

        FS.FilePath AsmFile<T>()
            => AsmFile(typeof(T).HostUri());

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, Asm);
    }
}