//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EnvFolders;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial interface IEnvPaths
    {
        FS.FolderPath CaseRoot()
            => DbRoot() + FS.folder(cases);

        FS.FolderPath CaseDir<T>(T subject)
            => CaseRoot() + FS.folder(string.Format("{0}", subject));

        FS.FolderPath CaseDir<T,D>(T subject, D discriminator)
            => CaseDir(subject) + FS.folder(string.Format("{0}", discriminator));

        FS.FilePath CasePath<T,K>(T subject, K id, FS.FileExt ext)
            => CaseDir(subject) + FS.file(id.ToString(), ext);

        FS.FilePath CasePath<T,D,K>(T subject, D discriminator, K id, FS.FileExt ext)
            => CaseDir(subject, discriminator) + FS.file(id.ToString(), ext);

        FS.FolderPath TestLogRoot()
            => LogRoot() + FS.folder(tests);

        FS.FolderPath TestLogDir(PartId id)
            => TestLogRoot() + FS.folder(id.Format());

        FS.FolderPath TestAppLogRoot(string app)
            => TestLogRoot() + FS.folder(app.Replace("z0.", string.Empty));

        FS.FolderPath TestAppLogRoot(Type t)
            => TestLogDir(t.Assembly.Id());

        FS.FolderPath TestAppLogRoot<T>()
            => TestAppLogRoot(typeof(T));

        FS.FolderPath TestAppLogRoot()
            => TestAppLogRoot(AppName);

        FS.FolderPath UnitLogRoot<T>()
            => TestLogDir(typeof(T).Assembly.Id()) + FS.folder(typeof(T).Name);

        FS.FolderPath UnitLogRoot(string app, string unit)
            => TestAppLogRoot(app) + FS.folder(unit);

        FS.FilePath CaseLogPath(string app, string unit, FS.FileExt ext, [Caller] string name = null)
            => UnitLogRoot(app,unit) + FS.file(name, ext);

        FS.FilePath CaseLogPath<T>(FS.FileExt ext, [Caller] string name = null)
            => UnitLogRoot<T>() + FS.file(name,ext);

        FS.FolderPath TestLogSummaryRoot()
            => TestLogRoot();

        FS.FilePath CaseLogSummary()
            => TestLogSummaryRoot() + FS.file(AppName, FS.Csv);
    }
}