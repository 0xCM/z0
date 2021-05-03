//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class ApiExtractor
    {
        FS.FolderPath RootDir()
            => Db.AppLogDir();

        FS.FolderPath DataRoot()
            => RootDir() + FS.folder("data");

        FS.FolderPath PartDir(PartId part)
            => RootDir() + FS.folder(part);

        FS.FolderPath ExtractStore()
            => DataRoot() + FS.folder("extracts");

        FS.FolderPath AsmSourceRoot()
            => RootDir() + FS.folder("asm");

        FS.FolderPath AsmSourceDir(PartId part)
            => AsmSourceRoot() + FS.folder(part);

        FS.FilePath RawExtractPath(ApiHostUri host)
            => ExtractStore() + FS.file(host, "extracts-raw", FS.XPack);

        FS.FilePath ParsedExtractPath(ApiHostUri host)
            => ExtractStore() + FS.file(host, "extracts-parsed", FS.XPack);

        FS.FilePath AsmPath(ApiHostUri host)
            =>  AsmSourceDir(host.Part) + FS.file(host, FS.Asm);
    }
}