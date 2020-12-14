//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.Db, true)]
    public readonly partial struct DbSvc
    {
        [MethodImpl(Inline), Op]
        public static ITableArchive tables<S>(IWfShell wf, S subject)
            => new FileDbTables<S>(wf.Db(), subject);

        [MethodImpl(Inline), Op]
        public static IFileDb create(FS.FolderPath root)
            => new FileDb(root);
    }
}