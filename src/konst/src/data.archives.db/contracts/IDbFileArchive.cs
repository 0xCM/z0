//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IDbFileArchive : IFileArchive
    {
        IDbPaths DbPaths {get;}

        FS.FolderPath TableRoot();

        FS.FolderPath SourceRoot();

        FS.FolderPath StageRoot();

        FS.FolderPath DocRoot();

        FS.FolderPath ToolRoot();

        FS.FolderPath CaptureRoot()
            => DbPaths.DbRoot + FS.folder("capture");

        FS.FolderPath SourceRoot<S>(S subject);

        FS.FolderPath StageRoot<S>(S subject);

        FS.FileExt DefaultTableExt {get;}

        FS.FolderPath LogRoot();

        FS.FilePath Log(string id, Subject subject);

        FS.FilePath Doc(ApiHostUri host, Subject subject, FS.FileExt ext);

        FS.FilePath Doc(ApiHostUri host, Subject subject, FS.FileExt a, FS.FileExt b);

        FS.FilePath Doc(ApiHostUri host, Subject s1, Subject s2, FS.FileExt a, FS.FileExt b);

        FS.FilePath Doc(ApiHostUri host, Subject s1, Subject s2, FS.FileExt a);

        FS.FilePath Table(string id);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null);

        FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>;

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext);

        FS.FilePath Table(Type t);

        FS.FilePath Table<S>(Type t, S subject);

        FS.FilePath Table(Type t, PartId part);

        FS.FilePath Table<T>(PartId part)
            where T : struct
                => Table(typeof(T), part);

        FS.FolderPath TableDir(string id);

        FS.FolderPath TableDir(Type t);

        FS.FolderPath TableDir<T>()
            where T : struct
                => TableDir(typeof(T));

        Option<FilePath> Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Files Clear(FS.FolderName id);

        Files Clear(string id);

        Files ClearDocs(PartId part, Subject subject, FS.FileExt ext);

        Files ClearDocs(PartId part, Subject s1, Subject s2, FS.FileExt ext);

        FS.FolderPath Tools(ToolId id)
            => ToolRoot() + FS.folder(id.Name);

        FS.FolderPath ToolOutput(ToolId id)
            => Tools(id) + FS.folder("output");

        FS.FolderPath CapturedExtractDir()
            => CaptureRoot() + FS.folder("extracts");

        FS.FilePath[] CapturedExtractFiles()
            => CapturedExtractDir().AllFiles;

        FS.FolderPath ParsedExtractDir()
            => CaptureRoot() + FS.folder("parsed");

        FS.FolderPath CapturedHexDir()
            => CaptureRoot() + FS.folder("hex");

        FS.FolderPath CapturedCilDir()
            => CaptureRoot() + FS.folder("cil");

        FS.FolderPath CapturedAsmDir()
            => CaptureRoot() + FS.folder("asm");

        FS.FilePath CapturedAsmFile(FS.FileName name)
            => CapturedAsmDir() + name;

        FS.FilePath CapturedAsmFile(ApiHostUri host)
            => CapturedAsmFile(host.FileName(ArchiveFileKinds.Asm));

        FS.FilePath[] CapturedAsmFiles()
            => CapturedAsmDir().AllFiles;

        FS.FilePath[] CapturedAsmFiles(PartId part)
            => CapturedAsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedHexFile(FS.FileName name)
            => CapturedHexDir() + name;

        FS.FilePath CapturedHexFile(ApiHostUri host)
            => CapturedHexFile(host.FileName(ArchiveFileKinds.Hex));

        FS.FilePath[] CapturedHexFiles()
            => CapturedHexDir().AllFiles;

        FS.FilePath[] CapturedHexFiles(PartId part)
            => CapturedHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedCilFile(FS.FileName name)
            => CapturedCilDir() + name;

        FS.FilePath CapturedCilFile(ApiHostUri host)
            => CapturedCilFile(host.FileName(ArchiveFileKinds.IlData));

        FS.FilePath[] CapturedCilFiles()
            => CapturedCilDir().AllFiles;

        FS.FilePath[] CapturedCilFiles(PartId part)
            => CapturedCilFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedExtractFile(ApiHostUri host)
            => CapturedExtractFile(host.FileName(ArchiveFileKinds.XCsv));

        FS.FilePath CapturedExtractFile(FS.FileName name)
            => CapturedExtractDir() + name;

        FS.FilePath[] CapturedExtractFiles(PartId part)
            => CapturedExtractFiles().Where(f => f.IsOwner(part));

        FS.FilePath ParsedExtractFile(FS.FileName name)
            => ParsedExtractDir() + name;

        FS.FilePath ParsedExtractFile(ApiHostUri host)
            => ParsedExtractFile(host.FileName(ArchiveFileKinds.PCsv));

        FS.FilePath[] ParsedExtractFiles()
            => ParsedExtractDir().AllFiles;

        FS.FilePath[] ParsedExtractFiles(PartId part)
            => ParsedExtractFiles().Where(f => f.IsOwner(part));
    }

    public interface IDbFileArchive<H> : IDbFileArchive, IFileArchive<H>
        where H : IDbFileArchive<H>
    {

    }
}