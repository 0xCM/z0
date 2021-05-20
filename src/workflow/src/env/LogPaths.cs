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

        FS.FolderPath CmdLogRoot()
            => LogRoot() + FS.folder(commands);

        FS.FolderPath ShowLogRoot()
            => LogRoot() + FS.folder(show);

        FS.FolderPath BuildLogRoot()
            => LogRoot() + FS.folder(build);

        FS.FolderPath StepLogRoot()
            => LogRoot() + FS.folder(steps);

        FS.FolderPath AppLogRoot()
            => LogRoot() + FS.folder(apps);

        FS.FolderPath AppLogDir()
            => AppLogRoot() + FS.folder(AppName);

        FS.FilePath AppLog(string id)
            => AppLogDir() + FS.file(id, FS.Log);

        FS.FilePath AppLog(string id, FS.FileExt ext)
            => AppLogDir() + FS.file(id,ext);

        FS.FilePath CmdLog(ScriptId id)
            => CmdLogRoot() + (id.IsDiscriminated
                ? FS.file(string.Format("{0}-{1}", id.Id, id.Token), X.Log)
                : FS.file(id.Format(), X.Log));

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

        FS.FilePath BuildLogPath(FS.FileName src)
            => BuildLogRoot() + src;
    }
}