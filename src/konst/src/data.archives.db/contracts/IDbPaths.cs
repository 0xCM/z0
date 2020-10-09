//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using api = DbArchives;

    public interface IDbPaths
    {
        FS.FolderPath DbRoot
            => FS.dir(@"j:\database");

        FS.FolderPath TableRoot
            => api.tableRoot(DbRoot);

        FS.FolderPath DocRoot
            => api.docRoot(DbRoot);

        FS.FilePath Table(string name)
            => TableRoot + FS.file(name,FileExtensions.Csv);

        FS.FilePath Table(string schema, string name)
            => TableRoot + FS.folder(schema) + FS.file(name,FileExtensions.Csv);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DocRoot + FS.file(name, ext);
    }
}