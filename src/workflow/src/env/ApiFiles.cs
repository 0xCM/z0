//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public partial interface IEnvPaths
    {
        FS.FileName LegalFileName(OpIdentity id, FS.FileExt ext)
            => id.ToFileName(ext);

        FS.FileName LegalFileName(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Part.Format(), Chars.Dot, host.Name), ext);

        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);
    }
}