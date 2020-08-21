//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IPartFileNames : IPartFileExtensions
    {
        FileName LegalFileName(OpIdentity id, FileExtension ext)
            => id.ToFileName(ext);

        FileName LegalFileName(PartId part, OpIdentity id, FileExtension ext)
            => FileName.Define(string.Concat(part.Format(), Chars.Dot, LegalFileName(id,ext)));

        FileName LegalFileName(ApiHostUri host, OpIdentity id, FileExtension ext)
            => FileName.Define(string.Concat(host.Owner.Format(), Chars.Dot, host.Name, Chars.Dot, LegalFileName(id,ext)));

        FileName LegalFileName(ApiHostUri host, FileExtension ext)
            => FileName.Define(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, Asm);

        FileName AsmFileName(ApiHostUri host)
            => LegalFileName(host, Asm);

        FileName HexFileName(OpIdentity id)
            => LegalFileName(id, HexLine);

        FileName CilFileName(OpIdentity id)
            => LegalFileName(id, Il);

        FileName ParseFileName(ApiHostUri host)
            => LegalFileName(host, Parsed);
    }
}