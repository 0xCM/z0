//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using X = ArchiveFileKinds;
    using PN = DbNames;

    public interface IDbPaths
    {
        /// <summary>
        /// The workflow's database root
        /// </summary>
        FS.FolderPath DbRoot {get;}
    }

    public interface IFileDbPaths : IDbPaths, IFileArchivePaths
    {
        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);

        FS.FolderPath IDbPaths.DbRoot
            => Root;

        FS.FileExt DefaultFileExt
             => X.Csv;

        FS.FolderPath EventRoot()
            => Root + FS.folder(PN.Events);

        FS.FolderPath RefDataRoot()
            => Root + FS.folder(PN.Refs);

        FS.FolderPath ReflectedRoot()
            => Root + FS.folder("reflected");

        FS.FolderPath Reflected(Assembly src)
            => ReflectedRoot() + FS.folder(src.GetSimpleName());

        FS.FolderPath EtlRoot()
            => Root + FS.folder(PN.Etl);

        FS.FolderPath LogRoot()
            => Root + FS.folder(PN.Logs);

        FS.FolderPath TableRoot()
            => Root + FS.folder(PN.tables);

        /// <summary>
        /// Specifies a table root for an identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FolderPath TableRoot(string subject)
            => TableRoot() + FS.folder(subject);

        /// <summary>
        /// Specifies a table root for a type-identified subject
        /// </summary>
        /// <param name="t">The identifying type</param>
        FS.FolderPath TableRoot(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(a => TableRoot(a.TableId), () => TableRoot(t.Name));

        /// <summary>
        /// Specifies a table root for a parametrically-identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        /// <typeparam name="S">The subject type</typeparam>
        FS.FolderPath TableRoot<T>()
            where T : struct
                => TableRoot(typeof(T));

        FS.FilePath Table(string id, PartId part, FS.FileExt? ext = null)
            => TableRoot(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), ext ?? DefaultFileExt);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableRoot(id) + FS.file(part.Format(), ext);

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<TableAttribute>().MapValueOrElse(a => Table(part,  a.TableId, DefaultFileExt), () => Table(part, t.Name, DefaultFileExt));

        FS.FilePath Table<T>(PartId part)
            where T : struct
                => Table(typeof(T), part);

        FS.FilePath Table<D>(FS.FolderPath root, string id, D subject, FS.FileExt? type = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format(PN.QualifiedSubject, id, subject), type ?? X.Csv);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => Table<S>(Root, id, subject, ext);

        FS.FilePath IndexTable(string id)
            => TableRoot() + FS.file(id, DefaultFileExt);

        FS.FilePath IndexTable(Type t)
            => t.Tag<TableAttribute>().MapValueOrElse(a => IndexTable(a.TableId), () => IndexTable(t.Name));

        FS.FolderPath DocRoot()
            => Root + FS.folder(PN.docs);

        FS.FolderPath Notebooks()
            => Root + FS.folder(PN.notebooks);

        FS.FolderPath CaptureRoot()
            => Root + FS.folder(PN.Capture);

        FS.FolderPath ImmRoot()
            => CaptureRoot() + FS.folder(PN.imm);

        FS.FolderPath JobRoot()
            => Root + FS.folder(PN.jobs);

        FS.FolderPath IndexRoot()
            => Root + FS.folder(PN.indices);

        FS.FilePath IndexFile(string id)
            => IndexRoot() + FS.file(id, Idx);

        FS.FilePath[] IndexFiles()
            => IndexRoot().Files(Idx);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder(PN.Queue);

        FS.FilePath JobPath(FS.FileName file)
            => JobQueue() + file;

        FS.FolderPath StageRoot()
            => Root + FS.folder(PN.Stage);

        FS.FolderPath Notebook(string name)
            => Notebooks() + FS.folder(name);

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

        FS.FolderPath SourceRoot()
            => Root + FS.folder(PN.sources);

        FS.FolderPath SourceRoot<S>(S subject)
            => SourceRoot() + SubjectName(subject);

        FS.FolderPath StageRoot<S>(S subject)
            => StageRoot() + SubjectName(subject);

        FS.FolderPath ToolRoot()
            => Root + FS.folder(PN.tools);

        FS.FolderPath Tools(ToolId id)
            => ToolRoot() + FS.folder(id.Format());

        FS.FolderPath ToolOutput(ToolId id)
            => Tools(id) + FS.folder(PN.output);

        FS.FolderPath CapturedExtractDir()
            => CaptureRoot() + FS.folder(PN.extracts);

        FS.FilePath[] CapturedExtractFiles()
            => CapturedExtractDir().AllFiles;

        FS.FolderPath ParsedExtractDir()
            => CaptureRoot() + FS.folder(PN.Parsed);

        FS.FolderPath CapturedHexDir()
            => CaptureRoot() + FS.folder(PN.Hex);

        FS.FolderPath CapturedAsmDir()
            => CaptureRoot() + FS.folder(PN.Asm);

        FS.FilePath[] CapturedAsmFiles()
            => CapturedAsmDir().Files(Asm,true);

        FS.FilePath[] CapturedAsmFiles(PartId part)
            => CapturedAsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedAsmFile(FS.FileName name)
            => CapturedAsmDir() + name;

        FS.FilePath CapturedAsmFile(ApiHostUri host)
            => CapturedAsmFile(host.FileName(ArchiveFileKinds.Asm));

        FS.FilePath CapturedAsmFile(PartId part, string api)
            => CapturedAsmDir() + ApiFileName(part, api, Asm);

        FS.FilePath[] CapturedHexFiles()
            => CapturedHexDir().Files(Hex);

        FS.FilePath[] CapturedHexFiles(PartId part)
            => CapturedHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedHexFile(FS.FileName name)
            => CapturedHexDir() + name;

        FS.FilePath CapturedHexFile(PartId part, string api)
            => CapturedHexDir() + ApiFileName(part, api, Hex);

        FS.FilePath CapturedHexFile(ApiHostUri host)
            => CapturedHexFile(host.FileName(ArchiveFileKinds.Hex));

        FS.FolderPath CapturedCilDir()
            => CaptureRoot() + FS.folder(PN.Cil);

        FS.FilePath CapturedCilDataFile(FS.FileName name)
            => CapturedCilDir() + name;

        FS.FilePath CapturedCilDataFile(ApiHostUri host)
            => CapturedCilDataFile(host.FileName(ArchiveFileKinds.IlData));

        FS.FilePath[] CapturedCilDataFiles()
            => CapturedCilDir().Files(Csv);

        FS.FilePath[] CapturedCilDataFiles(PartId part)
            => CapturedCilDataFiles().Where(f => f.IsOwner(part));

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

    public interface IFileDbPaths<H> : IFileDbPaths, IFileArchivePaths<H>
        where H : struct, IFileDbPaths<H>
    {

    }
}