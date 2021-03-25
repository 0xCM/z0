//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWfDb : IEnvPaths, IFileArchive
    {
        FS.Files ClearTables<T>()
            where T : struct, IRecord<T>;

        FS.FilePath EmitSettings<T>(T settings)
            where T : ISettingsSet<T>, new();

        WfExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>;

        // ITableArchive TableArchive<S>(S subject)
        //     => new DbTables<S>(this, subject);
    }
}