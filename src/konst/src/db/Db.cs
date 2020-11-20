//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Db, true)]
    public readonly partial struct Db
    {
        [Op]
        public static PartFiles partfiles(IWfShell wf)
        {
            var db = wf.Db();
            var parsed = db.ParsedExtractFiles();
            var hex = db.CapturedHexFiles();
            var asm = db.CapturedAsmFiles();
            return new PartFiles(parsed, hex, asm);
        }

        [MethodImpl(Inline), Op]
        public static ITableStore tables<S>(IWfShell wf, S subject)
            => new FileDbTables<S>(wf.Db(), subject);

        [MethodImpl(Inline), Op]
        public static IFileDb create(FileDbPaths paths)
            => new FileDb(paths);
    }
}