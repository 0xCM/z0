//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFileNames : IFileExtensions
    {
        FS.FileName LegalFileName(OpIdentity id, FS.FileExt ext)
            => FS.file(id.ToFileName(ext).Name);

        FS.FileName LegalFileName(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, Asm);

        FS.FileName HexOpFileName(OpIdentity id)
            => LegalFileName(id, Hex);
    }
}