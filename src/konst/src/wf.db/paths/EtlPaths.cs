//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static DbNames;

    partial interface IEnvPaths
    {

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

        FS.FilePath EtlTable<T>(string id)
            where T : struct, IRecord<T>
                => EtlTableRoot() + TableFileName<T>(id);
    }
}