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

        FileName LegalFileName(ApiHostUri host, FileExtension ext)
            => FileName.define(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, Asm);

        FileName AsmFileName(ApiHostUri host)
            => LegalFileName(host, Asm);

        FileName HexOpFileName(OpIdentity id)
            => LegalFileName(id, HexLine);

        FileName ParseFileName(ApiHostUri host)
            => LegalFileName(host, Parsed);
    }
}