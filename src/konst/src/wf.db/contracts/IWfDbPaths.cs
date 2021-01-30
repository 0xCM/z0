//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static DbNames;

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
            => DevRoot() +FS.folder(data);

        FS.FolderPath DevData<S>(S subject)
            => DevDataRoot() + SubjectFolder(subject);

        FS.FolderPath ArchiveRoot()
            => EnvVars.Common.ArchiveRoot;

        FS.FolderPath BuildArchiveRoot()
            => BinaryRoot() + FS.folder(builds);

        FS.FolderPath SourceArchiveDir()
            => BinaryRoot() + FS.folder(source);

        FS.Files SourceArchives()
            => SourceArchiveDir().Files(Zip);

        FS.FileExt DefaultTableExt
             => Csv;

        FS.FolderPath DumpFileRoot()
            => BinaryRoot() + FS.folder(dumps);

        FS.FilePath DumpFilePath(string id)
            => DumpFileRoot() + FS.file(id, Dmp);

        FS.FilePath DumpFilePath(PartId id)
            => DumpFilePath(id.Format());

        FS.FolderPath EventRoot()
            => Root + FS.folder(events);

        FS.FolderPath RefDataRoot()
            => Root + FS.folder(refdata);

        FS.FolderPath TmpRoot()
            => Root + FS.folder(tmp);

        FS.FilePath TmpFile(FS.FileName file)
            => TmpRoot() + file;

        FS.FolderPath TmpDir<S>(S subject)
            => TmpRoot() + SubjectFolder(subject);

        FS.FolderPath LogRoot()
            => Root + FS.folder(logs);

        FS.FolderPath BuildLogRoot()
            => LogRoot() + FS.folder("build");

        FS.FilePath BuildLogPath(FS.FileName src)
            => BuildLogRoot() + src;

        /// <summary>
        /// Defines a task-specific log path
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FilePath TaskLogPath(string subject, FS.FileExt ext)
            =>  LogRoot() + FS.file(subject, ext);

        /// <summary>
        /// The root table directory
        /// </summary>
        FS.FolderPath TableRoot()
            => Root + FS.folder(tables);

        /// <summary>
        /// Specifies a table root for an identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FolderPath TableDir(string subject)
            => TableRoot() + FS.folder(subject);

        /// <summary>
        /// Specifies a table subdirectory
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FolderPath TableDir(FS.FolderName subject)
            => TableRoot() + subject;

        /// <summary>
        /// Specifies a table root for a type-identified subject
        /// </summary>
        /// <param name="t">The identifying type</param>
        FS.FolderPath TableDir(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => TableDir(a.TableId), () => TableDir(t.Name));

        /// <summary>
        /// Specifies a table root for a parametrically-identified subject
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        /// <typeparam name="S">The subject type</typeparam>
        FS.FolderPath TableDir<T>()
            where T : struct, IRecord<T>
                => TableDir(typeof(T));

        FS.FilePath Table(string id, PartId part)
            => TableDir(id) + FS.file(string.Format(RP.SlotDot2, id, part.Format()), DefaultTableExt);

        FS.FilePath Table(string id)
            => TableRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath Table(PartId part, string id, FS.FileExt ext)
            => TableDir(id) + FS.file(part.Format(), ext);

        FS.FilePath Table<T>(string name)
            where T : struct, IRecord<T>
                => Table<T>(name, Csv);

        FS.FilePath Table<T>()
            where T : struct, IRecord<T>
                => Table<T>(default(T).TableId.Format(), Csv);

        FS.FilePath Table<T>(FS.FolderName subject)
            where T : struct, IRecord<T>
                => TableDir(subject) + FS.file(Records.tableid<T>().Identifier.Format(), Csv);

        FS.FilePath Table<T>(string name, FS.FileExt ext)
            where T : struct, IRecord<T>
        {
            var id = Records.tableid<T>().Identifier;
            var dir = TableDir(id);
            return dir + FS.file(string.Format("{0}.{1}", id, name), ext);
        }

        FS.FilePath Table(Type t, PartId part)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => Table(part,  a.TableId, DefaultTableExt), () => Table(part, t.Name, DefaultTableExt));

        FS.FilePath Table<T>(PartId part)
            where T : struct, IRecord<T>
                => Table(typeof(T), part);

        FS.FilePath Table<S>(string id, S subject, FS.FileExt? ext = null)
            => TableRoot()+ FS.folder(id) + FS.file(text.format(DbNames.qualified, id, subject), ext ?? Csv);

        FS.FilePath IndexTable(string id)
            => IndexRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath IndexTable(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => IndexTable(a.TableId), () => IndexTable(t.Name));

        FS.FilePath IndexTable<T>()
            where T : struct, IRecord<T>
                => IndexTable(typeof(T));

        FS.FolderPath ListRoot()
            => Root + FS.folder(lists);

        FS.FilePath List(string name, FS.FileExt ext)
            => ListRoot() + FS.file(name, ext);

        FS.FolderPath Notebooks()
            => Root + FS.folder(notebooks);

        FS.FolderPath CaptureRoot()
            => Root + FS.folder(capture);

        FS.FolderPath ImmRoot()
            => CaptureRoot() + FS.folder(imm);

        FS.FolderPath JobRoot()
            => Root + FS.folder(jobs);

        FS.FolderPath IndexRoot()
            => TableRoot() + FS.folder(indices);

        FS.FilePath IndexFile(string id)
            => IndexRoot() + FS.file(id, Idx);

        FS.Files IndexFiles()
            => IndexRoot().Files(Idx);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder(queue);

        FS.FilePath JobPath(FS.FileName file)
            => JobQueue() + file;

        FS.FolderPath Notebook(string name)
            => Notebooks() + FS.folder(name);

        FS.FolderPath DocRoot()
            => Root + FS.folder(docs);

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

        FS.FolderPath ToolDbRoot()
            => Root + FS.folder("tooldb");

        FS.FolderPath ToolExeRoot()
            => Root + FS.folder(tools);

        FS.FolderPath BinaryRoot()
            => Root + FS.folder(bin);

        FS.FolderPath ProcDumpRoot()
            => BinaryRoot() +  FS.folder(dumps);

        FS.FilePath ProcDumpPath(Name process)
            => ProcDumpRoot() + FS.file(process.Format(), Dmp);

        FS.FolderPath CapturedHexRoot()
            => (CaptureRoot() + FS.folder(hex));

        FS.FilePath CapturedHexPath(FS.FileName name)
            => CapturedHexRoot() + name;

        FS.FolderPath Tools(ToolId id)
            => ToolExeRoot() + FS.folder(id.Format());

        FS.FolderPath Output(ToolId id)
            => Tools(id) + FS.folder(output);

        FS.FolderPath Output(ToolId tool, CmdId cmd)
            => ToolExeRoot() + FS.folder(tool.Format()) + FS.folder(cmd.Format()) + FS.folder(output);

        FS.FolderPath CapturedExtractDir()
            => CaptureRoot() + FS.folder(extracts);

        FS.Files ExtractFiles()
            => CapturedExtractDir().AllFiles;

        FS.FolderPath ParsedExtractDir()
            => CaptureRoot() + FS.folder(parsed);

        FS.FolderPath CapturedHexDir()
            => CaptureRoot() + FS.folder(hex);

        FS.FolderPath CapturedAsmDir()
            => CaptureRoot() + FS.folder(asm);

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

        FS.FilePath CapturedAsmFile(Type host)
            => CapturedAsmFile(ApiQuery.hosturi(host));

        FS.FilePath CapturedAsmFile<T>()
            => CapturedAsmFile(ApiQuery.hosturi<T>());

        FS.Files CapturedHexFiles()
            => CapturedHexDir().Files(Hex);

        FS.Files CapturedHexFiles(PartId part)
            => CapturedHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath CapturedHexFile(FS.FileName name)
            => CapturedHexDir() + name;

        FS.FilePath CapturedHexFile(PartId part, string api)
            => CapturedHexDir() + ApiFileName(part, api, Hex);

        FS.FilePath CapturedHexFile(ApiHostUri host)
            => CapturedHexFile(ApiIdentity.file(host, Hex));

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

        FS.Files ApiExtractFiles(PartId part)
            => ExtractFiles().Where(f => f.IsOwner(part));

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
            var hex = CapturedHexFiles();
            var asm = CapturedAsmFiles();
            return new PartFiles(parsed, hex, asm);
        }
    }
}