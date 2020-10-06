//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IDatabasePaths
    {
        FS.FolderPath DbRoot
            => FS.dir(@"j:\database");

        FS.FilePath Table(string name)
            => DbRoot + FS.folder("tables") + FS.file(name,FileExtensions.Csv);

        FS.FilePath Table(string schema, string name)
            => DbRoot + FS.folder("tables") + FS.folder(schema) + FS.file(name,FileExtensions.Csv);

        FS.FilePath Doc(string name, FS.FileExt ext)
            => DbRoot + FS.folder("docs") + FS.file(name, ext);

    }
}