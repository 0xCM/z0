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

        WfExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>;
    }
}