//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using L = ArchiveFolderNames;

    public interface IApiCaptureArchive : IWfService,  IFileExtensions
    {
        void Clear();

        FS.FolderPath HexDir(FS.FolderPath root)
            => (root + FS.folder(L.Hex));

        FS.FolderPath AsmDir(FS.FolderPath root)
            => (root + FS.folder(L.Asm));

        FS.Files ApiExtractFiles()
            => Db.ApiExtractFiles();

        FS.Files ParsedExtractFiles()
            => Db.ParsedExtractFiles();

        FS.Files ApiHexFiles()
            => Db.CapturedHexFiles();

        FS.Files AsmFiles()
            => Db.CapturedAsmFiles();

        FS.Files CilDataFiles()
            => Db.CilDataFiles();

        FS.Files ApiExtractFiles(PartId part)
            => Db.ApiExtractFiles(part);

        FS.Files ParsedExtractFiles(PartId part)
            => Db.ParsedExtractFiles(part);

        FS.Files AsmFiles(PartId part)
            => Db.CapturedAsmFiles(part);

        FS.Files ApiHexFiles(PartId part)
            => Db.CapturedHexFiles(part);

        FS.Files CilDataFiles(PartId part)
            => Db.CilDataFiles(part);

        FS.FilePath ApiHexFile(ApiHostUri host)
            => Db.CapturedHexFile(host);

        FS.FilePath ApiHexFile(FS.FolderPath root, FS.FileName name)
            => HexDir(root) + name;

        FS.FilePath ApiHexFile(FS.FolderPath root, ApiHostUri host)
            => HexDir(root) + FS.file(host.Name, Hex);

        FS.FilePath ApiExtractFile(ApiHostUri host)
            => Db.ApiExtractFile(host);

        FS.FilePath ParsedExtractFile(ApiHostUri host)
            => Db.ParsedExtractFile(host);

        FS.FilePath AsmFile(ApiHostUri host)
            => Db.CapturedAsmFile(host);

        FS.FilePath AsmFile(FS.FolderPath root, FS.FileName name)
            => AsmDir(root) + name;

        FS.FilePath CilDataFile(ApiHostUri host)
            => Db.CilDataFile(host);
    }
}