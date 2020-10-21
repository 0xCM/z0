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

        const string CORE_ROOT = nameof(CORE_ROOT);

        public FS.FolderPath LogRoot;

        public FS.FolderPath DevRoot;

        public FS.FolderPath ArchiveRoot;

        public FS.FolderPath DbRoot;

        public FS.FolderPath ClrCoreRoot;

        public FS.FolderPath BuildPubRoot;

        [MethodImpl(Inline), Op]
        public static Env create()
        {
            var dst = new Env();
            dst.LogRoot = read(ZLogs).Transform(FS.dir);
            dst.DevRoot = read(ZDev).Transform(FS.dir);
            dst.DbRoot = read(ZDb).Transform(FS.dir);
            dst.ArchiveRoot = read(Pub).Transform(FS.dir);
            dst.ClrCoreRoot = read("CORE_ROOT").Transform(FS.dir);
            dst.BuildPubRoot = FS.dir(@"J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64");
            return dst;
        }

        [MethodImpl(Inline), Op]
        static EnvVar read(string name)
            => new EnvVar(name, Environment.GetEnvironmentVariable(name));
    }
}