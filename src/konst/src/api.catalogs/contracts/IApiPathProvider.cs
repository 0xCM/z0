//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static DbNames;

    using L = ArchiveFolderNames;

    public interface IApiPathProvider : IWfService, IFileArchive
    {
        FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        FS.FolderPath ImmRoot()
            => CaptureRoot() + FS.folder(imm);

        FS.FolderPath ExtractRoot()
            => CaptureRoot() + FS.folder(extracts);

        FS.FolderPath ParsedExtractRoot()
            => CaptureRoot() + FS.folder(parsed);

        FS.FolderPath ApiHexRoot()
            => CaptureRoot() + FS.folder(hex);

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

        FS.FolderPath[] ImmDirs(PartId part)
            => ImmRoot().SubDirs().Where(d => d.Name.EndsWith(part.Format()));

        FS.FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs());

        FS.FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs);

        FS.FolderPath ImmSubDir(FS.FolderName name)
            => (ImmRoot() + name);

        FS.FileName LegalFileName(OpIdentity id, FS.FileExt ext)
            => FS.file(id.ToFileName(ext).Name);

        FS.FileName LegalFileName(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, Asm);

        FS.FileName HexFileName(OpIdentity id)
            => LegalFileName(id, Hex);

        FS.FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + HexFileName(id);

        FS.FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + AsmFileName(id);

        FS.FilePath ApiHexPath(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FilePath ApiHexPath(ApiHostUri host)
            => ApiHexRoot()  + FS.file(host.Name, Hex);

        FS.Files ApiHexFiles()
            => ApiHexRoot().Files(Hex);

        FS.FolderPath ApiHexDir(FS.FolderPath root)
            => (root + FS.folder(L.Hex));

        FS.Files ApiHexFiles(PartId part)
            => ApiHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath ApiHexFile(FS.FolderPath root, FS.FileName name)
            => ApiHexDir(root) + name;

        FS.FilePath ApiHexFile(FS.FolderPath root, ApiHostUri host)
            => ApiHexDir(root) + FS.file(host.Name, Hex);

        FS.FilePath ApiHexFile(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FilePath ApiHexFile(PartId part, string api)
            => ApiHexRoot() + ApiFileName(part, api, Hex);

        FS.FilePath ApiHexFile(ApiHostUri host)
            => ApiHexFile(ApiIdentity.file(host, Hex));

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

        FS.FilePath ApiExtractFile(ApiHostUri host)
            => ApiExtractFile(ApiIdentity.file(host, XCsv));

        FS.FilePath ApiExtractFile(FS.FileName name)
            => ExtractRoot() + name;

        FS.Files ApiExtractFiles()
            => ExtractRoot().AllFiles;

        FS.Files ApiExtractFiles(PartId part)
            => ApiExtractFiles().Where(f => f.IsOwner(part));

        FS.FilePath ParsedExtractFile(FS.FileName name)
            => ParsedExtractRoot() + name;

        FS.FilePath ParsedExtractFile(ApiHostUri host)
            => ParsedExtractFile(ApiIdentity.file(host, PCsv));

        FS.Files ParsedExtractFiles()
            => ParsedExtractRoot().AllFiles;

        FS.Files ParsedExtractFiles(PartId part)
            => ParsedExtractFiles().Where(f => f.IsOwner(part));

        PartFiles PartFiles()
        {
            var parsed = ParsedExtractFiles();
            var hex = ApiHexFiles();
            var asm = AsmFiles();
            return new PartFiles(parsed, hex, asm);
        }

        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);
    }
}