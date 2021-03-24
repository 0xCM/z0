//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    partial interface IEnvPaths
    {
        FS.FolderPath AppLogRoot()
            => LogRoot() + FS.folder(apps);

        FS.FolderPath AppLogDir()
            => AppLogRoot() + FS.folder(AppName);

        FS.FilePath AppDataFile(FS.FileName file)
            => AppLogDir() + file;

        FS.FilePath AppLog(string id)
            => AppLogDir() + FS.file(id, Log);

        FS.FilePath AppLog(string id, FS.FileExt ext)
            => AppLogDir() + FS.file(id,ext);

        FS.FolderPath AppTableRoot
            => AppLogDir() + FS.folder(tables);

        FS.FolderPath AppTableDir<T>()
            where T : struct, IRecord<T>
                => AppTableRoot + TableFolder<T>();

        FS.FolderPath AppTableDir(Type t)
            => AppTableRoot + TableFolder(t);

        FS.FilePath AppTablePath<T>(string subject, FS.FileExt? ext = null)
            where T : struct, IRecord<T>
        {
            var id = TableId<T>();
            var dir = AppTableDir<T>();
            return dir + FS.file(string.Format("{0}.{1}", id, subject), ext ?? Csv);
        }

        FS.FilePath AppTablePath(Type t, string subject, FS.FileExt? ext = null)
        {
            var id = TableId(t);
            var dir = AppTableDir(t);
            return dir + FS.file(string.Format("{0}.{1}", id, subject), ext ?? Csv);
        }
    }
}