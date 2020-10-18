//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Reifies an application environment service predicated on environment variables
    /// </summary>
    public struct Env
    {
        const string Dev = "ZDev";

        const string Log = "ZLogs";

        const string Pub = "ZArchive";

        const string Db = "ZDb";

        public FS.FolderPath LogRoot;

        public FS.FolderPath DevRoot;

        public FS.FolderPath ArchiveRoot;

        public FS.FolderPath DbRoot;

        [MethodImpl(Inline), Op]
        public static Env create()
        {
            var dst = new Env();
            dst.LogRoot = read(Log).Transform(FS.dir);
            dst.DevRoot = read(Dev).Transform(FS.dir);
            dst.DbRoot = read(Db).Transform(FS.dir);
            dst.ArchiveRoot = read(Pub).Transform(FS.dir);
            return dst;
        }

        [MethodImpl(Inline), Op]
        static EnvVar read(string name)
            => new EnvVar(name, Environment.GetEnvironmentVariable(name));

    }
}