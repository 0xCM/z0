//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath StepLogRoot()
            => LogRoot() + FS.folder(steps);

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