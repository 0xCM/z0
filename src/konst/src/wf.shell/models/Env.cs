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
        const string ZDev = nameof(ZDev);

        const string ZLogs = nameof(ZLogs);

        const string Pub = "ZArchive";

        const string ZDb = nameof(ZDb);

        public FS.FolderPath LogRoot;

        public FS.FolderPath DevRoot;

        public FS.FolderPath ArchiveRoot;

        public FS.FolderPath DbRoot;

        [MethodImpl(Inline), Op]
        public static Env create()
        {
            var dst = new Env();
            dst.LogRoot = read(ZLogs).Transform(FS.dir);
            dst.DevRoot = read(ZDev).Transform(FS.dir);
            dst.DbRoot = read(ZDb).Transform(FS.dir);
            dst.ArchiveRoot = read(Pub).Transform(FS.dir);
            return dst;
        }

        [MethodImpl(Inline), Op]
        static EnvVar read(string name)
        {
            var v = Environment.GetEnvironmentVariable(name);
            if(text.nonempty(v))
                return new EnvVar(name, v);
            else
                return EnvVar.Empty;
        }
    }
}