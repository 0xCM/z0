//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using X = ArchiveFileKinds;
    using PN = DbPartitionNames;

    public interface IFileDb : IFileArchive
    {
        IDbPaths DbPaths {get;}

        Option<FilePath> Deposit<F,R,S>(R[] src, string id, S subject, FS.FileExt type)
            where F : unmanaged, Enum
            where R : struct, ITabular;

        Files Clear(FS.FolderName id);

        Files Clear(string id);

        FS.FileExt DefaultTableExt
             => X.Csv;

        FS.FolderPath LogRoot()
            => Root + FS.folder(PN.Logs);

        FS.FolderPath TableRoot()
            => Root + FS.folder(PN.Tables);

        FS.FolderPath SourceRoot()
            => Root + FS.folder(PN.Sources);

        FS.FolderPath DocRoot()
            => Root + FS.folder(PN.Docs);

        FS.FolderPath ToolRoot()
            => Root + FS.folder(PN.Tools);

        FS.FolderPath CaptureRoot()
            => Root + FS.folder(PN.Capture);

        FS.FolderPath JobRoot()
            => Root + FS.folder(PN.Jobs);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder("queue");

        FS.FolderPath StageRoot()
            => Root + FS.folder(PN.Stage);

        FS.FolderPath SourceRoot<S>(S subject)
            => SourceRoot() + FS.folder(subject.ToString());

        FS.FolderPath StageRoot<S>(S subject)
            => StageRoot() + FS.folder(subject.ToString());

        FS.FilePath Table(string id)
            => TableRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => Table<S>(Root, id, subject, ext);

        FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>
                => TableRoot() + FS.file(id, kind.Ext);

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null)
            => TableRoot() +  FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), ext ?? DefaultTableExt);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableRoot() + FS.folder(id) + FS.file(part.Format(), ext);

        FS.FilePath Table<D>(FS.FolderPath root, string id, D subject, FS.FileExt? type = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format("{0}.{1}", id, subject), type ?? X.Csv);

        FS.FilePath Table(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table(a.TableId),
                    () => Table(t.Name));

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => Table(part,  a.TableId, DefaultTableExt),
                    () => Table(part, t.Name, DefaultTableExt));

        FS.FilePath Table<T>(PartId part)
            where T : struct
                => Table(typeof(T), part);

        FS.FolderPath TableDir(string id)
            => DbPaths.TableRoot() + FS.folder(id);

        FS.FolderPath TableDir(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(
                    a => TableDir(a.TableId),
                    () => TableDir(t.Name));

        FS.FolderPath TableDir<T>()
            where T : struct
                => TableDir(typeof(T));

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

        FS.FilePath CapturedHexFile(FS.FileName name)
            => CapturedHexDir() + name;

        FS.FilePath CapturedHexFile(ApiHostUri host)
            => CapturedHexFile(host.FileName(ArchiveFileKinds.Hex));

        FS.FilePath CapturedCilFile(FS.FileName name)
            => CapturedCilDir() + name;

        FS.FilePath CapturedCilFile(ApiHostUri host)
            => CapturedCilFile(host.FileName(ArchiveFileKinds.IlData));

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

        FS.FilePath[] CapturedAsmFiles()
            => CapturedAsmDir().AllFiles;

        FS.FilePath[] CapturedHexFiles()
            => CapturedHexDir().AllFiles;

        FS.FilePath[] CapturedCilFiles()
            => CapturedCilDir().AllFiles;

        FS.FilePath[] ParsedExtractFiles()
            => ParsedExtractDir().AllFiles;

        FS.FilePath[] ParsedExtractFiles(PartId part)
            => ParsedExtractFiles().Where(f => f.IsOwner(part));

        FS.FilePath[] CapturedAsmFiles(PartId part)
            => CapturedAsmDir().AllFiles.Where(f => f.FileName.StartsWith(part.Format()));

        FS.FilePath[] CapturedHexFiles(PartId part)
            => CapturedHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath[] CapturedCilFiles(PartId part)
            => CapturedCilFiles().Where(f => f.IsOwner(part));

    }

    public interface IDbFileArchive<H> : IFileDb, IFileArchive<H>
        where H : IDbFileArchive<H>
    {

    }
}