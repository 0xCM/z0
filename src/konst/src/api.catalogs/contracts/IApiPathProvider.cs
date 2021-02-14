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

        FS.FolderPath CapturedHexRoot()
            => (CaptureRoot() + FS.folder(hex));

        FS.FilePath CapturedHexPath(FS.FileName name)
            => CapturedHexRoot() + name;

        FS.FolderPath CapturedExtractDir()
            => CaptureRoot() + FS.folder(extracts);

        FS.FolderPath ParsedExtractDir()
            => CaptureRoot() + FS.folder(parsed);

        FS.FolderPath CapturedHexDir()
            => CaptureRoot() + FS.folder(hex);

        FS.FolderPath CapturedAsmDir()
            => CaptureRoot() + FS.folder(asm);

        FS.FolderPath AsmDir(FS.FolderPath root)
            => (root + FS.folder(L.Asm));

        FS.Files AsmFiles()
            => CapturedAsmDir().Files(Asm,true);

        FS.Files AsmFiles(PartId part)
            => AsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath AsmFile(FS.FileName name)
            => CapturedAsmDir() + name;

        FS.FilePath AsmFile(ApiHostUri host)
            => AsmFile(ApiIdentity.file(host, FileExtensions.Asm));

        FS.FilePath AsmFile(PartId part, string api)
            => CapturedAsmDir() + ApiFileName(part, api, Asm);

        FS.FilePath AsmFile(Type host)
            => AsmFile(ApiQuery.hosturi(host));

        FS.FilePath AsmFile(FS.FolderPath root, FS.FileName name)
            => AsmDir(root) + name;

        FS.FilePath AsmFile<T>()
            => AsmFile(ApiQuery.hosturi<T>());

        FS.Files ApiHexFiles()
            => CapturedHexDir().Files(Hex);

        FS.FolderPath ApiHexDir(FS.FolderPath root)
            => (root + FS.folder(L.Hex));

        FS.Files ApiHexFiles(PartId part)
            => ApiHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath ApiHexFile(FS.FolderPath root, FS.FileName name)
            => ApiHexDir(root) + name;

        FS.FilePath ApiHexFile(FS.FolderPath root, ApiHostUri host)
            => ApiHexDir(root) + FS.file(host.Name, Hex);

        FS.FilePath ApiHexFile(FS.FileName name)
            => CapturedHexDir() + name;

        FS.FilePath ApiHexFile(PartId part, string api)
            => CapturedHexDir() + ApiFileName(part, api, Hex);

        FS.FilePath ApiHexFile(ApiHostUri host)
            => ApiHexFile(ApiIdentity.file(host, Hex));

        FS.FolderPath CilDataDir()
            => CaptureRoot() + FS.folder(cildata);

        FS.FilePath CilDataFile(FS.FileName name)
            => CilDataDir() + name;

        FS.FilePath CilDataFile(ApiHostUri host)
            => CilDataFile(ApiIdentity.file(host, IlData));

        FS.Files CilDataFiles()
            => CilDataDir().Files(Csv);

        FS.Files CilDataFiles(PartId part)
            => CilDataFiles().Where(f => f.IsOwner(part));

        FS.FolderPath CilCodeDir()
            => CaptureRoot() + FS.folder(cil);

        FS.FilePath CilCodeFile(FS.FileName name)
            => CilCodeDir() + name;

        FS.FilePath CilCodeFile(ApiHostUri host)
            => CilCodeFile(ApiIdentity.file(host, Il));

        FS.Files CilCodeFiles()
            => CilCodeDir().Files(Csv);

        FS.Files CilCodeFiles(PartId part)
            => CilCodeFiles().Where(f => f.IsOwner(part));

        FS.FilePath ApiExtractFile(ApiHostUri host)
            => ApiExtractFile(ApiIdentity.file(host, XCsv));

        FS.FilePath ApiExtractFile(FS.FileName name)
            => CapturedExtractDir() + name;

        FS.Files ApiExtractFiles()
            => CapturedExtractDir().AllFiles;

        FS.Files ApiExtractFiles(PartId part)
            => ApiExtractFiles().Where(f => f.IsOwner(part));

        FS.FilePath ParsedExtractFile(FS.FileName name)
            => ParsedExtractDir() + name;

        FS.FilePath ParsedExtractFile(ApiHostUri host)
            => ParsedExtractFile(ApiIdentity.file(host, PCsv));

        FS.Files ParsedExtractFiles()
            => ParsedExtractDir().AllFiles;

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