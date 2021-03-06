//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IWfDb : IEnvPaths
    {
        FS.FolderPath Root {get;}

        FS.Files ClearTables<T>()
            where T : struct, IRecord<T>;

        ExecToken EmitTable<T>(ReadOnlySpan<T> src, string name)
            where T : struct, IRecord<T>;
    }
}