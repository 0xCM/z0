//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IWfDbPaths : IFileArchive
    {
        FS.FolderName SubjectFolder<S>(S src)
            => FS.folder(src.ToString().ToLowerInvariant());

        FS.FolderName SubjecFolder<A,B>(A s1, B s2)
            => FS.folder(string.Format(DbNames.delimiter, SubjectFolder(s1), SubjectFolder(s2)));

        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);

        FS.FolderPath DevRoot()
            => EnvVars.Common.DevRoot;

        FS.FolderPath DevDataRoot()
            => DevRoot() +FS.folder(DbNames.data);

        FS.FolderPath DevData<S>(S subject)
            => DevDataRoot() + SubjectFolder(subject);

        FS.FolderPath ArchiveRoot()
            => EnvVars.Common.ArchiveRoot;

        FS.FolderPath BuildArchiveRoot()
            => ArchiveRoot() + FS.folder(DbNames.builds);

        FS.FileExt DefaultTableExt
             => Csv;

        FS.FolderPath EventRoot()
            => Root + FS.folder(DbNames.events);

        FS.FolderPath RefDataRoot()
            => Root + FS.folder(DbNames.refdata);

        FS.FolderPath ReflectedRoot()
            => Root + FS.folder("reflected");

        FS.FolderPath Reflected(Assembly src)
            => ReflectedRoot() + FS.folder(src.GetSimpleName());

        FS.FolderPath TmpRoot()
            => Root + FS.folder(DbNames.tmp);

        FS.FilePath TmpFile(FS.FileName file)
            => TmpRoot() + file;

        FS.FolderPath TmpDir<S>(S subject)
            => TmpRoot() + SubjectFolder(subject);

        FS.FolderPath LogRoot()
            => Root + FS.folder(DbNames.logs);

        FS.FolderPath TableRoot()
            => Root + FS.folder(DbNames.tables);

        /// <summary>
        /// Defines a task-specific log path
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FilePath TaskLogPath(string subject, FS.FileExt? ext = null)
            =>  LogRoot() + FS.file(subject, ext ?? Csv);

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
            => t.Tag<RecordAttribute>().MapValueOrElse(a => TableRoot(a.TableId), () => TableRoot(t.Name));

        /// <summary>
        /// Specifies a table root for a parametrically-identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        /// <typeparam name="S">The subject type</typeparam>
        FS.FolderPath TableRoot<T>()
            where T : struct
                => TableRoot(typeof(T));

        FS.FilePath Table(string id, PartId part)
            => TableRoot(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), DefaultTableExt);

        FS.FilePath Table(string id)
            => TableRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableRoot(id) + FS.file(part.Format(), ext);

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => Table(part,  a.TableId, DefaultTableExt), () => Table(part, t.Name, DefaultTableExt));

        FS.FilePath Table<T>(PartId part)
            where T : struct
                => Table(typeof(T), part);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format(DbNames.qualified, id, subject), ext ?? Csv);

        FS.FilePath IndexTable(string id)
            => TableRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath IndexTable(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => IndexTable(a.TableId), () => IndexTable(t.Name));

        FS.FolderPath ListRoot()
            => Root + FS.folder(DbNames.lists);

        FS.FilePath List(string name, FS.FileExt ext)
            => ListRoot() + FS.file(name, ext);

        FS.FolderPath Notebooks()
            => Root + FS.folder(DbNames.notebooks);

        FS.FolderPath CaptureRoot()
            => Root + FS.folder(DbNames.capture);

        FS.FolderPath ImmRoot()
            => CaptureRoot() + FS.folder(DbNames.asm_imm);

        FS.FolderPath JobRoot()
            => Root + FS.folder(DbNames.jobs);

        FS.FolderPath IndexRoot()
            => Root + FS.folder(DbNames.indices);

        FS.FilePath IndexFile(string id)
            => IndexRoot() + FS.file(id, Idx);

        FS.FilePath[] IndexFiles()
            => IndexRoot().Files(Idx);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder(DbNames.queue);

        FS.FilePath JobPath(FS.FileName file)
            => JobQueue() + file;

        FS.FolderPath StageRoot()
            => Root + FS.folder(DbNames.stage);

        FS.FolderPath Notebook(string name)
            => Notebooks() + FS.folder(name);

        FS.FolderPath DocRoot()
            => Root + FS.folder(DbNames.docs);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FilePath Doc<S>(S subject, string name, FS.FileExt ext)
            => DocRoot() + SubjectFolder(subject) + FS.file(name, ext);

        FS.FilePath RefDataPath(string id, FS.FileExt? ext = null)
            => RefDataRoot() + FS.file(id, ext ?? DefaultTableExt);

        FS.FilePath RefDataPath<S>(S subject, string id, FS.FileExt? ext = null)
            => RefDataRoot() + SubjectFolder(subject) + FS.file(id, ext ?? DefaultTableExt);

        FS.FilePath RefDataPath<S>(S subject, FS.FileName file)
            => RefDataRoot() + SubjectFolder(subject) + file;

        FS.FolderPath RefData<S>(S subject)
            => RefDataRoot() + SubjectFolder(subject);

        FS.FolderPath StageRoot<S>(S subject)
            => StageRoot() + SubjectFolder(subject);

        FS.FolderPath ToolDbRoot()
            => Root + FS.folder("tooldb");

        FS.FolderPath ToolExeRoot()
            => Root + FS.folder(DbNames.tools);

        FS.FolderPath CapturedHexRoot()
            => (CaptureRoot() + FS.folder(DbNames.hex));

        FS.FilePath CapturedHexPath(FS.FileName name)
            => CapturedHexRoot() + name;

        FS.FolderPath Tools(ToolId id)
            => ToolExeRoot() + FS.folder(id.Format());

        FS.FolderPath Output(ToolId id)
            => Tools(id) + FS.folder(DbNames.output);

        FS.FolderPath Output(ToolId tool, CmdId cmd)
            => ToolExeRoot() + FS.folder(tool.Format()) + FS.folder(cmd.Format()) + FS.folder(DbNames.output);

        FS.FolderPath CapturedExtractDir()
            => CaptureRoot() + FS.folder(DbNames.extracts);

        FS.Files CapturedExtractFiles()
            => CapturedExtractDir().AllFiles;

        FS.FolderPath ParsedExtractDir()
            => CaptureRoot() + FS.folder(DbNames.parsed);

        FS.FolderPath CapturedHexDir()
            => CaptureRoot() + FS.folder(DbNames.hex);

        FS.FolderPath CapturedAsmDir()
            => CaptureRoot() + FS.folder(DbNames.asm);

        FS.Files CapturedAsmFiles()
            => CapturedAsmDir().Files(Asm,true);

        FS.Files CapturedAsmFiles(PartId part)
            => CapturedAsmFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedAsmFile(FS.FileName name)
            => CapturedAsmDir() + name;

        FS.FilePath CapturedAsmFile(ApiHostUri host)
            => CapturedAsmFile(ApiIdentity.file(host, FileExtensions.Asm));

        FS.FilePath CapturedAsmFile(PartId part, string api)
            => CapturedAsmDir() + ApiFileName(part, api, Asm);

        FS.Files CapturedHexFiles()
            => CapturedHexDir().Files(Hex);

        FS.Files CapturedHexFiles(PartId part)
            => CapturedHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedHexFile(FS.FileName name)
            => CapturedHexDir() + name;

        FS.FilePath CapturedHexFile(PartId part, string api)
            => CapturedHexDir() + ApiFileName(part, api, Hex);

        FS.FilePath CapturedHexFile(ApiHostUri host)
            => CapturedHexFile(ApiIdentity.file(host, FileExtensions.Hex));

        FS.FolderPath CapturedCilDir()
            => CaptureRoot() + FS.folder(DbNames.cil);

        FS.FilePath CapturedCilDataFile(FS.FileName name)
            => CapturedCilDir() + name;

        FS.FilePath CapturedCilDataFile(ApiHostUri host)
            => CapturedCilDataFile(ApiIdentity.file(host, FileExtensions.IlData));

        FS.Files CapturedCilDataFiles()
            => CapturedCilDir().Files(Csv);

        FS.Files CapturedCilDataFiles(PartId part)
            => CapturedCilDataFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedExtractFile(ApiHostUri host)
            => CapturedExtractFile(ApiIdentity.file(host, FileExtensions.XCsv));

        FS.FilePath CapturedExtractFile(FS.FileName name)
            => CapturedExtractDir() + name;

        FS.Files CapturedExtractFiles(PartId part)
            => CapturedExtractFiles().Where(f => f.IsOwner(part));

        FS.FilePath ParsedExtractFile(FS.FileName name)
            => ParsedExtractDir() + name;

        FS.FilePath ParsedExtractFile(ApiHostUri host)
            => ParsedExtractFile(ApiIdentity.file(host, FileExtensions.PCsv));

        FS.Files ParsedExtractFiles()
            => ParsedExtractDir().AllFiles;

        FS.Files ParsedExtractFiles(PartId part)
            => ParsedExtractFiles().Where(f => f.IsOwner(part));

        PartFiles PartFiles()
        {
            var parsed = ParsedExtractFiles();
            var hex = CapturedHexFiles();
            var asm = CapturedAsmFiles();
            return new PartFiles(parsed, hex, asm);
        }
    }
}