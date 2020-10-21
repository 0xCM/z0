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
        [MethodImpl(Inline), Op]
        public static FileDbPaths paths(FS.FolderPath root)
            => new FileDbPaths(root);

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
        public static IDbTableArchive tables<S>(IWfShell wf, S subject)
            => new DbTables<S>(wf.Db(), subject);

        [MethodImpl(Inline), Op]
        public static IFileDb files(IWfShell wf, FileDbPaths paths)
            => new FileDb(wf, paths);

        [MethodImpl(Inline), Op]
        public string literal(N0 n)
            => Literals.asm;

        [MethodImpl(Inline), Op]
        public string literal(N1 n)
            => Literals.cs;
    }
}