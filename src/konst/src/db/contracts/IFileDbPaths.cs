//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using X = ArchiveFileKinds;
    using PN = DbNames;

    public interface IFileDbPaths : IFileArchivePaths
    {
        FS.FileExt DefaultFileExt
             => X.Csv;

        FS.FolderPath EventRoot()
            => Root + FS.folder(PN.Events);

        FS.FolderPath RefDataRoot()
            => Root + FS.folder(PN.Refs);

        FS.FolderPath EtlRoot()
            => Root + FS.folder(PN.Etl);

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
            => JobRoot() + FS.folder(PN.Queue);

        FS.FolderPath StageRoot()
            => Root + FS.folder(PN.Stage);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FilePath Doc<S>(S subject, string name, FS.FileExt ext)
            => DocRoot() + SubjectName(subject) + FS.file(name, ext);

        FS.FolderName SubjectName<S>(S subject)
            => FS.folder(subject.ToString().ToLowerInvariant());

        FS.FolderName SubjectName<A,B>(A s1, B s2)
            => FS.folder(string.Format(PN.SubjectDelimiter, SubjectName(s1), SubjectName(s2)));

        FS.FilePath RefDataPath(string id, FS.FileExt? ext = null)
            => RefDataRoot() + FS.file(id, ext ?? DefaultFileExt);

        FS.FilePath RefDataPath<S>(S subject, string id, FS.FileExt? ext = null)
            => RefDataRoot() + SubjectName(subject) + FS.file(id, ext ?? DefaultFileExt);

        FS.FilePath RefDataPath<S>(S subject, FS.FileName file)
            => RefDataRoot() + SubjectName(subject) + file;

        FS.FolderPath RefData<S>(S subject)
            => RefDataRoot() + SubjectName(subject);

        FS.FolderPath SourceRoot<S>(S subject)
            => SourceRoot() + SubjectName(subject);

        FS.FolderPath StageRoot<S>(S subject)
            => StageRoot() + SubjectName(subject);

        FS.FilePath Table(string id)
            => TableRoot() + FS.file(id, DefaultFileExt);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => Table<S>(Root, id, subject, ext);

        FS.FilePath Table<K>(string id, K kind)
            where K : unmanaged,  IFileKind<K>
                => TableRoot() + FS.file(id, kind.Ext);

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null)
            => TableRoot() +  FS.folder(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), ext ?? DefaultFileExt);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableRoot() + FS.folder(id) + FS.file(part.Format(), ext);

        FS.FilePath Table<D>(FS.FolderPath root, string id, D subject, FS.FileExt? type = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format(PN.QualifiedSubject, id, subject), type ?? X.Csv);

        FS.FilePath Table(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(a => Table(a.TableId), () => Table(t.Name));

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<TableAttribute>().MapValueOrElse(a => Table(part,  a.TableId, DefaultFileExt), () => Table(part, t.Name, DefaultFileExt));

        FS.FilePath Table<T>(PartId part)
            where T : struct
                => Table(typeof(T), part);

        FS.FolderPath TableDir(string id)
            => TableRoot() + FS.folder(id);

        FS.FolderPath TableDir(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(a => TableDir(a.TableId), () => TableDir(t.Name));

        FS.FolderPath TableDir<T>()
            where T : struct
                => TableDir(typeof(T));

        FS.FolderPath Tools(ToolId id)
            => ToolRoot() + FS.folder(id.Name);

        FS.FolderPath ToolOutput(ToolId id)
            => Tools(id) + FS.folder(PN.Output);

        FS.FolderPath CapturedExtractDir()
            => CaptureRoot() + FS.folder(PN.Extracts);

        FS.FilePath[] CapturedExtractFiles()
            => CapturedExtractDir().AllFiles;

        FS.FolderPath ParsedExtractDir()
            => CaptureRoot() + FS.folder(PN.Parsed);

        FS.FolderPath CapturedHexDir()
            => CaptureRoot() + FS.folder(PN.Hex);

        FS.FolderPath CapturedCilDir()
            => CaptureRoot() + FS.folder(PN.Cil);

        FS.FolderPath CapturedAsmDir()
            => CaptureRoot() + FS.folder(PN.Asm);

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

    public interface IFileDbPaths<H> : IFileDbPaths, IFileArchivePaths<H>
        where H : struct, IFileDbPaths<H>
    {

    }
}