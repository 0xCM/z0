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
        FS.FolderPath AsmRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.Files AsmFiles()
            => AsmRoot().Files(Asm,true);

        FS.Files AsmFiles(PartId part)
            => AsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath AsmFile(ApiHostUri host)
            => AsmRoot() + ApiIdentity.file(host, Asm);

        FS.FilePath AsmFile(PartId part, string api)
            => AsmRoot() + ApiFileName(part, api, Asm);

        FS.FilePath AsmFile(Type host)
            => AsmFile(ApiQuery.hosturi(host));

        FS.FilePath AsmFile<T>()
            => AsmFile(ApiQuery.hosturi<T>());

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, Asm);

    }
}