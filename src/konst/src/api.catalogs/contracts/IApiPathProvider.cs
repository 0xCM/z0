//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    public partial interface IApiPathProvider : IFileArchive
    {
        FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        FS.FileName LegalFileName(OpIdentity id, FS.FileExt ext)
            => id.ToFileName(ext);

        FS.FileName LegalFileName(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FS.FolderPath CilCodeRoot()
            => CaptureRoot() + FS.folder(cil);

        FS.FilePath CilCodeFile(FS.FileName name)
            => CilCodeRoot() + name;

        FS.FilePath CilCodeFile(ApiHostUri host)
            => CilCodeFile(ApiIdentity.file(host, Il));

        FS.Files CilCodeFiles()
            => CilCodeRoot().Files(Csv);

        FS.Files CilCodeFiles(PartId part)
            => CilCodeFiles().Where(f => f.IsOwner(part));

        PartFiles PartFiles()
            => new PartFiles(RawExtractFiles(), ParsedExtractFiles(), ApiHexFiles(), AsmFiles(), ImmHexFiles(), ImmAsmFiles());

        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);
    }
}