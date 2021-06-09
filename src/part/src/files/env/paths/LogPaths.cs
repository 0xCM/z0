//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using X = FS;

    partial interface IEnvPaths
    {
        FS.FolderPath LogRoot()
            => DbRoot() + FS.folder(logs);

        FS.FolderPath LogRoot(FS.FolderPath root)
            => DbRoot(root) + FS.folder(logs);

        FS.FolderPath CmdLogRoot()
            => LogRoot() + FS.folder(commands);

        FS.FolderPath CmdLogRoot(FS.FolderPath root)
            => LogRoot(root) + FS.folder(commands);

        FS.FolderPath BuildLogRoot()
            => LogRoot() + FS.folder(dotbuild);

        FS.FolderPath BuildLogRoot(FS.FolderPath root)
            => LogRoot(root) + FS.folder(dotbuild);

        FS.FilePath BuildLogPath(FS.FileName src)
            => BuildLogRoot() + src;

        FS.FilePath BuildLogPath(FS.FolderPath root, FS.FileName src)
            => BuildLogRoot(root) + src;

        FS.FolderPath AppLogRoot()
            => LogRoot() + FS.folder(apps);

        FS.FolderPath AppLogRoot(FS.FolderPath root)
            => LogRoot(root) + FS.folder(apps);

        FS.FolderPath AppLogDir()
            => AppLogRoot() + FS.folder(AppName);

        FS.FolderPath AppLogDir(string id)
            => AppLogDir() + FS.folder(id);

        FS.FolderPath AppLogDir(FS.FolderPath root)
            => AppLogRoot(root) + FS.folder(AppName);

        FS.FolderPath StepLogRoot()
            => LogRoot() + FS.folder(steps);

        FS.FilePath AppLog(string id)
            => AppLogDir() + FS.file(id, FS.Log);

        FS.FilePath AppLog(string id, FS.FileExt ext)
            => AppLogDir() + FS.file(id,ext);

        FS.FilePath CmdLog(ScriptId id)
            => CmdLogRoot() + (id.IsDiscriminated
                ? FS.file(string.Format("{0}-{1}", id.Id, id.Token), X.Log)
                : FS.file(id.Format(), X.Log));

        FS.FolderPath ShowLogRoot()
            => LogRoot() + FS.folder(show);

        FS.FilePath ShowLog([Caller]string name = null, FS.FileExt? ext = null)
            => ShowLogRoot() + FS.file(name, ext ?? X.Log);

        FS.FilePath ShowLog(FS.FileName file)
            => ShowLogRoot() + file;

        FS.FilePath StepLogPath(WfStepId step, FS.FileExt ext)
            => StepLogRoot() + FS.file(step.Format(), ext);

        FS.FilePath StepLogPath<T>(WfStepId step, T subject, FS.FileExt ext)
            => StepLogRoot() + FS.file(string.Format("{0}.{1}", step.Format(), subject), ext);

        StepLog StepLog(WfStepId step, FS.FileExt ext)
            => new StepLog(StepLogPath(step,ext));

        StepLog StepLog<T>(WfStepId step, T subject, FS.FileExt ext)
            => new StepLog(StepLogPath(step,subject,ext));
    }
}