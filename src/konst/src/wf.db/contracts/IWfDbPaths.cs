//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    public interface IDbPaths : IApiPathProvider, IFileArchive, IService
    {
        Env Env {get;}

        FS.FolderName SubjectFolder<S>(S src)
            => FS.folder(src.ToString().ToLowerInvariant());

        FS.FolderPath SettingsRoot()
            => Root + FS.folder(settings);

        FS.FilePath SettingsPath(string id)
            => SettingsRoot() + FS.file(id, Settings);

        FS.FolderPath PackageRoot()
            => Env.Packages.Value;

        FS.FolderPath Package(string id)
            => PackageRoot() + FS.folder(id);

        FS.FolderPath DevRoot()
            => Env.DevRoot.Value;

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

        FS.FolderPath ArchiveRoot()
            => Env.Archives.Value;

        FS.FolderPath SourceBuildRoot()
            => ZRoot() + FS.folder(build);

        FS.FolderPath BuildArchiveRoot()
            => BinaryRoot() + FS.folder(builds);

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

        FS.FolderPath CmdLogRoot()
            => LogRoot() + FS.folder(commands);

        FS.FilePath CmdLog(ScriptId id)
            => CmdLogRoot() + (id.IsDiscriminated
                ? FS.file(string.Format("{0}-{1}", id.Id, id.Token), Log)
                : FS.file(id.Format(), Log));

        FS.FolderPath EtlRoot()
            => Root + FS.folder(etl);

        FS.FolderPath AppLogRoot()
            => LogRoot() + FS.folder(apps);

        FS.FolderPath TestLogRoot()
            => LogRoot() + FS.folder(tests);

        FS.FolderPath TestLogDir(PartId id)
            => TestLogRoot() + FS.folder(id.Format());

        FS.FolderPath TestLogDir(FS.FolderName folder)
            => TestLogRoot() + folder;

        FS.FolderPath SortedCaseLogRoot()
            => TestLogRoot();

        FS.FilePath SortedCaseLogPath()
            => SortedCaseLogRoot() + FS.file(AppName, Csv);

        FS.FilePath AppLog(string id)
            =>  AppLogRoot() + FS.file(id, Log);

        FS.FilePath AppLog(string id, FS.FileExt ext)
            => AppLogRoot() + FS.file(id,ext);

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

        string TableId(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => a.TableId, () => t.Name);

        string TableId<T>()
            => TableId(typeof(T));

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

        FS.FolderPath IndexDir(Type t)
            => IndexRoot() + FS.folder(TableId(t));

        FS.FolderPath IndexDir(string subject)
            => IndexRoot() + FS.folder(subject);

        FS.FolderPath IndexDir<T>()
            where T : struct, IRecord<T>
                => IndexRoot() + FS.folder(TableId<T>());

        FS.FilePath IndexTable(string id)
            => IndexRoot() + FS.file(id, DefaultTableExt);

        FS.FilePath IndexTable(Type t)
            => t.Tag<RecordAttribute>().MapValueOrElse(a => IndexTable(a.TableId), () => IndexTable(t.Name));

        FS.FilePath IndexTable<T>()
            where T : struct, IRecord<T>
                => IndexTable(typeof(T));

        FS.FilePath IndexTable(Type t, string discriminator)
            => IndexDir(t) + FS.file(TableId(t) + discriminator, DefaultTableExt);

        FS.FilePath IndexTable<T>(string discriminator)
            where T : struct, IRecord<T>
                => IndexDir(typeof(T)) + FS.file(TableId<T>() + "." + discriminator, DefaultTableExt);

        FS.FolderPath ListRoot()
            => Root + FS.folder(lists);

        FS.FilePath List(string name, FS.FileExt ext)
            => ListRoot() + FS.file(name, ext);

        FS.FolderPath Notebooks()
            => Root + FS.folder(notebooks);

        FS.FolderPath JobRoot()
            => Root + FS.folder(jobs);

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
            => Root + FS.folder(docs);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot() + FS.file(name, ext);

        FS.FilePath Doc<S>(S subject, string name, FS.FileExt ext)
            => DocRoot() + SubjectFolder(subject) + FS.file(name, ext);

        FS.FolderPath ControlRoot()
            => Env.create().Control.Value;

        FS.FolderPath ControlCmdRoot()
            => ControlRoot() + FS.folder(".cmd");

        FS.FilePath ControlScript(FS.FileName src)
            => ControlCmdRoot() + src;

        FS.FolderPath ToolScriptRoot()
            => DevRoot("tooling") + FS.folder("scripts");

        FS.FolderPath ToolOutRoot()
            => Root + FS.folder(tools);

        FS.FolderPath ToolOutDir(ToolId tool)
            => ToolOutRoot() + FS.folder(tool.Format());

        FS.FilePath ToolOutPath(ToolId tool, string id, FS.FileExt ext)
            => ToolOutDir(tool) + FS.file(id, ext);

        FS.Files ToolOutFiles(ToolId tool)
            => ToolOutDir(tool).EnumerateFiles(true).Array();

        FS.FolderPath ToolScriptDir(ToolId tool)
            => ToolScriptRoot() + FS.folder(tool.Format());

        FS.FilePath ToolScript(ToolId tool, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(tool) + FS.file(script.Format(), ext ?? FS.Extensions.Cmd);

        FS.FilePath Script(ToolId tool, FS.FileName file)
            => ToolScriptDir(tool) +  file;

        FS.FolderPath ToolScriptDir<K>(K kind)
            => ToolScriptRoot() + FS.folder(kind.ToString());

        FS.FilePath ToolScript<K>(K kind, ScriptId script, FS.FileExt? ext = null)
            => ToolScriptDir(kind) + FS.file(script.Format(), ext ?? FS.Extensions.Cmd);

        FS.FolderPath ToolCatalogRoot()
            => DevRoot("tooling") + FS.folder("catalog");

        FS.FolderPath ToolExeRoot()
            => Root + FS.folder(tools);

        FS.FolderPath BinaryRoot()
            => Root + FS.folder(bin);

        FS.FolderPath ProcDumpRoot()
            => BinaryRoot() +  FS.folder(dumps);

        FS.FilePath ProcDumpPath(Name process)
            => ProcDumpRoot() + FS.file(process.Format(), Dmp);

        FS.FolderPath Tools(ToolId id)
            => ToolExeRoot() + FS.folder(id.Format());

        FS.FolderPath Output(ToolId id)
            => Tools(id) + FS.folder(output);

        FS.FolderPath Output(ToolId tool, CmdId cmd)
            => ToolExeRoot() + FS.folder(tool.Format()) + FS.folder(cmd.Format()) + FS.folder(output);

        FS.FolderPath Sources()
            => Root + FS.folder("sources");

        FS.FolderPath Source(string id)
            => Sources() + FS.folder(id);
    }
}