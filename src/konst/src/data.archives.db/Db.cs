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
        public static IDbTableArchive tables<S>(IWfShell wf, S subject)
            => new DbTables<S>(wf.Db(), subject);

        [MethodImpl(Inline), Op]
        public static IDbFileArchive files(IWfShell wf, DbPaths paths)
            => new DbFiles(wf, paths);

        [MethodImpl(Inline), Op]
        public static ObjectName name(string src)
            => new ObjectName(src);

        [MethodImpl(Inline), Op]
        public static Relation relate(in ObjectName src, in ObjectName dst)
            => new Relation(src,dst);

        [MethodImpl(Inline), Op]
        public static Relation relate(string src, string dst)
            => relate(name(src), name(dst));

        [MethodImpl(Inline), Op]
        public static DbKey key(in ObjectName id)
            => new DbKey(id.Ref.Address);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DbKey<T> key<T>(T src)
            where T : unmanaged
                => src;

        [MethodImpl(Inline), Op]
        public string literal(N0 n)
            => Literals.asm;

        [MethodImpl(Inline), Op]
        public string literal(N1 n)
            => Literals.cs;
    }
}