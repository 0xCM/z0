//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static DbNames;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public partial interface IEnvPaths : IFileExtensions
    {
        Env Env {get;}

        FS.FolderPath PackageRoot()
            => Env.Packages.Value;

        FS.FolderPath DevRoot()
            => Env.DevRoot.Value;

        FS.FolderPath ArchiveRoot()
            => Env.Archives.Value;

        FS.FolderPath TmpRoot()
            => Env.Tmp.Value + FS.folder(tmp);

        FS.FolderPath ControlRoot()
            => Env.Control.Value;

        FS.FilePath ControlScript(FS.FileName src)
            => ControlCmdRoot() + src;

        FS.FolderPath ControlCmdRoot()
            => ControlRoot() + FS.folder(".cmd");

        FS.FolderPath Package(string id)
            => PackageRoot() + FS.folder(id);

        FS.FolderName SubjectFolder<S>(S src)
            => FS.folder(src.ToString().ToLowerInvariant());

        FS.FolderPath DbRoot()
            => Env.Db.Value;

        /// <summary>
        /// The root table directory
        /// </summary>
        FS.FolderPath TableRoot()
            => DbRoot() + FS.folder(tables);

        FS.FolderPath SettingsRoot()
            => DbRoot() + FS.folder(settings);

        FS.FilePath SettingsPath(string id)
            => SettingsRoot() + FS.file(id, Settings);

        FS.FolderPath DevRoot(string id)
            => DevRoot() + FS.folder(id);

        FS.FolderPath ZRoot()
            => DevRoot(z0);

        FS.FolderPath PartDir(string id)
            => ZRoot() + FS.folder(src) + FS.folder(id);

        FS.FolderPath PartDir(PartId id)
            => ZRoot() + FS.folder(src) + FS.folder(id.Componentize().Join('.'));

        FS.FilePath SourceFile(PartId id, FS.FileName name)
            => PartDir(id) + FS.folder(src) + name;

        FS.FolderPath SourceBuildRoot()
            => ZRoot() + FS.folder(build);

        FS.FolderPath BinaryRoot()
            => DbRoot() + FS.folder(bin);

        FS.FolderPath ProcDumpRoot()
            => BinaryRoot() +  FS.folder(dumps);

        FS.FolderPath RepoArchiveDir()
            => BinaryRoot() + FS.folder(source);

        FS.Files RepoArchives()
            => RepoArchiveDir().Files(Zip);

        FS.FileExt DefaultTableExt
             => Csv;

        FS.FolderPath DumpFileRoot()
            => BinaryRoot() + FS.folder(dumps);

        FS.FilePath DumpFilePath(string id)
            => DumpFileRoot() + FS.file(id, Dmp);

        FS.FilePath DumpFilePath(PartId id)
            => DumpFilePath(id.Format());

        FS.FolderPath EventRoot()
            => DbRoot() + FS.folder(events);

        FS.FolderPath RefDataRoot()
            => DbRoot() + FS.folder(refdata);

        FS.FolderPath LogRoot()
            => DbRoot() + FS.folder(logs);

        FS.FolderPath CmdLogRoot()
            => LogRoot() + FS.folder(commands);

        FS.FilePath TmpFile(FS.FileName file)
            => TmpRoot() + file;

        FS.FilePath TmpFile(string name, FS.FileExt ext)
            => TmpRoot() + FS.file(name, ext);

        FS.FolderPath TmpDir<S>(S subject)
            => TmpRoot() + SubjectFolder(subject);

        FS.FolderPath EtlRoot()
            => DbRoot() + FS.folder(etl);

        FS.FolderPath EtlLogRoot()
            => LogRoot() + FS.folder(etl);

        FS.FilePath EtlLog(string name)
            => EtlLogRoot() + FS.file(name, Log);

        FS.FolderPath EtlDir(string subject)
            => EtlRoot() + FS.folder(subject);

        FS.FilePath EtlFile(string subject, FS.FileName file)
            => EtlDir(subject) + file;

        FS.FolderPath EtlTableRoot()
            => EtlDir("tables");

        FS.FilePath CmdLog(ScriptId id)
            => CmdLogRoot() + (id.IsDiscriminated
                ? FS.file(string.Format("{0}-{1}", id.Id, id.Token), Log)
                : FS.file(id.Format(), Log));

        FS.FileName TableFileName<T>(string id)
            where T : struct, IRecord<T>
                => FS.file(string.Format("{0}.{1}", RecUtil.tableid<T>().Identifier, id), Csv);

        FS.FilePath EtlTable<T>(string id)
            where T : struct, IRecord<T>
                => EtlTableRoot() + TableFileName<T>(id);

        FS.FolderPath TestLogRoot()
            => LogRoot() + FS.folder(tests);

        FS.FolderPath TestLogDir(PartId id)
            => TestLogRoot() + FS.folder(id.Format());

        FS.FolderPath TestLogDir(FS.FolderName folder)
            => TestLogRoot() + folder;

        FS.FolderPath SortedCaseLogRoot()
            => TestLogRoot();

        FS.FolderPath ShowLogs()
            => LogRoot() + FS.folder("show");

        FS.FilePath ShowLog([Caller]string name = null, FS.FileExt? ext = null)
            => ShowLogs() + FS.file(name, ext ?? Log);

        /// <summary>
        /// Defines a task-specific log path
        /// </summary>
        /// <param name="subject">The subject identifier</param>
        FS.FilePath TaskLogPath(string subject, FS.FileExt ext)
            =>  LogRoot() + FS.file(subject, ext);

        FS.FolderPath ListRoot()
            => DbRoot() + FS.folder(lists);

        FS.FilePath List(string name, FS.FileExt ext)
            => ListRoot() + FS.file(name, ext);

        FS.FolderPath Notebooks()
            => DbRoot() + FS.folder(notebooks);

        FS.FolderPath JobRoot()
            => DbRoot() + FS.folder(jobs);

        FS.FolderPath IndexRoot()
            => TableRoot() + FS.folder(indices);

        FS.FilePath IndexFile(string id)
            => IndexRoot() + FS.file(id, Idx);

        FS.FilePath IndexFile(string subject, string id)
            => IndexDir(subject) + FS.file(id, Idx);

        FS.Files IndexFiles()
            => IndexRoot().Files(Idx);

        FS.FolderPath JobQueue()
            => JobRoot() + FS.folder(queue);

        FS.FilePath JobPath(FS.FileName file)
            => JobQueue() + file;

        FS.FolderPath Notebook(string name)
            => Notebooks() + FS.folder(name);

        FS.FolderPath DocRoot()
            => DbRoot() + FS.folder(docs);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FilePath Doc<S>(S subject, string name, FS.FileExt ext)
            => DocRoot() + SubjectFolder(subject) + FS.file(name, ext);

        FS.FilePath ProcDumpPath(Name process)
            => ProcDumpRoot() + FS.file(process.Format(), Dmp);

        FS.FolderPath Sources()
            => DbRoot() + FS.folder("sources");

        FS.FolderPath Source(string id)
            => Sources() + FS.folder(id);

        string AppName
            => Assembly.GetEntryAssembly().GetSimpleName();

        FS.FilePath SortedCaseLogPath()
            => SortedCaseLogRoot() + FS.file(AppName, Csv);

        FS.FolderPath CaptureRoot()
            => DbRoot() + FS.folder(capture);

        FS.FileName LegalFileName(OpIdentity id, FS.FileExt ext)
            => id.ToFileName(ext);

        FS.FileName LegalFileName(ApiHostUri host, FS.FileExt ext)
            => FS.file(string.Concat(host.Owner.Format(), Chars.Dot, host.Name), ext);

        FS.FileName ApiFileName(PartId part, string api, FS.FileExt ext)
            => FS.file(string.Format("{0}.{1}", part.Format(), api), ext);
    }
}